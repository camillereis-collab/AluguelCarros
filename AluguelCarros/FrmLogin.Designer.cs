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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(249, 174);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome ";
            // 
            // lblEma
            // 
            this.lblEma.AutoSize = true;
            this.lblEma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEma.Location = new System.Drawing.Point(249, 254);
            this.lblEma.Name = "lblEma";
            this.lblEma.Size = new System.Drawing.Size(54, 22);
            this.lblEma.TabIndex = 2;
            this.lblEma.Text = "Email";
            // 
            // lblSen
            // 
            this.lblSen.AutoSize = true;
            this.lblSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSen.Location = new System.Drawing.Point(249, 347);
            this.lblSen.Name = "lblSen";
            this.lblSen.Size = new System.Drawing.Size(62, 22);
            this.lblSen.TabIndex = 3;
            this.lblSen.Text = "Senha";
            // 
            // lblConSen
            // 
            this.lblConSen.AutoSize = true;
            this.lblConSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSen.Location = new System.Drawing.Point(530, 347);
            this.lblConSen.Name = "lblConSen";
            this.lblConSen.Size = new System.Drawing.Size(145, 22);
            this.lblConSen.TabIndex = 4;
            this.lblConSen.Text = "Confirmar Senha";
            this.lblConSen.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(348, 174);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(199, 22);
            this.txbName.TabIndex = 5;
            // 
            // txbEma
            // 
            this.txbEma.Location = new System.Drawing.Point(348, 256);
            this.txbEma.Name = "txbEma";
            this.txbEma.Size = new System.Drawing.Size(199, 22);
            this.txbEma.TabIndex = 6;
            // 
            // txbSen
            // 
            this.txbSen.Location = new System.Drawing.Point(348, 347);
            this.txbSen.Name = "txbSen";
            this.txbSen.Size = new System.Drawing.Size(150, 22);
            this.txbSen.TabIndex = 7;
            // 
            // txbConSen
            // 
            this.txbConSen.Location = new System.Drawing.Point(708, 349);
            this.txbConSen.Name = "txbConSen";
            this.txbConSen.Size = new System.Drawing.Size(168, 22);
            this.txbConSen.TabIndex = 8;
            this.txbConSen.TextChanged += new System.EventHandler(this.txbConSen_TextChanged);
            // 
            // bntEntrar
            // 
            this.bntEntrar.Location = new System.Drawing.Point(780, 461);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(75, 23);
            this.bntEntrar.TabIndex = 9;
            this.bntEntrar.Text = "Entrar";
            this.bntEntrar.UseVisualStyleBackColor = true;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // btnAqui
            // 
            this.btnAqui.Location = new System.Drawing.Point(497, 471);
            this.btnAqui.Name = "btnAqui";
            this.btnAqui.Size = new System.Drawing.Size(64, 23);
            this.btnAqui.TabIndex = 10;
            this.btnAqui.Text = "AQUI";
            this.btnAqui.UseVisualStyleBackColor = true;
            this.btnAqui.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(114, 461);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-17, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(966, 548);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 525);
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
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}