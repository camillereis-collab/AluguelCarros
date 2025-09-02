namespace AluguelCarros
{
    partial class FrmCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentral));
            this.txbLocalRetirada = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.lblLocalRetirada = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.PtbCentral = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // txbLocalRetirada
            // 
            this.txbLocalRetirada.Location = new System.Drawing.Point(230, 141);
            this.txbLocalRetirada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbLocalRetirada.Name = "txbLocalRetirada";
            this.txbLocalRetirada.Size = new System.Drawing.Size(109, 20);
            this.txbLocalRetirada.TabIndex = 1;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(373, 141);
            this.txbData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(76, 20);
            this.txbData.TabIndex = 2;
            // 
            // txbHora
            // 
            this.txbHora.Location = new System.Drawing.Point(487, 141);
            this.txbHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(76, 20);
            this.txbHora.TabIndex = 3;
            // 
            // lblLocalRetirada
            // 
            this.lblLocalRetirada.AutoSize = true;
            this.lblLocalRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalRetirada.Location = new System.Drawing.Point(220, 99);
            this.lblLocalRetirada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalRetirada.Name = "lblLocalRetirada";
            this.lblLocalRetirada.Size = new System.Drawing.Size(137, 17);
            this.lblLocalRetirada.TabIndex = 5;
            this.lblLocalRetirada.Text = "Local de Retirada";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(392, 99);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 18);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(502, 98);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 18);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // PtbCentral
            // 
            this.PtbCentral.Image = ((System.Drawing.Image)(resources.GetObject("PtbCentral.Image")));
            this.PtbCentral.Location = new System.Drawing.Point(-19, -27);
            this.PtbCentral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PtbCentral.Name = "PtbCentral";
            this.PtbCentral.Size = new System.Drawing.Size(630, 397);
            this.PtbCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCentral.TabIndex = 0;
            this.PtbCentral.TabStop = false;
            this.PtbCentral.Click += new System.EventHandler(this.PtbCentral_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(50, 330);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(56, 19);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblLocalRetirada);
            this.Controls.Add(this.txbHora);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbLocalRetirada);
            this.Controls.Add(this.PtbCentral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCentral";
            this.Text = "FrmCentral";
            ((System.ComponentModel.ISupportInitialize)(this.PtbCentral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbCentral;
        private System.Windows.Forms.TextBox txbLocalRetirada;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.Label lblLocalRetirada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnVoltar;
    }
}