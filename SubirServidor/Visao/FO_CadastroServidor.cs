using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirServidor.Visao
{
    public partial class FO_CadastroServidor : Form
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Lista de servidores
        /// </summary>
        List<Model.MD_Caminhosservidor> lista = new List<Model.MD_Caminhosservidor>();

        /// <summary>
        /// Tarefa executando na tela
        /// </summary>
        Util.Enumerator.Tarefa tarefa;

        /// <summary>
        /// Servidor Corrente
        /// </summary>
        Model.MD_Caminhosservidor servidorCorrente;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(this.dgv_cadsatrados.SelectedRows.Count == 0)
            {
                Util.Visao.Message.MensagemAlerta("Selecione um item na tabela!");
            }
            else
            {
                servidorCorrente = this.lista.ElementAt(this.dgv_cadsatrados.SelectedRows[0].Index);
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaFormulario();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de remover item do grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerItemGrid_Click(object sender, EventArgs e)
        {
            if (this.dgv_cadsatrados.SelectedRows.Count == 0)
            {
                Util.Visao.Message.MensagemAlerta("Selecione um item na tabela!");
            }
            else
            {
                Model.MD_Caminhosservidor servidor = this.lista.ElementAt(this.dgv_cadsatrados.SelectedRows[0].Index);
                if (Util.Visao.Message.MensagemConfirmaçãoYesNo("Deseja realmente excluir o servidor: " + servidor.DAO.Caminho) == DialogResult.Yes)
                {
                    if (servidor.DAO.Delete())
                    {
                        Util.Visao.Message.MensagemSucesso("Excluído com sucesso!");
                        this.tarefa = Util.Enumerator.Tarefa.INCLUINDO;
                        this.InicializaFormulario();
                    }
                    else
                    {
                        Util.Visao.Message.MensagemErro("Erro ao excluir!");
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_ItemGrid_Click(object sender, EventArgs e)
        {
            if (this.dgv_cadsatrados.SelectedRows.Count == 0)
            {
                Util.Visao.Message.MensagemAlerta("Selecione um item na tabela!");
            }
            else
            {
                Model.MD_Caminhosservidor servidor = this.lista.ElementAt(this.dgv_cadsatrados.SelectedRows[0].Index);
                Util.Visao.Message.MensagemInformacao("O caminho do servidor é: " + servidor.DAO.Caminho);
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão de confirmar no formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Confirmar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_CadastroServidor()
        {
            InitializeComponent();
            this.tarefa = Util.Enumerator.Tarefa.INCLUINDO;
            InicializaFormulario();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a classe
        /// </summary>
        private void InicializaFormulario()
        {
            if(this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.tbx_descricao.Text = this.servidorCorrente.DAO.Caminho;
            }
            else
            {
                this.tbx_descricao.Text = String.Empty;
            }

            PopulaTabelaServidores();
        }

        /// <summary>
        /// Método que preenche a tabela dos servidores
        /// </summary>
        private void PopulaTabelaServidores()
        {
            this.dgv_cadsatrados.Rows.Clear();
            this.dgv_cadsatrados.Columns.Clear();

            this.lista = Model.MD_Caminhosservidor.RetornaTodos();
            this.dgv_cadsatrados.Columns.Add("Caminho", "Caminho");

            this.lista.ForEach(item => this.PopulaTabelaServidores(item));
        }

        /// <summary>
        /// Métodoq ue preenche a tabela de servidores cadstrados
        /// </summary>
        /// <param name="servidor"></param>
        private void PopulaTabelaServidores(Model.MD_Caminhosservidor servidor)
        {
            List<string> list = new List<string>();
            list.Add(servidor.DAO.Caminho);

            this.dgv_cadsatrados.Rows.Add(list.ToArray());
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (string.IsNullOrEmpty(this.tbx_descricao.Text))
            {
                this.tbx_descricao.Focus();
                Util.Visao.Message.MensagemAlerta("O servidor não pode estar em branco!");
            }
            else
            {
                this.servidorCorrente = new Model.MD_Caminhosservidor(DataBase.Connection.GetIncrement(new DAO.MD_Caminhosservidor().table.Table_Name));
                this.servidorCorrente.DAO.Caminho = this.tbx_descricao.Text;

                bool resultado = this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? this.servidorCorrente.DAO.Update() : this.servidorCorrente.DAO.Insert();
                if (!resultado)
                {
                    Util.Visao.Message.MensagemErro("Erro ao " + (this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? "editar" : "inserir") + "!");
                }
                else
                {
                    Util.Visao.Message.MensagemSucesso((this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? "Editado " : "Incluído ") + "com sucesso!");
                    if(Util.Visao.Message.MensagemConfirmaçãoYesNo("Deseja cadastrar mais servidores?") == DialogResult.Yes)
                    {
                        this.tarefa = Util.Enumerator.Tarefa.INCLUINDO;
                        this.InicializaFormulario();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        #endregion Métodos
    }
}
