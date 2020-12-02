namespace DemoControlli
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
            this.components = new System.ComponentModel.Container();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lklContatti = new System.Windows.Forms.LinkLabel();
            this.tmrStatusBarClock = new System.Windows.Forms.Timer(this.components);
            this.gbxControlliComuni = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxFrazioni = new System.Windows.Forms.ListBox();
            this.lblPaeseResidenza = new System.Windows.Forms.Label();
            this.cmbPaeseResidenza = new System.Windows.Forms.ComboBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbxStatoCivile = new System.Windows.Forms.GroupBox();
            this.rdbCelibe = new System.Windows.Forms.RadioButton();
            this.rdbConiugato = new System.Windows.Forms.RadioButton();
            this.gbxSesso = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbAltro = new System.Windows.Forms.RadioButton();
            this.cbxAccetta = new System.Windows.Forms.CheckBox();
            this.pnlPulsanti = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatusBar.SuspendLayout();
            this.gbxControlliComuni.SuspendLayout();
            this.gbxStatoCivile.SuspendLayout();
            this.gbxSesso.SuspendLayout();
            this.pnlPulsanti.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlStatusBar.Controls.Add(this.lblTime);
            this.pnlStatusBar.Controls.Add(this.lklContatti);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 590);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(816, 42);
            this.pnlStatusBar.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(724, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 16);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00:0";
            // 
            // lklContatti
            // 
            this.lklContatti.AutoSize = true;
            this.lklContatti.Location = new System.Drawing.Point(12, 17);
            this.lklContatti.Name = "lklContatti";
            this.lklContatti.Size = new System.Drawing.Size(267, 16);
            this.lklContatti.TabIndex = 0;
            this.lklContatti.TabStop = true;
            this.lklContatti.Text = "Visita il nostro sito per maggiori informazioni";
            this.lklContatti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklContatti_LinkClicked);
            // 
            // tmrStatusBarClock
            // 
            this.tmrStatusBarClock.Enabled = true;
            this.tmrStatusBarClock.Tick += new System.EventHandler(this.tmrStatusBarClock_Tick);
            // 
            // gbxControlliComuni
            // 
            this.gbxControlliComuni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxControlliComuni.Controls.Add(this.label1);
            this.gbxControlliComuni.Controls.Add(this.lbxFrazioni);
            this.gbxControlliComuni.Controls.Add(this.lblPaeseResidenza);
            this.gbxControlliComuni.Controls.Add(this.cmbPaeseResidenza);
            this.gbxControlliComuni.Controls.Add(this.txtCognome);
            this.gbxControlliComuni.Controls.Add(this.lblCognome);
            this.gbxControlliComuni.Controls.Add(this.txtNome);
            this.gbxControlliComuni.Controls.Add(this.lblNome);
            this.gbxControlliComuni.Controls.Add(this.gbxStatoCivile);
            this.gbxControlliComuni.Controls.Add(this.gbxSesso);
            this.gbxControlliComuni.Controls.Add(this.cbxAccetta);
            this.gbxControlliComuni.Location = new System.Drawing.Point(12, 12);
            this.gbxControlliComuni.Name = "gbxControlliComuni";
            this.gbxControlliComuni.Size = new System.Drawing.Size(375, 572);
            this.gbxControlliComuni.TabIndex = 0;
            this.gbxControlliComuni.TabStop = false;
            this.gbxControlliComuni.Text = "Controlli comuni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Frazione";
            // 
            // lbxFrazioni
            // 
            this.lbxFrazioni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFrazioni.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbxFrazioni.FormattingEnabled = true;
            this.lbxFrazioni.ItemHeight = 16;
            this.lbxFrazioni.Location = new System.Drawing.Point(17, 383);
            this.lbxFrazioni.Name = "lbxFrazioni";
            this.lbxFrazioni.Size = new System.Drawing.Size(339, 180);
            this.lbxFrazioni.TabIndex = 10;
            // 
            // lblPaeseResidenza
            // 
            this.lblPaeseResidenza.AutoSize = true;
            this.lblPaeseResidenza.Location = new System.Drawing.Point(14, 296);
            this.lblPaeseResidenza.Name = "lblPaeseResidenza";
            this.lblPaeseResidenza.Size = new System.Drawing.Size(124, 16);
            this.lblPaeseResidenza.TabIndex = 7;
            this.lblPaeseResidenza.Text = "&Paese di residenza";
            // 
            // cmbPaeseResidenza
            // 
            this.cmbPaeseResidenza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaeseResidenza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaeseResidenza.FormattingEnabled = true;
            this.cmbPaeseResidenza.Location = new System.Drawing.Point(17, 315);
            this.cmbPaeseResidenza.Name = "cmbPaeseResidenza";
            this.cmbPaeseResidenza.Size = new System.Drawing.Size(339, 24);
            this.cmbPaeseResidenza.TabIndex = 8;
            this.cmbPaeseResidenza.SelectedIndexChanged += new System.EventHandler(this.cmbPaeseResidenza_SelectedIndexChanged);
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCognome.Location = new System.Drawing.Point(91, 40);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(265, 22);
            this.txtCognome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(14, 43);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(67, 16);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "&Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(91, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 73);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "&Nome";
            // 
            // gbxStatoCivile
            // 
            this.gbxStatoCivile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStatoCivile.Controls.Add(this.rdbCelibe);
            this.gbxStatoCivile.Controls.Add(this.rdbConiugato);
            this.gbxStatoCivile.Location = new System.Drawing.Point(17, 172);
            this.gbxStatoCivile.Name = "gbxStatoCivile";
            this.gbxStatoCivile.Size = new System.Drawing.Size(339, 69);
            this.gbxStatoCivile.TabIndex = 5;
            this.gbxStatoCivile.TabStop = false;
            this.gbxStatoCivile.Text = "S&tato civile";
            // 
            // rdbCelibe
            // 
            this.rdbCelibe.AutoSize = true;
            this.rdbCelibe.Checked = true;
            this.rdbCelibe.Location = new System.Drawing.Point(16, 32);
            this.rdbCelibe.Name = "rdbCelibe";
            this.rdbCelibe.Size = new System.Drawing.Size(105, 20);
            this.rdbCelibe.TabIndex = 4;
            this.rdbCelibe.TabStop = true;
            this.rdbCelibe.Text = "Celibe/nubile";
            this.rdbCelibe.UseVisualStyleBackColor = true;
            // 
            // rdbConiugato
            // 
            this.rdbConiugato.AutoSize = true;
            this.rdbConiugato.Location = new System.Drawing.Point(136, 32);
            this.rdbConiugato.Name = "rdbConiugato";
            this.rdbConiugato.Size = new System.Drawing.Size(99, 20);
            this.rdbConiugato.TabIndex = 5;
            this.rdbConiugato.Text = "Coniugato/a";
            this.rdbConiugato.UseVisualStyleBackColor = true;
            // 
            // gbxSesso
            // 
            this.gbxSesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSesso.Controls.Add(this.rdbM);
            this.gbxSesso.Controls.Add(this.rdbF);
            this.gbxSesso.Controls.Add(this.rdbAltro);
            this.gbxSesso.Location = new System.Drawing.Point(17, 98);
            this.gbxSesso.Name = "gbxSesso";
            this.gbxSesso.Size = new System.Drawing.Size(339, 68);
            this.gbxSesso.TabIndex = 4;
            this.gbxSesso.TabStop = false;
            this.gbxSesso.Text = "&Sesso";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(16, 33);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(37, 20);
            this.rdbM.TabIndex = 1;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(59, 33);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(34, 20);
            this.rdbF.TabIndex = 2;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbAltro
            // 
            this.rdbAltro.AutoSize = true;
            this.rdbAltro.Location = new System.Drawing.Point(99, 33);
            this.rdbAltro.Name = "rdbAltro";
            this.rdbAltro.Size = new System.Drawing.Size(53, 20);
            this.rdbAltro.TabIndex = 3;
            this.rdbAltro.Text = "Altro";
            this.rdbAltro.UseVisualStyleBackColor = true;
            // 
            // cbxAccetta
            // 
            this.cbxAccetta.AutoSize = true;
            this.cbxAccetta.Location = new System.Drawing.Point(17, 257);
            this.cbxAccetta.Name = "cbxAccetta";
            this.cbxAccetta.Size = new System.Drawing.Size(205, 20);
            this.cbxAccetta.TabIndex = 6;
            this.cbxAccetta.Text = "&Accetto le condizioni di utilizzo";
            this.cbxAccetta.UseVisualStyleBackColor = true;
            // 
            // pnlPulsanti
            // 
            this.pnlPulsanti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPulsanti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPulsanti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPulsanti.Controls.Add(this.flowLayoutPanel1);
            this.pnlPulsanti.Location = new System.Drawing.Point(398, 12);
            this.pnlPulsanti.Name = "pnlPulsanti";
            this.pnlPulsanti.Size = new System.Drawing.Size(412, 571);
            this.pnlPulsanti.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 632);
            this.Controls.Add(this.pnlPulsanti);
            this.Controls.Add(this.gbxControlliComuni);
            this.Controls.Add(this.pnlStatusBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimostrazione utilizzo controlli comuni";
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.gbxControlliComuni.ResumeLayout(false);
            this.gbxControlliComuni.PerformLayout();
            this.gbxStatoCivile.ResumeLayout(false);
            this.gbxStatoCivile.PerformLayout();
            this.gbxSesso.ResumeLayout(false);
            this.gbxSesso.PerformLayout();
            this.pnlPulsanti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.LinkLabel lklContatti;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrStatusBarClock;
        private System.Windows.Forms.GroupBox gbxControlliComuni;
        private System.Windows.Forms.Panel pnlPulsanti;
        private System.Windows.Forms.CheckBox cbxAccetta;
        private System.Windows.Forms.RadioButton rdbAltro;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbConiugato;
        private System.Windows.Forms.RadioButton rdbCelibe;
        private System.Windows.Forms.GroupBox gbxStatoCivile;
        private System.Windows.Forms.GroupBox gbxSesso;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPaeseResidenza;
        private System.Windows.Forms.ComboBox cmbPaeseResidenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxFrazioni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

