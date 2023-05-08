namespace CadastroEditora
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCadEditora = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtCodEditora = new System.Windows.Forms.TextBox();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gridCadEditora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCadEditora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadEditora
            // 
            this.lblCadEditora.AutoSize = true;
            this.lblCadEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEditora.Location = new System.Drawing.Point(464, 42);
            this.lblCadEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadEditora.Name = "lblCadEditora";
            this.lblCadEditora.Size = new System.Drawing.Size(238, 36);
            this.lblCadEditora.TabIndex = 0;
            this.lblCadEditora.Text = "Cadastro Editora";
            this.lblCadEditora.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(126, 135);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(126, 194);
            this.lblNomeEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(51, 20);
            this.lblNomeEditora.TabIndex = 2;
            this.lblNomeEditora.Text = "Nome";
            this.lblNomeEditora.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodEditora
            // 
            this.txtCodEditora.Enabled = false;
            this.txtCodEditora.Location = new System.Drawing.Point(296, 131);
            this.txtCodEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodEditora.Name = "txtCodEditora";
            this.txtCodEditora.Size = new System.Drawing.Size(205, 26);
            this.txtCodEditora.TabIndex = 3;
            this.txtCodEditora.TextChanged += new System.EventHandler(this.txtCodEditora_TextChanged);
            this.txtCodEditora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEditora_KeyPress);
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(296, 189);
            this.txtNomeEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(786, 26);
            this.txtNomeEditora.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(327, 262);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 57);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(657, 262);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(176, 57);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gridCadEditora
            // 
            this.gridCadEditora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCadEditora.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCadEditora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCadEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCadEditora.Location = new System.Drawing.Point(130, 365);
            this.gridCadEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridCadEditora.Name = "gridCadEditora";
            this.gridCadEditora.RowHeadersWidth = 62;
            this.gridCadEditora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCadEditora.Size = new System.Drawing.Size(952, 309);
            this.gridCadEditora.TabIndex = 7;
            this.gridCadEditora.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCadEditora_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gridCadEditora);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtCodEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCadEditora);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nova Editora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCadEditora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadEditora;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtCodEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView gridCadEditora;
    }
}

