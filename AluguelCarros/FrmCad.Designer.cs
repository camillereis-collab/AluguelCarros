namespace AluguelCarros
{
    partial class FrmCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCad));
            this.lblName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarsenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbconfirmarsenha = new System.Windows.Forms.TextBox();
            this.btnaVoltar = new System.Windows.Forms.Button();
            this.lblCnh = new System.Windows.Forms.Label();
            this.txbCnh = new System.Windows.Forms.TextBox();
            this.PxbCad = new System.Windows.Forms.PictureBox();
            this.btnAdm = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblConfCod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PxbCad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(484, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(529, 166);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(515, 256);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(572, 116);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(176, 20);
            this.c.TabIndex = 3;
            this.c.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(572, 163);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(141, 20);
            this.txbCpf.TabIndex = 4;
            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(572, 253);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(141, 20);
            this.txbTelefone.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(593, 415);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(72, 23);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Salvar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(523, 297);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(526, 336);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarsenha
            // 
            this.lblConfirmarsenha.AutoSize = true;
            this.lblConfirmarsenha.Location = new System.Drawing.Point(628, 336);
            this.lblConfirmarsenha.Name = "lblConfirmarsenha";
            this.lblConfirmarsenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarsenha.TabIndex = 10;
            this.lblConfirmarsenha.Text = "Confirmar Senha";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(572, 294);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(165, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(487, 363);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(112, 20);
            this.txbsenha.TabIndex = 12;
            // 
            // txbconfirmarsenha
            // 
            this.txbconfirmarsenha.Location = new System.Drawing.Point(613, 363);
            this.txbconfirmarsenha.Name = "txbconfirmarsenha";
            this.txbconfirmarsenha.Size = new System.Drawing.Size(124, 20);
            this.txbconfirmarsenha.TabIndex = 13;
            this.txbconfirmarsenha.TextChanged += new System.EventHandler(this.txbconfirmarsenha_TextChanged);
            // 
            // btnaVoltar
            // 
            this.btnaVoltar.Location = new System.Drawing.Point(21, 420);
            this.btnaVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnaVoltar.Name = "btnaVoltar";
            this.btnaVoltar.Size = new System.Drawing.Size(56, 19);
            this.btnaVoltar.TabIndex = 15;
            this.btnaVoltar.Text = "Voltar";
            this.btnaVoltar.UseVisualStyleBackColor = true;
            this.btnaVoltar.Click += new System.EventHandler(this.btnaVoltar_Click);
            // 
            // lblCnh
            // 
            this.lblCnh.AutoSize = true;
            this.lblCnh.Location = new System.Drawing.Point(523, 212);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(30, 13);
            this.lblCnh.TabIndex = 16;
            this.lblCnh.Text = "CNH";
            // 
            // txbCnh
            // 
            this.txbCnh.Location = new System.Drawing.Point(572, 209);
            this.txbCnh.Name = "txbCnh";
            this.txbCnh.Size = new System.Drawing.Size(141, 20);
            this.txbCnh.TabIndex = 17;
            // 
            // PxbCad
            // 
            this.PxbCad.Image = ((System.Drawing.Image)(resources.GetObject("PxbCad.Image")));
            this.PxbCad.Location = new System.Drawing.Point(-13, -20);
            this.PxbCad.Name = "PxbCad";
            this.PxbCad.Size = new System.Drawing.Size(830, 463);
            this.PxbCad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PxbCad.TabIndex = 18;
            this.PxbCad.TabStop = false;
            // 
            // btnAdm
            // 
            this.btnAdm.Location = new System.Drawing.Point(149, 415);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(75, 23);
            this.btnAdm.TabIndex = 19;
            this.btnAdm.Text = "Salvar";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(70, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(103, 167);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(49, 13);
            this.lblFone.TabIndex = 21;
            this.lblFone.Text = "Telefone";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(125, 212);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(27, 13);
            this.lblRG.TabIndex = 22;
            this.lblRG.Text = "CPF";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(46, 260);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento.TabIndex = 23;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(112, 313);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Senha";
            // 
            // lblConfCod
            // 
            this.lblConfCod.AutoSize = true;
            this.lblConfCod.Location = new System.Drawing.Point(60, 363);
            this.lblConfCod.Name = "lblConfCod";
            this.lblConfCod.Size = new System.Drawing.Size(85, 13);
            this.lblConfCod.TabIndex = 25;
            this.lblConfCod.Text = "Confirmar Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(170, 360);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(171, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 31;
            // 
            // FrmCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConfCod);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.txbCnh);
            this.Controls.Add(this.lblCnh);
            this.Controls.Add(this.btnaVoltar);
            this.Controls.Add(this.txbconfirmarsenha);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblConfirmarsenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.c);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.PxbCad);
            this.Name = "FrmCad";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PxbCad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarsenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbconfirmarsenha;
        private System.Windows.Forms.Button btnaVoltar;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.TextBox txbCnh;
        private System.Windows.Forms.PictureBox PxbCad;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblConfCod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}