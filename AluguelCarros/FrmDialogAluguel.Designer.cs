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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelDetalhes = new System.Windows.Forms.Panel();
            this.panelResumo = new System.Windows.Forms.Panel();
            this.lblValorTotalValor = new System.Windows.Forms.Label();
            this.lblDiasValor = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.panelPeriodo = new System.Windows.Forms.Panel();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblRetirada = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.lblCNHValor = new System.Windows.Forms.Label();
            this.lblTelefoneValor = new System.Windows.Forms.Label();
            this.lblCPFValor = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblCNH = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelVeiculo = new System.Windows.Forms.Panel();
            this.lblValorDiariaValor = new System.Windows.Forms.Label();
            this.lblVeiculoValor = new System.Windows.Forms.Label();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelDetalhes.SuspendLayout();
            this.panelResumo.SuspendLayout();
            this.panelPeriodo.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Confirmar Aluguel";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelDetalhes);
            this.panelMain.Controls.Add(this.panelBotoes);
            this.panelMain.Controls.Add(this.lblTitulo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 500);
            this.panelMain.TabIndex = 1;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnCancelar);
            this.panelBotoes.Controls.Add(this.btnConfirmar);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotoes.Location = new System.Drawing.Point(0, 440);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Padding = new System.Windows.Forms.Padding(20);
            this.panelBotoes.Size = new System.Drawing.Size(550, 60);
            this.panelBotoes.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(280, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(150, 15);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(120, 30);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar Aluguel";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // panelDetalhes
            // 
            this.panelDetalhes.Controls.Add(this.panelResumo);
            this.panelDetalhes.Controls.Add(this.panelPeriodo);
            this.panelDetalhes.Controls.Add(this.panelCliente);
            this.panelDetalhes.Controls.Add(this.panelVeiculo);
            this.panelDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalhes.Location = new System.Drawing.Point(0, 50);
            this.panelDetalhes.Name = "panelDetalhes";
            this.panelDetalhes.Padding = new System.Windows.Forms.Padding(20);
            this.panelDetalhes.Size = new System.Drawing.Size(550, 390);
            this.panelDetalhes.TabIndex = 3;
            // 
            // panelResumo
            // 
            this.panelResumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumo.Controls.Add(this.lblValorTotalValor);
            this.panelResumo.Controls.Add(this.lblDiasValor);
            this.panelResumo.Controls.Add(this.lblValorTotal);
            this.panelResumo.Controls.Add(this.lblDias);
            this.panelResumo.Location = new System.Drawing.Point(280, 260);
            this.panelResumo.Name = "panelResumo";
            this.panelResumo.Padding = new System.Windows.Forms.Padding(10);
            this.panelResumo.Size = new System.Drawing.Size(250, 100);
            this.panelResumo.TabIndex = 3;
            // 
            // lblValorTotalValor
            // 
            this.lblValorTotalValor.AutoSize = true;
            this.lblValorTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblValorTotalValor.Location = new System.Drawing.Point(110, 55);
            this.lblValorTotalValor.Name = "lblValorTotalValor";
            this.lblValorTotalValor.Size = new System.Drawing.Size(52, 20);
            this.lblValorTotalValor.TabIndex = 3;
            this.lblValorTotalValor.Text = "R$ 0,00";
            // 
            // lblDiasValor
            // 
            this.lblDiasValor.AutoSize = true;
            this.lblDiasValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasValor.Location = new System.Drawing.Point(110, 25);
            this.lblDiasValor.Name = "lblDiasValor";
            this.lblDiasValor.Size = new System.Drawing.Size(16, 18);
            this.lblDiasValor.TabIndex = 2;
            this.lblDiasValor.Text = "0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(20, 55);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(89, 18);
            this.lblValorTotal.TabIndex = 1;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(20, 25);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(46, 18);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias:";
            // 
            // panelPeriodo
            // 
            this.panelPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPeriodo.Controls.Add(this.dtpDevolucao);
            this.panelPeriodo.Controls.Add(this.dtpRetirada);
            this.panelPeriodo.Controls.Add(this.lblDevolucao);
            this.panelPeriodo.Controls.Add(this.lblRetirada);
            this.panelPeriodo.Location = new System.Drawing.Point(20, 260);
            this.panelPeriodo.Name = "panelPeriodo";
            this.panelPeriodo.Padding = new System.Windows.Forms.Padding(10);
            this.panelPeriodo.Size = new System.Drawing.Size(250, 100);
            this.panelPeriodo.TabIndex = 2;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(100, 55);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(130, 23);
            this.dtpDevolucao.TabIndex = 3;
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetirada.Location = new System.Drawing.Point(100, 20);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(130, 23);
            this.dtpRetirada.TabIndex = 2;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucao.Location = new System.Drawing.Point(15, 57);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(88, 18);
            this.lblDevolucao.TabIndex = 1;
            this.lblDevolucao.Text = "Devolução:";
            // 
            // lblRetirada
            // 
            this.lblRetirada.AutoSize = true;
            this.lblRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirada.Location = new System.Drawing.Point(15, 22);
            this.lblRetirada.Name = "lblRetirada";
            this.lblRetirada.Size = new System.Drawing.Size(76, 18);
            this.lblRetirada.TabIndex = 0;
            this.lblRetirada.Text = "Retirada:";
            // 
            // panelCliente
            // 
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCliente.Controls.Add(this.lblCNHValor);
            this.panelCliente.Controls.Add(this.lblTelefoneValor);
            this.panelCliente.Controls.Add(this.lblCPFValor);
            this.panelCliente.Controls.Add(this.lblNomeValor);
            this.panelCliente.Controls.Add(this.lblCNH);
            this.panelCliente.Controls.Add(this.lblTelefone);
            this.panelCliente.Controls.Add(this.lblCPF);
            this.panelCliente.Controls.Add(this.lblNome);
            this.panelCliente.Location = new System.Drawing.Point(280, 20);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Padding = new System.Windows.Forms.Padding(10);
            this.panelCliente.Size = new System.Drawing.Size(250, 230);
            this.panelCliente.TabIndex = 1;
            // 
            // lblCNHValor
            // 
            this.lblCNHValor.AutoSize = true;
            this.lblCNHValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNHValor.Location = new System.Drawing.Point(70, 175);
            this.lblCNHValor.Name = "lblCNHValor";
            this.lblCNHValor.Size = new System.Drawing.Size(80, 18);
            this.lblCNHValor.TabIndex = 7;
            this.lblCNHValor.Text = "000000000";
            // 
            // lblTelefoneValor
            // 
            this.lblTelefoneValor.AutoSize = true;
            this.lblTelefoneValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneValor.Location = new System.Drawing.Point(90, 130);
            this.lblTelefoneValor.Name = "lblTelefoneValor";
            this.lblTelefoneValor.Size = new System.Drawing.Size(80, 18);
            this.lblTelefoneValor.TabIndex = 6;
            this.lblTelefoneValor.Text = "(00) 00000-0000";
            // 
            // lblCPFValor
            // 
            this.lblCPFValor.AutoSize = true;
            this.lblCPFValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFValor.Location = new System.Drawing.Point(60, 85);
            this.lblCPFValor.Name = "lblCPFValor";
            this.lblCPFValor.Size = new System.Drawing.Size(80, 18);
            this.lblCPFValor.TabIndex = 5;
            this.lblCPFValor.Text = "000.000.000-00";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeValor.Location = new System.Drawing.Point(70, 40);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(49, 18);
            this.lblNomeValor.TabIndex = 4;
            this.lblNomeValor.Text = "Nome";
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNH.Location = new System.Drawing.Point(15, 175);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(46, 18);
            this.lblCNH.TabIndex = 3;
            this.lblCNH.Text = "CNH:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(15, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(78, 18);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(15, 85);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 18);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // panelVeiculo
            // 
            this.panelVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVeiculo.Controls.Add(this.lblValorDiariaValor);
            this.panelVeiculo.Controls.Add(this.lblVeiculoValor);
            this.panelVeiculo.Controls.Add(this.lblValorDiaria);
            this.panelVeiculo.Controls.Add(this.lblVeiculo);
            this.panelVeiculo.Location = new System.Drawing.Point(20, 20);
            this.panelVeiculo.Name = "panelVeiculo";
            this.panelVeiculo.Padding = new System.Windows.Forms.Padding(10);
            this.panelVeiculo.Size = new System.Drawing.Size(250, 230);
            this.panelVeiculo.TabIndex = 0;
            // 
            // lblValorDiariaValor
            // 
            this.lblValorDiariaValor.AutoSize = true;
            this.lblValorDiariaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiariaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblValorDiariaValor.Location = new System.Drawing.Point(130, 85);
            this.lblValorDiariaValor.Name = "lblValorDiariaValor";
            this.lblValorDiariaValor.Size = new System.Drawing.Size(52, 20);
            this.lblValorDiariaValor.TabIndex = 3;
            this.lblValorDiariaValor.Text = "R$ 0,00";
            // 
            // lblVeiculoValor
            // 
            this.lblVeiculoValor.AutoSize = true;
            this.lblVeiculoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculoValor.Location = new System.Drawing.Point(85, 40);
            this.lblVeiculoValor.Name = "lblVeiculoValor";
            this.lblVeiculoValor.Size = new System.Drawing.Size(120, 20);
            this.lblVeiculoValor.TabIndex = 2;
            this.lblVeiculoValor.Text = "Marca - Modelo";
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiaria.Location = new System.Drawing.Point(15, 87);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(109, 18);
            this.lblValorDiaria.TabIndex = 1;
            this.lblValorDiaria.Text = "Valor Diária:";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(15, 42);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(69, 18);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // FrmDialogAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Aluguel - Aluguel de Carros";
            this.Load += new System.EventHandler(this.FrmDialogAluguel_Load);
            this.panelMain.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.panelDetalhes.ResumeLayout(false);
            this.panelResumo.ResumeLayout(false);
            this.panelResumo.PerformLayout();
            this.panelPeriodo.ResumeLayout(false);
            this.panelPeriodo.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panelVeiculo.ResumeLayout(false);
            this.panelVeiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelDetalhes;
        private System.Windows.Forms.Panel panelVeiculo;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panelPeriodo;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.Label lblRetirada;
        private System.Windows.Forms.Panel panelResumo;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblValorDiariaValor;
        private System.Windows.Forms.Label lblVeiculoValor;
        private System.Windows.Forms.Label lblCNHValor;
        private System.Windows.Forms.Label lblTelefoneValor;
        private System.Windows.Forms.Label lblCPFValor;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label lblValorTotalValor;
        private System.Windows.Forms.Label lblDiasValor;
    }
}