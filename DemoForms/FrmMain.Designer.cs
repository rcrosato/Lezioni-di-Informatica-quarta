
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
            this.btnApriFinestraColori = new System.Windows.Forms.Button();
            this.btnApriDialogo = new System.Windows.Forms.Button();
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
            this.mtbDim.TextChanged += new System.EventHandler(this.mtbDim_TextChanged);
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
            this.nudNColori.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNColori.Name = "nudNColori";
            this.nudNColori.Size = new System.Drawing.Size(51, 26);
            this.nudNColori.TabIndex = 4;
            this.nudNColori.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNColori.ValueChanged += new System.EventHandler(this.nudNColori_ValueChanged);
            // 
            // btnApriFinestraColori
            // 
            this.btnApriFinestraColori.Location = new System.Drawing.Point(36, 465);
            this.btnApriFinestraColori.Name = "btnApriFinestraColori";
            this.btnApriFinestraColori.Size = new System.Drawing.Size(143, 41);
            this.btnApriFinestraColori.TabIndex = 5;
            this.btnApriFinestraColori.Text = "Apri finestra colori";
            this.btnApriFinestraColori.UseVisualStyleBackColor = true;
            this.btnApriFinestraColori.Click += new System.EventHandler(this.btnApriFinestraColori_Click);
            // 
            // btnApriDialogo
            // 
            this.btnApriDialogo.Location = new System.Drawing.Point(195, 465);
            this.btnApriDialogo.Name = "btnApriDialogo";
            this.btnApriDialogo.Size = new System.Drawing.Size(143, 41);
            this.btnApriDialogo.TabIndex = 6;
            this.btnApriDialogo.Text = "Apri dialogo";
            this.btnApriDialogo.UseVisualStyleBackColor = true;
            this.btnApriDialogo.Click += new System.EventHandler(this.btnApriDialogo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 518);
            this.Controls.Add(this.btnApriDialogo);
            this.Controls.Add(this.btnApriFinestraColori);
            this.Controls.Add(this.nudNColori);
            this.Controls.Add(this.lblNColori);
            this.Controls.Add(this.mtbDim);
            this.Controls.Add(this.lblDimQuadro);
            this.Controls.Add(this.pnlQuadro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Finestra principale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.nudNColori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDimQuadro;
        private System.Windows.Forms.MaskedTextBox mtbDim;
        private System.Windows.Forms.Label lblNColori;
        private System.Windows.Forms.NumericUpDown nudNColori;
        private System.Windows.Forms.Button btnApriFinestraColori;
        private System.Windows.Forms.Panel pnlQuadro;
        private System.Windows.Forms.Button btnApriDialogo;
    }
}

