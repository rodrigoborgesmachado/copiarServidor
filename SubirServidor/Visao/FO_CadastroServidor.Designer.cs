namespace SubirServidor.Visao
{
    partial class FO_CadastroServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_CadastroServidor));
            this.grb_cadastrados = new System.Windows.Forms.GroupBox();
            this.dgv_cadsatrados = new System.Windows.Forms.DataGridView();
            this.grb_geral = new System.Windows.Forms.GroupBox();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.btn_removerItemGrid = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_info_ItemGrid = new System.Windows.Forms.Button();
            this.grb_cadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadsatrados)).BeginInit();
            this.grb_geral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_cadastrados
            // 
            this.grb_cadastrados.Controls.Add(this.btn_info_ItemGrid);
            this.grb_cadastrados.Controls.Add(this.btn_removerItemGrid);
            this.grb_cadastrados.Controls.Add(this.dgv_cadsatrados);
            this.grb_cadastrados.Controls.Add(this.btn_edit);
            this.grb_cadastrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_cadastrados.Location = new System.Drawing.Point(445, 0);
            this.grb_cadastrados.Name = "grb_cadastrados";
            this.grb_cadastrados.Size = new System.Drawing.Size(327, 241);
            this.grb_cadastrados.TabIndex = 21;
            this.grb_cadastrados.TabStop = false;
            this.grb_cadastrados.Text = "Cadastrados";
            // 
            // dgv_cadsatrados
            // 
            this.dgv_cadsatrados.AllowUserToAddRows = false;
            this.dgv_cadsatrados.AllowUserToDeleteRows = false;
            this.dgv_cadsatrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cadsatrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cadsatrados.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cadsatrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_cadsatrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cadsatrados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_cadsatrados.EnableHeadersVisualStyles = false;
            this.dgv_cadsatrados.Location = new System.Drawing.Point(6, 22);
            this.dgv_cadsatrados.MultiSelect = false;
            this.dgv_cadsatrados.Name = "dgv_cadsatrados";
            this.dgv_cadsatrados.RowHeadersVisible = false;
            this.dgv_cadsatrados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_cadsatrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cadsatrados.ShowCellErrors = false;
            this.dgv_cadsatrados.ShowCellToolTips = false;
            this.dgv_cadsatrados.Size = new System.Drawing.Size(287, 213);
            this.dgv_cadsatrados.StandardTab = true;
            this.dgv_cadsatrados.TabIndex = 11;
            // 
            // grb_geral
            // 
            this.grb_geral.Controls.Add(this.tbx_descricao);
            this.grb_geral.Controls.Add(this.lbl_descricao);
            this.grb_geral.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb_geral.Location = new System.Drawing.Point(0, 0);
            this.grb_geral.Name = "grb_geral";
            this.grb_geral.Size = new System.Drawing.Size(445, 241);
            this.grb_geral.TabIndex = 20;
            this.grb_geral.TabStop = false;
            this.grb_geral.Text = "Cadastro de Servidor";
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 241);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(772, 35);
            this.pan_botton.TabIndex = 19;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(694, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.Location = new System.Drawing.Point(98, 22);
            this.tbx_descricao.MaxLength = 100;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.Size = new System.Drawing.Size(333, 20);
            this.tbx_descricao.TabIndex = 1;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(6, 25);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(48, 13);
            this.lbl_descricao.TabIndex = 5;
            this.lbl_descricao.Text = "Caminho";
            // 
            // btn_removerItemGrid
            // 
            this.btn_removerItemGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removerItemGrid.BackgroundImage = global::SubirServidor.Properties.Resources.close_100px20x20;
            this.btn_removerItemGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerItemGrid.Location = new System.Drawing.Point(299, 53);
            this.btn_removerItemGrid.Name = "btn_removerItemGrid";
            this.btn_removerItemGrid.Size = new System.Drawing.Size(20, 20);
            this.btn_removerItemGrid.TabIndex = 7;
            this.btn_removerItemGrid.UseVisualStyleBackColor = true;
            this.btn_removerItemGrid.Click += new System.EventHandler(this.btn_removerItemGrid_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackgroundImage = global::SubirServidor.Properties.Resources.lead_pencil_100px20x20;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Location = new System.Drawing.Point(299, 25);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(20, 20);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_info_ItemGrid
            // 
            this.btn_info_ItemGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_info_ItemGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_ItemGrid.BackgroundImage")));
            this.btn_info_ItemGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_ItemGrid.Location = new System.Drawing.Point(299, 80);
            this.btn_info_ItemGrid.Name = "btn_info_ItemGrid";
            this.btn_info_ItemGrid.Size = new System.Drawing.Size(20, 20);
            this.btn_info_ItemGrid.TabIndex = 12;
            this.btn_info_ItemGrid.UseVisualStyleBackColor = true;
            this.btn_info_ItemGrid.Click += new System.EventHandler(this.btn_info_ItemGrid_Click);
            // 
            // FO_CadastroServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(772, 276);
            this.Controls.Add(this.grb_cadastrados);
            this.Controls.Add(this.grb_geral);
            this.Controls.Add(this.pan_botton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FO_CadastroServidor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Servidor";
            this.grb_cadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cadsatrados)).EndInit();
            this.grb_geral.ResumeLayout(false);
            this.grb_geral.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_cadastrados;
        private System.Windows.Forms.Button btn_removerItemGrid;
        private System.Windows.Forms.DataGridView dgv_cadsatrados;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox grb_geral;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_info_ItemGrid;
    }
}