
namespace LezioniOOP
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.lblModello = new System.Windows.Forms.Label();
            this.btnCrea = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAutoCreate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnInfo = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(37, 25);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 18);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(108, 22);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(240, 24);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(108, 52);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(240, 24);
            this.txtModello.TabIndex = 3;
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(37, 55);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(61, 18);
            this.lblModello.TabIndex = 2;
            this.lblModello.Text = "Modello";
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(354, 22);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(106, 54);
            this.btnCrea.TabIndex = 4;
            this.btnCrea.Text = "Crea l\'auto";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAutoCreate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAutoCreate
            // 
            this.lblAutoCreate.Name = "lblAutoCreate";
            this.lblAutoCreate.Size = new System.Drawing.Size(22, 17);
            this.lblAutoCreate.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(466, 22);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(106, 54);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Informazioni";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 467);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.lblModello);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test classi";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label lblModello;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAutoCreate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnInfo;
    }
}

