using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DemoForms
{
    public partial class FrmMain : Form
    {
        FrmSplash splash;


        public FrmMain()
        {
            InitializeComponent();

            splash = new FrmSplash();
            splash.Show();            
            
            for(int i = splash.pgbCaricamento.Minimum; i <= splash.pgbCaricamento.Maximum; i++)
            {
                splash.pgbCaricamento.PerformStep();
                Thread.Sleep(500);
                Application.DoEvents();
            }            
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            splash.Close();
        }

        private void mtbDim_TextChanged(object sender, EventArgs e)
        {
            pnlQuadro.Width = pnlQuadro.Height = Convert.ToInt32(mtbDim.Text);
        }


        FrmColori finestraColori = null;

        private void btnApriFinestraColori_Click(object sender, EventArgs e)
        {
            if (finestraColori == null || finestraColori.IsDisposed)
            {
                finestraColori = new FrmColori(this);
                finestraColori.GeneraPulsanti(Convert.ToInt32(nudNColori.Value));
            }

            finestraColori.Show();
        }

        private void nudNColori_ValueChanged(object sender, EventArgs e)
        {
            if (finestraColori != null && !finestraColori.IsDisposed)finestraColori.GeneraPulsanti(Convert.ToInt32(nudNColori.Value));
        }


        public void ImpostaColore(Color colore)
        {
            pnlQuadro.BackColor = colore;
        }

        private void FrmMain_Move(object sender, EventArgs e)
        {
            if (finestraColori != null && !finestraColori.IsDisposed)
                finestraColori.PosizionaFinestra();
        }
    }
}
