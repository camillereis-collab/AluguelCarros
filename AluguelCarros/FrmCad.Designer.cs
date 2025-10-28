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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(414, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(469, 145);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(447, 229);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(532, 95);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(176, 20);
            this.c.TabIndex = 3;
            this.c.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(532, 142);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(141, 20);
            this.txbCpf.TabIndex = 4;
            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(532, 229);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(141, 20);
            this.txbTelefone.TabIndex = 5;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(687, 402);
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
            this.lblEmail.Location = new System.Drawing.Point(461, 271);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(458, 322);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarsenha
            // 
            this.lblConfirmarsenha.AutoSize = true;
            this.lblConfirmarsenha.Location = new System.Drawing.Point(414, 363);
            this.lblConfirmarsenha.Name = "lblConfirmarsenha";
            this.lblConfirmarsenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarsenha.TabIndex = 10;
            this.lblConfirmarsenha.Text = "Confirmar Senha";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(532, 268);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(532, 315);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(124, 20);
            this.txbsenha.TabIndex = 12;
            // 
            // txbconfirmarsenha
            // 
            this.txbconfirmarsenha.Location = new System.Drawing.Point(532, 356);
            this.txbconfirmarsenha.Name = "txbconfirmarsenha";
            this.txbconfirmarsenha.Size = new System.Drawing.Size(124, 20);
            this.txbconfirmarsenha.TabIndex = 13;
            this.txbconfirmarsenha.TextChanged += new System.EventHandler(this.txbconfirmarsenha_TextChanged);
            // 
            // btnaVoltar
            // 
            this.btnaVoltar.Location = new System.Drawing.Point(72, 402);
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
            this.lblCnh.Location = new System.Drawing.Point(466, 193);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(30, 13);
            this.lblCnh.TabIndex = 16;
            this.lblCnh.Text = "CNH";
            // 
            // txbCnh
            // 
            this.txbCnh.Location = new System.Drawing.Point(532, 186);
            this.txbCnh.Name = "txbCnh";
            this.txbCnh.Size = new System.Drawing.Size(141, 20);
            this.txbCnh.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCad";
            this.Text = "                      ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}