
namespace DemoForms
{
    partial class FrmColori
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
            this.flpColori = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpColori
            // 
            this.flpColori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpColori.Location = new System.Drawing.Point(0, 0);
            this.flpColori.Name = "flpColori";
            this.flpColori.Size = new System.Drawing.Size(500, 500);
            this.flpColori.TabIndex = 0;
            // 
            // FrmColori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.flpColori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmColori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Colori";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpColori;
    }
}