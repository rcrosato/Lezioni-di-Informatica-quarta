
namespace DemoGrafica2D
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStato = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDisegno = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComando = new System.Windows.Forms.ComboBox();
            this.btnDisegna = new System.Windows.Forms.Button();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStato});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStato
            // 
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlDisegno
            // 
            this.pnlDisegno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisegno.BackColor = System.Drawing.Color.White;
            this.pnlDisegno.Location = new System.Drawing.Point(201, 45);
            this.pnlDisegno.Name = "pnlDisegno";
            this.pnlDisegno.Size = new System.Drawing.Size(671, 481);
            this.pnlDisegno.TabIndex = 1;
            this.pnlDisegno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDisegno_MouseDown);
            this.pnlDisegno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDisegno_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comando di disegno";
            // 
            // cmbComando
            // 
            this.cmbComando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComando.FormattingEnabled = true;
            this.cmbComando.Items.AddRange(new object[] {
            "Linea",
            "Rettangolo",
            "Ellisse",
            "Arco",
            "Poligono",
            "Curva di Bezier",
            "Figure piane",
            "Testo"});
            this.cmbComando.Location = new System.Drawing.Point(15, 45);
            this.cmbComando.Name = "cmbComando";
            this.cmbComando.Size = new System.Drawing.Size(165, 26);
            this.cmbComando.TabIndex = 3;
            // 
            // btnDisegna
            // 
            this.btnDisegna.Location = new System.Drawing.Point(15, 91);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(165, 43);
            this.btnDisegna.TabIndex = 4;
            this.btnDisegna.Text = "Disegna";
            this.btnDisegna.UseVisualStyleBackColor = true;
            this.btnDisegna.Click += new System.EventHandler(this.btnDisegna_Click);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(15, 140);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(165, 43);
            this.btnPulisci.TabIndex = 5;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.btnDisegna);
            this.Controls.Add(this.cmbComando);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDisegno);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo grafica 2D con GDI+";
            this.ResizeBegin += new System.EventHandler(this.FrmMain_ResizeBegin);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStato;
        private System.Windows.Forms.Panel pnlDisegno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComando;
        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.Button btnPulisci;
    }
}

