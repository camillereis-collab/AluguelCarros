namespace AluguelCarros
{
    partial class FrmLogin
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblcadastro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarsenha = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbconfirmarsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome Completo";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(42, 196);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(30, 274);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(118, 127);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(224, 20);
            this.c.TabIndex = 3;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(118, 193);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(141, 20);
            this.txbCpf.TabIndex = 4;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(118, 271);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(141, 20);
            this.txbTelefone.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(692, 383);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblcadastro
            // 
            this.lblcadastro.AutoSize = true;
            this.lblcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastro.Location = new System.Drawing.Point(214, 33);
            this.lblcadastro.Name = "lblcadastro";
            this.lblcadastro.Size = new System.Drawing.Size(211, 37);
            this.lblcadastro.TabIndex = 7;
            this.lblcadastro.Text = "Cadastre- se";
            this.lblcadastro.Click += new System.EventHandler(this.lblcadastro_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(434, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(434, 189);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarsenha
            // 
            this.lblConfirmarsenha.AutoSize = true;
            this.lblConfirmarsenha.Location = new System.Drawing.Point(434, 277);
            this.lblConfirmarsenha.Name = "lblConfirmarsenha";
            this.lblConfirmarsenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarsenha.TabIndex = 10;
            this.lblConfirmarsenha.Text = "Confirmar Senha";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(530, 116);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(165, 20);
            this.txbEmail.TabIndex = 11;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(530, 189);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(165, 20);
            this.txbsenha.TabIndex = 12;
            // 
            // txbconfirmarsenha
            // 
            this.txbconfirmarsenha.Location = new System.Drawing.Point(530, 274);
            this.txbconfirmarsenha.Name = "txbconfirmarsenha";
            this.txbconfirmarsenha.Size = new System.Drawing.Size(166, 20);
            this.txbconfirmarsenha.TabIndex = 13;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbconfirmarsenha);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblConfirmarsenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblcadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.c);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblName);
            this.Name = "FrmLogin";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblcadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarsenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbconfirmarsenha;
    }
}