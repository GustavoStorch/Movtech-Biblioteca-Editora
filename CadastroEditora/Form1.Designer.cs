namespace CadastroEditora
{
    partial class FormCadEditora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgDadosEditora = new System.Windows.Forms.DataGridView();
            this.colCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 12);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(13, 46);
            this.lblNomeEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(51, 20);
            this.lblNomeEditora.TabIndex = 2;
            this.lblNomeEditora.Text = "Nome";
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodEditora.Enabled = false;
            this.txtCodEditora.Location = new System.Drawing.Point(105, 9);
            this.txtCodEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.Size = new System.Drawing.Size(161, 26);
            this.txtCodEditora.TabIndex = 3;
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEditora.Location = new System.Drawing.Point(102, 43);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(718, 26);
            this.txtNomeEditora.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(580, 79);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(704, 79);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 34);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgDadosEditora
            // 
            this.dtgDadosEditora.AllowUserToAddRows = false;
            this.dtgDadosEditora.AllowUserToDeleteRows = false;
            this.dtgDadosEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosEditora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosEditora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEditora,
            this.colNomeEditora});
            this.dtgDadosEditora.Location = new System.Drawing.Point(4, 121);
            this.dtgDadosEditora.Name = "dtgDadosEditora";
            this.dtgDadosEditora.ReadOnly = true;
            this.dtgDadosEditora.RowHeadersWidth = 62;
            this.dtgDadosEditora.RowTemplate.Height = 28;
            this.dtgDadosEditora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosEditora.Size = new System.Drawing.Size(816, 361);
            this.dtgDadosEditora.TabIndex = 7;
            this.dtgDadosEditora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosEditora_CellDoubleClick);
            // 
            // colCodEditora
            // 
            this.colCodEditora.HeaderText = "Código";
            this.colCodEditora.MinimumWidth = 8;
            this.colCodEditora.Name = "colCodEditora";
            this.colCodEditora.ReadOnly = true;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.HeaderText = "Editora";
            this.colNomeEditora.MinimumWidth = 8;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // FormCadEditora
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 494);
            this.Controls.Add(this.dtgDadosEditora);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtCodEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.lblCodigo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCadEditora";
            this.Text = "Nova Editora";
            this.Load += new System.EventHandler(this.FormCadEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEditora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgDadosEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}

