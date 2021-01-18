
namespace DemoMedia
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
            this.btnPlayWav = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxSceltaImmagine = new System.Windows.Forms.ComboBox();
            this.btnCaricaImmagine = new System.Windows.Forms.Button();
            this.btnPlayMP3 = new System.Windows.Forms.Button();
            this.lblImmagine = new System.Windows.Forms.Label();
            this.lblTestFont = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayWav
            // 
            this.btnPlayWav.Location = new System.Drawing.Point(274, 12);
            this.btnPlayWav.Name = "btnPlayWav";
            this.btnPlayWav.Size = new System.Drawing.Size(176, 71);
            this.btnPlayWav.TabIndex = 0;
            this.btnPlayWav.Text = "Play WAV";
            this.btnPlayWav.UseVisualStyleBackColor = true;
            this.btnPlayWav.Click += new System.EventHandler(this.btnPlayWav_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbxSceltaImmagine
            // 
            this.cbxSceltaImmagine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSceltaImmagine.FormattingEnabled = true;
            this.cbxSceltaImmagine.Location = new System.Drawing.Point(12, 132);
            this.cbxSceltaImmagine.Name = "cbxSceltaImmagine";
            this.cbxSceltaImmagine.Size = new System.Drawing.Size(176, 28);
            this.cbxSceltaImmagine.TabIndex = 2;
            this.cbxSceltaImmagine.SelectedIndexChanged += new System.EventHandler(this.cbxSceltaImmagine_SelectedIndexChanged);
            // 
            // btnCaricaImmagine
            // 
            this.btnCaricaImmagine.Location = new System.Drawing.Point(12, 12);
            this.btnCaricaImmagine.Name = "btnCaricaImmagine";
            this.btnCaricaImmagine.Size = new System.Drawing.Size(176, 71);
            this.btnCaricaImmagine.TabIndex = 4;
            this.btnCaricaImmagine.Text = "Carica Immagine";
            this.btnCaricaImmagine.UseVisualStyleBackColor = true;
            this.btnCaricaImmagine.Click += new System.EventHandler(this.btnCaricaImmagine_Click);
            // 
            // btnPlayMP3
            // 
            this.btnPlayMP3.Location = new System.Drawing.Point(274, 95);
            this.btnPlayMP3.Name = "btnPlayMP3";
            this.btnPlayMP3.Size = new System.Drawing.Size(176, 71);
            this.btnPlayMP3.TabIndex = 5;
            this.btnPlayMP3.Text = "Play MP3";
            this.btnPlayMP3.UseVisualStyleBackColor = true;
            this.btnPlayMP3.Click += new System.EventHandler(this.btnPlayMP3_Click);
            // 
            // lblImmagine
            // 
            this.lblImmagine.AutoSize = true;
            this.lblImmagine.Location = new System.Drawing.Point(12, 109);
            this.lblImmagine.Name = "lblImmagine";
            this.lblImmagine.Size = new System.Drawing.Size(145, 20);
            this.lblImmagine.TabIndex = 6;
            this.lblImmagine.Text = "Scegli un\'immagine";
            // 
            // lblTestFont
            // 
            this.lblTestFont.AutoSize = true;
            this.lblTestFont.Font = new System.Drawing.Font("Freak", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestFont.Location = new System.Drawing.Point(194, 202);
            this.lblTestFont.Name = "lblTestFont";
            this.lblTestFont.Size = new System.Drawing.Size(259, 38);
            this.lblTestFont.TabIndex = 7;
            this.lblTestFont.Text = "Test font caricato";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 387);
            this.Controls.Add(this.lblTestFont);
            this.Controls.Add(this.lblImmagine);
            this.Controls.Add(this.btnPlayMP3);
            this.Controls.Add(this.btnCaricaImmagine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxSceltaImmagine);
            this.Controls.Add(this.btnPlayWav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Demo Multimedia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayWav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxSceltaImmagine;
        private System.Windows.Forms.Button btnCaricaImmagine;
        private System.Windows.Forms.Button btnPlayMP3;
        private System.Windows.Forms.Label lblImmagine;
        private System.Windows.Forms.Label lblTestFont;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

