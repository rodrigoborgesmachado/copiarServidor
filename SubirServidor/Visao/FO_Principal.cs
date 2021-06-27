using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirServidor.Visao
{
    public partial class FO_Principal : Form
    {
        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão diretório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_diretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_pastaOrigemArquivos.Text = dialog.SelectedPath.ToString();
                this.lbl_progresso.Visible = true;
                DirectoryInfo directory = new DirectoryInfo(tbx_pastaOrigemArquivos.Text);
                prb_progress.Maximum = directory.GetFiles().Count();
                this.lbl_progresso.Text = "0" + " de " + prb_progress.Maximum.ToString();

                this.btn_copiar.Enabled = true;
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção de recarregar os servidores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reloadServidores_Click(object sender, EventArgs e)
        {
            this.PopulaCombo();
        }

        /// <summary>
        /// Evento lançado no clique do botão de adicionar servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addServidor_Click(object sender, EventArgs e)
        {
            new Visao.FO_CadastroServidor().ShowDialog();
            this.IniciaFormulario();
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_Click(object sender, EventArgs e)
        {
            this.Copiar();
        }

        #endregion Eventos
        
        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Principal()
        {
            InitializeComponent();
            this.IniciaFormulario();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        public void IniciaFormulario()
        {
            this.lbl_progresso.Visible = false;
            this.btn_copiar.Enabled = false;
            this.prb_progress.Maximum = 0;
            this.prb_progress.Value = 0;

            this.PopulaCombo();
        }

        /// <summary>
        /// Método que popula o combo
        /// </summary>
        public void PopulaCombo()
        {
            string sentenca = new DAO.MD_Caminhosservidor().table.CreateCommandSQLTable() + " ORDER BY CODIGO";

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_servidores.DataSource = table.DefaultView;

            this.cmb_servidores.DisplayMember = "caminho";
            this.cmb_servidores.ValueMember = "codigo";

            if (table.Rows.Count > 0)
                this.cmb_servidores.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que inicializa a cópia
        /// </summary>
        private void Copiar()
        {
            if (string.IsNullOrEmpty(this.tbx_pastaOrigemArquivos.Text))
            {
                Util.Visao.Message.MensagemAlerta("Selecione um servidor!");
                return;
            }

            if (prb_progress.Maximum == 0)
            {
                Util.Visao.Message.MensagemAlerta("Não existe arquivos nesse diretórios para serem copiados");
                return;
            }

            string destino = new Model.MD_Caminhosservidor(int.Parse(this.cmb_servidores.SelectedValue.ToString())).DAO.Caminho;

            Task<List<string>> task = CopiarFiles(destino);

            while (!task.IsCompleted)
            {
                Task.Delay(1000);
            }

            if(task.Result.Count > 0)
            {
                Util.Visao.Message.MensagemAlerta("Houve erros ao copiar os arquivos: ");
                Util.Visao.Message.MensagemAlerta(string.Join(Environment.NewLine, task.Result));
            }
            else
            {
                Util.Visao.Message.MensagemSucesso("Arquivos copiados com sucesso!");
            }

            this.IniciaFormulario();
        }

        /// <summary>
        /// Método assyncrono que copia as telas
        /// </summary>
        async private Task<List<string>> CopiarFiles(string destino)
        {
            try
            {
                List<string> lista = new List<string>();
                int caminhoSaida = int.Parse(this.cmb_servidores.SelectedValue.ToString());
                DirectoryInfo directory = new DirectoryInfo(tbx_pastaOrigemArquivos.Text);

                directory.GetFiles().ToList().ForEach(file => {
                    if (!Model.MD_Arquivosservidor.VerificaExiste(file.Name, caminhoSaida))
                    {
                        Model.MD_Arquivosservidor arq = new Model.MD_Arquivosservidor(DataBase.Connection.GetIncrement(new DAO.MD_Arquivosservidor().table.Table_Name));
                        arq.DAO.Nomearquivo = file.Name;
                        arq.DAO.Statuscopia = "2";
                        arq.DAO.Caminhodestino = caminhoSaida;
                        arq.DAO.Diretorioorigem = file.FullName;
                        arq.DAO.Insert();

                        if (!Util.Funcoes.SubirParaServidor(file.FullName, destino))
                        {
                            lista.Add("Erro ao subir o aruqivo: " + file.FullName);
                            arq.DAO.Statuscopia = "3";
                        }
                        else
                        {
                            arq.DAO.Statuscopia = "1";
                        }
                        arq.DAO.Update();
                    }

                    prb_progress.Value++;
                    this.lbl_progresso.Text = prb_progress.Value.ToString() + " de " + prb_progress.Maximum.ToString() + " copiados";
                });
                return lista;
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro" + e.Message, Util.Global.TipoLog.SIMPLES);
                Util.Visao.Message.MensagemErro("Erro ao copiar. Erro: " + e.Message);
                return null;
            }
        }

        #endregion Métodos

    }
}
