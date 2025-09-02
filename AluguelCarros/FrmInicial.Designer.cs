namespace AluguelCarros
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.PtbInicial = new System.Windows.Forms.PictureBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnenter = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbInicial
            // 
            this.PtbInicial.Image = ((System.Drawing.Image)(resources.GetObject("PtbInicial.Image")));
            this.PtbInicial.Location = new System.Drawing.Point(-6, -3);
            this.PtbInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PtbInicial.Name = "PtbInicial";
            this.PtbInicial.Size = new System.Drawing.Size(616, 369);
            this.PtbInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbInicial.TabIndex = 0;
            this.PtbInicial.TabStop = false;
            this.PtbInicial.UseWaitCursor = true;
            this.PtbInicial.Click += new System.EventHandler(this.PtbInicial_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(50, 219);
            this.btnCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(80, 19);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastre-se";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(218, 219);
            this.btnenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(56, 19);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "Entrar";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(525, 337);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 19);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.PtbInicial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInicial";
            this.Text = "FrmInicial";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbInicial;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnSair;
    }
}