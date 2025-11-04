namespace AluguelCarros
{
    partial class FrmConsultaVeiculos
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
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(532, 148);
            this.dgvVeiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.RowHeadersWidth = 51;
            this.dgvVeiculos.Size = new System.Drawing.Size(320, 185);
            this.dgvVeiculos.TabIndex = 0;
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(119, 108);
            this.cmbFiltroCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(160, 24);
            this.cmbFiltroCategoria.TabIndex = 1;
            this.cmbFiltroCategoria.Text = "filtro por categoria";
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(119, 281);
            this.btnLimparFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(100, 28);
            this.btnLimparFiltros.TabIndex = 3;
            this.btnLimparFiltros.Text = "Limpar Filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.Location = new System.Drawing.Point(119, 337);
            this.btnVerDetalhes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(100, 28);
            this.btnVerDetalhes.TabIndex = 4;
            this.btnVerDetalhes.Text = "ver detalhes";
            this.btnVerDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnAlugar
            // 
            this.btnAlugar.Location = new System.Drawing.Point(119, 405);
            this.btnAlugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(100, 28);
            this.btnAlugar.TabIndex = 5;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(115, 170);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "quantidade de carros";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(119, 223);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(132, 22);
            this.txtPesquisa.TabIndex = 7;
            this.txtPesquisa.Text = "Pesquisar";
            // 
            // FrmConsultaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.btnVerDetalhes);
            this.Controls.Add(this.btnLimparFiltros);
            this.Controls.Add(this.cmbFiltroCategoria);
            this.Controls.Add(this.dgvVeiculos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaVeiculos";
            this.Text = "FrmConsultaVeiculos";
            this.Load += new System.EventHandler(this.FrmConsultaVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}