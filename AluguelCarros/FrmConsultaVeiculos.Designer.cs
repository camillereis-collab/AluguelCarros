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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(560, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consulta de Veículos Disponíveis";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 60);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 1;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(74, 57);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(150, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(230, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(311, 60);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Items.AddRange(new object[] {
            "Todas",
            "Econômico",
            "Intermediário",
            "SUV",
            "Luxo",
            "Esportivo"});
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(372, 57);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(120, 21);
            this.cmbFiltroCategoria.TabIndex = 5;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Location = new System.Drawing.Point(498, 55);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(75, 23);
            this.btnLimparFiltros.TabIndex = 6;
            this.btnLimparFiltros.Text = "Limpar Filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(12, 90);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(560, 250);
            this.dgvVeiculos.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 350);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: 15 veículos";
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.Location = new System.Drawing.Point(372, 345);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(95, 23);
            this.btnVerDetalhes.TabIndex = 9;
            this.btnVerDetalhes.Text = "Ver Detalhes";
            this.btnVerDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnAlugar
            // 
            this.btnAlugar.Location = new System.Drawing.Point(477, 345);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(95, 23);
            this.btnAlugar.TabIndex = 10;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // FrmConsultaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.btnVerDetalhes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.btnLimparFiltros);
            this.Controls.Add(this.cmbFiltroCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Veículos - Aluguel de Carros";
            this.Load += new System.EventHandler(this.FrmConsultaVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.Button btnAlugar;
    }
}