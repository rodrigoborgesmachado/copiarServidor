namespace SubirServidor.Visao
{
    partial class FO_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_completo = new System.Windows.Forms.Panel();
            this.pan_configuracoes = new System.Windows.Forms.Panel();
            this.pan_centro = new System.Windows.Forms.Panel();
            this.grb_formulario = new System.Windows.Forms.GroupBox();
            this.btn_reloadServidores = new System.Windows.Forms.Button();
            this.btn_addTabelaPreco = new System.Windows.Forms.Button();
            this.cmb_servidores = new System.Windows.Forms.ComboBox();
            this.lbl_destinoArquivos = new System.Windows.Forms.Label();
            this.btn_diretorio = new System.Windows.Forms.Button();
            this.tbx_pastaOrigemArquivos = new System.Windows.Forms.TextBox();
            this.lbl_origem = new System.Windows.Forms.Label();
            this.pan_bottom = new System.Windows.Forms.Panel();
            this.lbl_progresso = new System.Windows.Forms.Label();
            this.prb_progress = new System.Windows.Forms.ProgressBar();
            this.btn_copiar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarServidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_completo.SuspendLayout();
            this.pan_configuracoes.SuspendLayout();
            this.pan_centro.SuspendLayout();
            this.grb_formulario.SuspendLayout();
            this.pan_bottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.pan_configuracoes);
            this.pan_completo.Controls.Add(this.menuStrip1);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(865, 448);
            this.pan_completo.TabIndex = 0;
            // 
            // pan_configuracoes
            // 
            this.pan_configuracoes.Controls.Add(this.pan_centro);
            this.pan_configuracoes.Controls.Add(this.pan_bottom);
            this.pan_configuracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_configuracoes.Location = new System.Drawing.Point(0, 24);
            this.pan_configuracoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_configuracoes.Name = "pan_configuracoes";
            this.pan_configuracoes.Size = new System.Drawing.Size(865, 424);
            this.pan_configuracoes.TabIndex = 1;
            // 
            // pan_centro
            // 
            this.pan_centro.Controls.Add(this.grb_formulario);
            this.pan_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_centro.Location = new System.Drawing.Point(0, 0);
            this.pan_centro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_centro.Name = "pan_centro";
            this.pan_centro.Size = new System.Drawing.Size(865, 388);
            this.pan_centro.TabIndex = 1;
            // 
            // grb_formulario
            // 
            this.grb_formulario.Controls.Add(this.btn_reloadServidores);
            this.grb_formulario.Controls.Add(this.btn_addTabelaPreco);
            this.grb_formulario.Controls.Add(this.cmb_servidores);
            this.grb_formulario.Controls.Add(this.lbl_destinoArquivos);
            this.grb_formulario.Controls.Add(this.btn_diretorio);
            this.grb_formulario.Controls.Add(this.tbx_pastaOrigemArquivos);
            this.grb_formulario.Controls.Add(this.lbl_origem);
            this.grb_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_formulario.Location = new System.Drawing.Point(0, 0);
            this.grb_formulario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_formulario.Name = "grb_formulario";
            this.grb_formulario.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_formulario.Size = new System.Drawing.Size(865, 388);
            this.grb_formulario.TabIndex = 0;
            this.grb_formulario.TabStop = false;
            this.grb_formulario.Text = "Gerenciar Arquivos para copiar";
            // 
            // btn_reloadServidores
            // 
            this.btn_reloadServidores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reloadServidores.BackgroundImage = global::SubirServidor.Properties.Resources.loop_100px20x20;
            this.btn_reloadServidores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reloadServidores.Location = new System.Drawing.Point(680, 65);
            this.btn_reloadServidores.Name = "btn_reloadServidores";
            this.btn_reloadServidores.Size = new System.Drawing.Size(20, 20);
            this.btn_reloadServidores.TabIndex = 22;
            this.btn_reloadServidores.UseVisualStyleBackColor = true;
            this.btn_reloadServidores.Click += new System.EventHandler(this.btn_reloadServidores_Click);
            // 
            // btn_addTabelaPreco
            // 
            this.btn_addTabelaPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addTabelaPreco.BackgroundImage = global::SubirServidor.Properties.Resources.plus20x20;
            this.btn_addTabelaPreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addTabelaPreco.Location = new System.Drawing.Point(657, 65);
            this.btn_addTabelaPreco.Name = "btn_addTabelaPreco";
            this.btn_addTabelaPreco.Size = new System.Drawing.Size(20, 20);
            this.btn_addTabelaPreco.TabIndex = 21;
            this.btn_addTabelaPreco.UseVisualStyleBackColor = true;
            this.btn_addTabelaPreco.Click += new System.EventHandler(this.btn_addServidor_Click);
            // 
            // cmb_servidores
            // 
            this.cmb_servidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_servidores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_servidores.FormattingEnabled = true;
            this.cmb_servidores.Location = new System.Drawing.Point(148, 62);
            this.cmb_servidores.Name = "cmb_servidores";
            this.cmb_servidores.Size = new System.Drawing.Size(503, 28);
            this.cmb_servidores.TabIndex = 16;
            // 
            // lbl_destinoArquivos
            // 
            this.lbl_destinoArquivos.AutoSize = true;
            this.lbl_destinoArquivos.Location = new System.Drawing.Point(15, 65);
            this.lbl_destinoArquivos.Name = "lbl_destinoArquivos";
            this.lbl_destinoArquivos.Size = new System.Drawing.Size(126, 20);
            this.lbl_destinoArquivos.TabIndex = 3;
            this.lbl_destinoArquivos.Text = "Destino dos arquivos:";
            // 
            // btn_diretorio
            // 
            this.btn_diretorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diretorio.Location = new System.Drawing.Point(658, 23);
            this.btn_diretorio.Name = "btn_diretorio";
            this.btn_diretorio.Size = new System.Drawing.Size(75, 27);
            this.btn_diretorio.TabIndex = 2;
            this.btn_diretorio.Text = "Diretorio";
            this.btn_diretorio.UseVisualStyleBackColor = true;
            this.btn_diretorio.Click += new System.EventHandler(this.btn_diretorio_Click);
            // 
            // tbx_pastaOrigemArquivos
            // 
            this.tbx_pastaOrigemArquivos.Enabled = false;
            this.tbx_pastaOrigemArquivos.Location = new System.Drawing.Point(148, 25);
            this.tbx_pastaOrigemArquivos.Name = "tbx_pastaOrigemArquivos";
            this.tbx_pastaOrigemArquivos.Size = new System.Drawing.Size(503, 24);
            this.tbx_pastaOrigemArquivos.TabIndex = 1;
            // 
            // lbl_origem
            // 
            this.lbl_origem.AutoSize = true;
            this.lbl_origem.Location = new System.Drawing.Point(15, 26);
            this.lbl_origem.Name = "lbl_origem";
            this.lbl_origem.Size = new System.Drawing.Size(126, 20);
            this.lbl_origem.TabIndex = 0;
            this.lbl_origem.Text = "Origem dos arquivos:";
            // 
            // pan_bottom
            // 
            this.pan_bottom.Controls.Add(this.lbl_progresso);
            this.pan_bottom.Controls.Add(this.prb_progress);
            this.pan_bottom.Controls.Add(this.btn_copiar);
            this.pan_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_bottom.Location = new System.Drawing.Point(0, 388);
            this.pan_bottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan_bottom.Name = "pan_bottom";
            this.pan_bottom.Size = new System.Drawing.Size(865, 36);
            this.pan_bottom.TabIndex = 0;
            // 
            // lbl_progresso
            // 
            this.lbl_progresso.AutoSize = true;
            this.lbl_progresso.Location = new System.Drawing.Point(365, 9);
            this.lbl_progresso.Name = "lbl_progresso";
            this.lbl_progresso.Size = new System.Drawing.Size(43, 20);
            this.lbl_progresso.TabIndex = 17;
            this.lbl_progresso.Text = "<info>";
            // 
            // prb_progress
            // 
            this.prb_progress.Location = new System.Drawing.Point(13, 7);
            this.prb_progress.Name = "prb_progress";
            this.prb_progress.Size = new System.Drawing.Size(346, 23);
            this.prb_progress.TabIndex = 6;
            // 
            // btn_copiar
            // 
            this.btn_copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar.Location = new System.Drawing.Point(787, 6);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(75, 27);
            this.btn_copiar.TabIndex = 3;
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.UseVisualStyleBackColor = true;
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarServidoresToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // gerenciarServidoresToolStripMenuItem
            // 
            this.gerenciarServidoresToolStripMenuItem.Name = "gerenciarServidoresToolStripMenuItem";
            this.gerenciarServidoresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gerenciarServidoresToolStripMenuItem.Text = "Gerenciar Servidores";
            this.gerenciarServidoresToolStripMenuItem.Click += new System.EventHandler(this.btn_addServidor_Click);
            // 
            // FO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(865, 448);
            this.Controls.Add(this.pan_completo);
            this.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "FO_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir para Servidor";
            this.pan_completo.ResumeLayout(false);
            this.pan_completo.PerformLayout();
            this.pan_configuracoes.ResumeLayout(false);
            this.pan_centro.ResumeLayout(false);
            this.grb_formulario.ResumeLayout(false);
            this.grb_formulario.PerformLayout();
            this.pan_bottom.ResumeLayout(false);
            this.pan_bottom.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarServidoresToolStripMenuItem;
        private System.Windows.Forms.Panel pan_configuracoes;
        private System.Windows.Forms.Panel pan_centro;
        private System.Windows.Forms.GroupBox grb_formulario;
        private System.Windows.Forms.Panel pan_bottom;
        private System.Windows.Forms.TextBox tbx_pastaOrigemArquivos;
        private System.Windows.Forms.Label lbl_origem;
        private System.Windows.Forms.Button btn_diretorio;
        private System.Windows.Forms.ComboBox cmb_servidores;
        private System.Windows.Forms.Label lbl_destinoArquivos;
        private System.Windows.Forms.Button btn_copiar;
        private System.Windows.Forms.Label lbl_progresso;
        private System.Windows.Forms.ProgressBar prb_progress;
        private System.Windows.Forms.Button btn_addTabelaPreco;
        private System.Windows.Forms.Button btn_reloadServidores;
    }
}