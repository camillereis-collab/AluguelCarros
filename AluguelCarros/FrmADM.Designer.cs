namespace AluguelCarros
{
    partial class FrmLogADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogADM));
            this.btnlogadm = new System.Windows.Forms.Button();
            this.lblEmailADM = new System.Windows.Forms.Label();
            this.lblSenhaADM = new System.Windows.Forms.Label();
            this.txbemailADM = new System.Windows.Forms.TextBox();
            this.txbsenhaADM = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAQUIADM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogadm
            // 
            this.btnlogadm.Location = new System.Drawing.Point(350, 333);
            this.btnlogadm.Name = "btnlogadm";
            this.btnlogadm.Size = new System.Drawing.Size(75, 23);
            this.btnlogadm.TabIndex = 1;
            this.btnlogadm.Text = "LOGIN";
            this.btnlogadm.UseVisualStyleBackColor = true;
            // 
            // lblEmailADM
            // 
            this.lblEmailADM.AutoSize = true;
            this.lblEmailADM.Location = new System.Drawing.Point(269, 193);
            this.lblEmailADM.Name = "lblEmailADM";
            this.lblEmailADM.Size = new System.Drawing.Size(35, 13);
            this.lblEmailADM.TabIndex = 2;
            this.lblEmailADM.Text = "E-mail";
            // 
            // lblSenhaADM
            // 
            this.lblSenhaADM.AutoSize = true;
            this.lblSenhaADM.Location = new System.Drawing.Point(269, 259);
            this.lblSenhaADM.Name = "lblSenhaADM";
            this.lblSenhaADM.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaADM.TabIndex = 3;
            this.lblSenhaADM.Text = "Senha";
            // 
            // txbemailADM
            // 
            this.txbemailADM.Location = new System.Drawing.Point(350, 193);
            this.txbemailADM.Name = "txbemailADM";
            this.txbemailADM.Size = new System.Drawing.Size(100, 20);
            this.txbemailADM.TabIndex = 4;
            // 
            // txbsenhaADM
            // 
            this.txbsenhaADM.Location = new System.Drawing.Point(350, 256);
            this.txbsenhaADM.Name = "txbsenhaADM";
            this.txbsenhaADM.Size = new System.Drawing.Size(100, 20);
            this.txbsenhaADM.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-24, -23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(832, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnAQUIADM
            // 
            this.btnAQUIADM.Location = new System.Drawing.Point(415, 404);
            this.btnAQUIADM.Name = "btnAQUIADM";
            this.btnAQUIADM.Size = new System.Drawing.Size(54, 23);
            this.btnAQUIADM.TabIndex = 7;
            this.btnAQUIADM.Text = "AQUI";
            this.btnAQUIADM.UseVisualStyleBackColor = true;
            // 
            // FrmLogADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAQUIADM);
            this.Controls.Add(this.txbsenhaADM);
            this.Controls.Add(this.txbemailADM);
            this.Controls.Add(this.lblSenhaADM);
            this.Controls.Add(this.lblEmailADM);
            this.Controls.Add(this.btnlogadm);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmLogADM";
            this.Text = "FrmLogADM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogadm;
        private System.Windows.Forms.Label lblEmailADM;
        private System.Windows.Forms.Label lblSenhaADM;
        private System.Windows.Forms.TextBox txbemailADM;
        private System.Windows.Forms.TextBox txbsenhaADM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAQUIADM;
    }
}