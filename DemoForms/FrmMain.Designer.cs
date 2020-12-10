
namespace DemoForms
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlQuadro = new System.Windows.Forms.Panel();
            this.lblDimQuadro = new System.Windows.Forms.Label();
            this.mtbDim = new System.Windows.Forms.MaskedTextBox();
            this.lblNColori = new System.Windows.Forms.Label();
            this.nudNColori = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNColori)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuadro
            // 
            this.pnlQuadro.BackColor = System.Drawing.Color.White;
            this.pnlQuadro.Location = new System.Drawing.Point(12, 12);
            this.pnlQuadro.Name = "pnlQuadro";
            this.pnlQuadro.Size = new System.Drawing.Size(100, 100);
            this.pnlQuadro.TabIndex = 0;
            // 
            // lblDimQuadro
            // 
            this.lblDimQuadro.AutoSize = true;
            this.lblDimQuadro.Location = new System.Drawing.Point(19, 395);
            this.lblDimQuadro.Name = "lblDimQuadro";
            this.lblDimQuadro.Size = new System.Drawing.Size(147, 20);
            this.lblDimQuadro.TabIndex = 1;
            this.lblDimQuadro.Text = "Dimensione quadro";
            // 
            // mtbDim
            // 
            this.mtbDim.Location = new System.Drawing.Point(214, 389);
            this.mtbDim.Mask = "999";
            this.mtbDim.Name = "mtbDim";
            this.mtbDim.Size = new System.Drawing.Size(51, 26);
            this.mtbDim.TabIndex = 2;
            this.mtbDim.Text = "100";
            this.mtbDim.ValidatingType = typeof(int);
            // 
            // lblNColori
            // 
            this.lblNColori.AutoSize = true;
            this.lblNColori.Location = new System.Drawing.Point(19, 428);
            this.lblNColori.Name = "lblNColori";
            this.lblNColori.Size = new System.Drawing.Size(106, 20);
            this.lblNColori.TabIndex = 3;
            this.lblNColori.Text = "Numero colori";
            // 
            // nudNColori
            // 
            this.nudNColori.Location = new System.Drawing.Point(214, 426);
            this.nudNColori.Name = "nudNColori";
            this.nudNColori.Size = new System.Drawing.Size(51, 26);
            this.nudNColori.TabIndex = 4;
            this.nudNColori.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 527);
            this.Controls.Add(this.nudNColori);
            this.Controls.Add(this.lblNColori);
            this.Controls.Add(this.mtbDim);
            this.Controls.Add(this.lblDimQuadro);
            this.Controls.Add(this.pnlQuadro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Finestra principale";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudNColori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuadro;
        private System.Windows.Forms.Label lblDimQuadro;
        private System.Windows.Forms.MaskedTextBox mtbDim;
        private System.Windows.Forms.Label lblNColori;
        private System.Windows.Forms.NumericUpDown nudNColori;
    }
}

