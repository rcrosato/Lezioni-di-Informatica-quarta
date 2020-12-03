
namespace Sportello
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
            this.gbxDatiDipendente = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.pnlDatiStipendio = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStipendio = new System.Windows.Forms.Label();
            this.nudStipendio = new System.Windows.Forms.NumericUpDown();
            this.btnImpostaStipendio = new System.Windows.Forms.Button();
            this.lblStipendioDip = new System.Windows.Forms.Label();
            this.gbxDatiDipendente.SuspendLayout();
            this.pnlDatiStipendio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStipendio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatiDipendente
            // 
            this.gbxDatiDipendente.Controls.Add(this.pnlDatiStipendio);
            this.gbxDatiDipendente.Controls.Add(this.btnCrea);
            this.gbxDatiDipendente.Controls.Add(this.txtNome);
            this.gbxDatiDipendente.Controls.Add(this.lblNome);
            this.gbxDatiDipendente.Controls.Add(this.txtCognome);
            this.gbxDatiDipendente.Controls.Add(this.lblCognome);
            this.gbxDatiDipendente.Location = new System.Drawing.Point(13, 25);
            this.gbxDatiDipendente.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDatiDipendente.Name = "gbxDatiDipendente";
            this.gbxDatiDipendente.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDatiDipendente.Size = new System.Drawing.Size(391, 324);
            this.gbxDatiDipendente.TabIndex = 0;
            this.gbxDatiDipendente.TabStop = false;
            this.gbxDatiDipendente.Text = "Dati dipendente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.AccessibleDescription = "";
            this.txtCognome.Location = new System.Drawing.Point(92, 33);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(285, 22);
            this.txtCognome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(19, 36);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(67, 16);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "Cognome";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(711, 25);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(152, 67);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(22, 98);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(355, 31);
            this.btnCrea.TabIndex = 4;
            this.btnCrea.Text = "Crea dipendente";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // pnlDatiStipendio
            // 
            this.pnlDatiStipendio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlDatiStipendio.Controls.Add(this.lblStipendioDip);
            this.pnlDatiStipendio.Controls.Add(this.btnImpostaStipendio);
            this.pnlDatiStipendio.Controls.Add(this.nudStipendio);
            this.pnlDatiStipendio.Controls.Add(this.lblStipendio);
            this.pnlDatiStipendio.Controls.Add(this.lblInfo);
            this.pnlDatiStipendio.Location = new System.Drawing.Point(22, 151);
            this.pnlDatiStipendio.Name = "pnlDatiStipendio";
            this.pnlDatiStipendio.Size = new System.Drawing.Size(355, 156);
            this.pnlDatiStipendio.TabIndex = 5;
            this.pnlDatiStipendio.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(19, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(23, 16);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "---";
            // 
            // lblStipendio
            // 
            this.lblStipendio.AutoSize = true;
            this.lblStipendio.Location = new System.Drawing.Point(21, 58);
            this.lblStipendio.Name = "lblStipendio";
            this.lblStipendio.Size = new System.Drawing.Size(65, 16);
            this.lblStipendio.TabIndex = 1;
            this.lblStipendio.Text = "Stipendio";
            // 
            // nudStipendio
            // 
            this.nudStipendio.Location = new System.Drawing.Point(106, 56);
            this.nudStipendio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStipendio.Name = "nudStipendio";
            this.nudStipendio.Size = new System.Drawing.Size(120, 22);
            this.nudStipendio.TabIndex = 2;
            // 
            // btnImpostaStipendio
            // 
            this.btnImpostaStipendio.Location = new System.Drawing.Point(22, 84);
            this.btnImpostaStipendio.Name = "btnImpostaStipendio";
            this.btnImpostaStipendio.Size = new System.Drawing.Size(202, 30);
            this.btnImpostaStipendio.TabIndex = 3;
            this.btnImpostaStipendio.Text = "Imposta stipendio";
            this.btnImpostaStipendio.UseVisualStyleBackColor = true;
            this.btnImpostaStipendio.Click += new System.EventHandler(this.btnImpostaStipendio_Click);
            // 
            // lblStipendioDip
            // 
            this.lblStipendioDip.AutoSize = true;
            this.lblStipendioDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStipendioDip.Location = new System.Drawing.Point(19, 127);
            this.lblStipendioDip.Name = "lblStipendioDip";
            this.lblStipendioDip.Size = new System.Drawing.Size(23, 16);
            this.lblStipendioDip.TabIndex = 4;
            this.lblStipendioDip.Text = "---";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 554);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.gbxDatiDipendente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Gestione impiegati ACME SpA";
            this.gbxDatiDipendente.ResumeLayout(false);
            this.gbxDatiDipendente.PerformLayout();
            this.pnlDatiStipendio.ResumeLayout(false);
            this.pnlDatiStipendio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStipendio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatiDipendente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Panel pnlDatiStipendio;
        private System.Windows.Forms.Button btnImpostaStipendio;
        private System.Windows.Forms.NumericUpDown nudStipendio;
        private System.Windows.Forms.Label lblStipendio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStipendioDip;
    }
}

