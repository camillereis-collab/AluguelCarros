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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbLocalRetirada
            // 
            this.txbLocalRetirada.Location = new System.Drawing.Point(307, 173);
            this.txbLocalRetirada.Name = "txbLocalRetirada";
            this.txbLocalRetirada.Size = new System.Drawing.Size(144, 22);
            this.txbLocalRetirada.TabIndex = 1;
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(497, 173);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(100, 22);
            this.txbData.TabIndex = 2;
            // 
            // txbHora
            // 
            this.txbHora.Location = new System.Drawing.Point(649, 173);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(100, 22);
            this.txbHora.TabIndex = 3;
            // 
            // lblLocalRetirada
            // 
            this.lblLocalRetirada.AutoSize = true;
            this.lblLocalRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalRetirada.Location = new System.Drawing.Point(293, 122);
            this.lblLocalRetirada.Name = "lblLocalRetirada";
            this.lblLocalRetirada.Size = new System.Drawing.Size(158, 20);
            this.lblLocalRetirada.TabIndex = 5;
            this.lblLocalRetirada.Text = "Local de Retirada";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(523, 122);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 22);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(670, 120);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 22);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-25, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(67, 406);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblLocalRetirada);
            this.Controls.Add(this.txbHora);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbLocalRetirada);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCentral";
            this.Text = "FrmCentral";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbLocalRetirada;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.Label lblLocalRetirada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnVoltar;
    }
}