using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForms
{
    public partial class FrmColori : Form
    {
        FrmMain finestraPrincipale = null; // riferimento alla finestra principale

        public FrmColori(FrmMain finestraChiamante)
        {
            InitializeComponent();
            finestraPrincipale = finestraChiamante;

            PosizionaFinestra();

            // in alternativa per ricavare il riferimento alla finestra principale (è la prima che viene creata)
            // finestraPrincipale = (FrmMain)Application.OpenForms[0];
        }
        

        public void PosizionaFinestra()
        {
            if (finestraPrincipale != null)
            {
                this.Left = finestraPrincipale.Width + finestraPrincipale.Left;
                this.Top = finestraPrincipale.Top;
            }
        }


        public void GeneraPulsanti(int numeroPulsanti)
        {
            flpColori.Controls.Clear();

            int nBtn = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numeroPulsanti)));
            int wBtn = Convert.ToInt32(flpColori.Width / nBtn);

            Random g = new Random();

            for (int i = 0; i < numeroPulsanti; i++)
            {
                Button btn = new Button();
                btn.Width = btn.Height = wBtn;

                btn.Text = (i + 1).ToString();
                btn.Font = new Font("Tahoma", wBtn / 4);

                btn.Margin = new Padding(0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(g.Next(0, 256), g.Next(0, 256), g.Next(0, 256));
                
                flpColori.Controls.Add(btn);

                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            finestraPrincipale.ImpostaColore(b.BackColor);
        }
    }
}
