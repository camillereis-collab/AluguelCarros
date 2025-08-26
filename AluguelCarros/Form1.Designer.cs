namespace AluguelCarros
{
    partial class FrmRent
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCar = new System.Windows.Forms.Label();
            this.Txb = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCar
            // 
            this.LblCar.AutoSize = true;
            this.LblCar.Location = new System.Drawing.Point(12, 21);
            this.LblCar.Name = "LblCar";
            this.LblCar.Size = new System.Drawing.Size(100, 13);
            this.LblCar.TabIndex = 0;
            this.LblCar.Text = "Selecione o Carro...";
            this.LblCar.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txb
            // 
            this.Txb.Location = new System.Drawing.Point(12, 48);
            this.Txb.Name = "Txb";
            this.Txb.Size = new System.Drawing.Size(100, 20);
            this.Txb.TabIndex = 1;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(131, 45);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(75, 23);
            this.Btn.TabIndex = 2;
            this.Btn.Text = "Buscar";
            this.Btn.UseVisualStyleBackColor = true;
            // 
            // FrmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Txb);
            this.Controls.Add(this.LblCar);
            this.Name = "FrmRent";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FrmRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCar;
        private System.Windows.Forms.TextBox Txb;
        private System.Windows.Forms.Button Btn;
    }
}

