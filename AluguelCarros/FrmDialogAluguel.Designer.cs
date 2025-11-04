namespace AluguelCarros
{
    partial class FrmDialogAluguel
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
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCNH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(48, 32);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(105, 16);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Marca e Modelo";
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(51, 80);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(78, 16);
            this.lblValorDiaria.TabIndex = 1;
            this.lblValorDiaria.Text = "Valor Diaria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(54, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(107, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Cliente";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(57, 161);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 16);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(54, 237);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 16);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(55, 265);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(106, 16);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias Calculados";
            this.lblDias.Click += new System.EventHandler(this.lblDias_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(57, 307);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(73, 16);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Location = new System.Drawing.Point(299, 74);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(200, 22);
            this.dtpRetirada.TabIndex = 7;
            this.dtpRetirada.Value = new System.DateTime(2025, 11, 3, 23, 34, 24, 0);
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(299, 171);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(200, 22);
            this.dtpDevolucao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Retirada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Devolução";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(302, 291);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(57, 193);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(36, 16);
            this.lblCNH.TabIndex = 13;
            this.lblCNH.Text = "CNH";
            // 
            // FrmDialogAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValorDiaria);
            this.Controls.Add(this.lblVeiculo);
            this.Name = "FrmDialogAluguel";
            this.Text = "Aluguel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCNH;
    }
}