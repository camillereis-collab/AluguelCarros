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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEma = new System.Windows.Forms.Label();
            this.lblSen = new System.Windows.Forms.Label();
            this.lblConSen = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbEma = new System.Windows.Forms.TextBox();
            this.txbSen = new System.Windows.Forms.TextBox();
            this.txbConSen = new System.Windows.Forms.TextBox();
            this.bntEntrar = new System.Windows.Forms.Button();
            this.btnAqui = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.PtbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(187, 141);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome ";
            // 
            // lblEma
            // 
            this.lblEma.AutoSize = true;
            this.lblEma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEma.Location = new System.Drawing.Point(187, 206);
            this.lblEma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEma.Name = "lblEma";
            this.lblEma.Size = new System.Drawing.Size(45, 18);
            this.lblEma.TabIndex = 2;
            this.lblEma.Text = "Email";
            // 
            // lblSen
            // 
            this.lblSen.AutoSize = true;
            this.lblSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSen.Location = new System.Drawing.Point(187, 282);
            this.lblSen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSen.Name = "lblSen";
            this.lblSen.Size = new System.Drawing.Size(50, 18);
            this.lblSen.TabIndex = 3;
            this.lblSen.Text = "Senha";
            // 
            // lblConSen
            // 
            this.lblConSen.AutoSize = true;
            this.lblConSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSen.Location = new System.Drawing.Point(398, 282);
            this.lblConSen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConSen.Name = "lblConSen";
            this.lblConSen.Size = new System.Drawing.Size(120, 18);
            this.lblConSen.TabIndex = 4;
            this.lblConSen.Text = "Confirmar Senha";
            this.lblConSen.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(261, 141);
            this.txbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(150, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbEma
            // 
            this.txbEma.Location = new System.Drawing.Point(261, 208);
            this.txbEma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbEma.Name = "txbEma";
            this.txbEma.Size = new System.Drawing.Size(150, 20);
            this.txbEma.TabIndex = 6;
            // 
            // txbSen
            // 
            this.txbSen.Location = new System.Drawing.Point(261, 282);
            this.txbSen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSen.Name = "txbSen";
            this.txbSen.Size = new System.Drawing.Size(114, 20);
            this.txbSen.TabIndex = 7;
            // 
            // txbConSen
            // 
            this.txbConSen.Location = new System.Drawing.Point(531, 284);
            this.txbConSen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbConSen.Name = "txbConSen";
            this.txbConSen.Size = new System.Drawing.Size(127, 20);
            this.txbConSen.TabIndex = 8;
            this.txbConSen.TextChanged += new System.EventHandler(this.txbConSen_TextChanged);
            // 
            // bntEntrar
            // 
            this.bntEntrar.Location = new System.Drawing.Point(585, 375);
            this.bntEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(56, 19);
            this.bntEntrar.TabIndex = 9;
            this.bntEntrar.Text = "Entrar";
            this.bntEntrar.UseVisualStyleBackColor = true;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // btnAqui
            // 
            this.btnAqui.Location = new System.Drawing.Point(373, 383);
            this.btnAqui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAqui.Name = "btnAqui";
            this.btnAqui.Size = new System.Drawing.Size(48, 19);
            this.btnAqui.TabIndex = 10;
            this.btnAqui.Text = "AQUI";
            this.btnAqui.UseVisualStyleBackColor = true;
            this.btnAqui.Click += new System.EventHandler(this.btnAqui_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(86, 375);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(56, 19);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // PtbLogin
            // 
            this.PtbLogin.Image = ((System.Drawing.Image)(resources.GetObject("PtbLogin.Image")));
            this.PtbLogin.Location = new System.Drawing.Point(-13, -6);
            this.PtbLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PtbLogin.Name = "PtbLogin";
            this.PtbLogin.Size = new System.Drawing.Size(724, 445);
            this.PtbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogin.TabIndex = 12;
            this.PtbLogin.TabStop = false;
            this.PtbLogin.Click += new System.EventHandler(this.PtbLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAqui);
            this.Controls.Add(this.bntEntrar);
            this.Controls.Add(this.txbConSen);
            this.Controls.Add(this.txbSen);
            this.Controls.Add(this.txbEma);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblConSen);
            this.Controls.Add(this.lblSen);
            this.Controls.Add(this.lblEma);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.PtbLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEma;
        private System.Windows.Forms.Label lblSen;
        private System.Windows.Forms.Label lblConSen;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbEma;
        private System.Windows.Forms.TextBox txbSen;
        private System.Windows.Forms.TextBox txbConSen;
        private System.Windows.Forms.Button bntEntrar;
        private System.Windows.Forms.Button btnAqui;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox PtbLogin;
    }
}