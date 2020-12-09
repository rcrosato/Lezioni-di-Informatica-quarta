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
            Application.DoEvents();
            Thread.Sleep(2000);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            splash.Close();
        }
    }
}
