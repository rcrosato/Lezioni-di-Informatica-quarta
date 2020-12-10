using System;
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
    }
}
