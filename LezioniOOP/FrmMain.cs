using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezioniOOP
{
    public partial class FrmMain : Form
    {
        Auto a = null;

        public FrmMain()
        {
            InitializeComponent();

            lblAutoCreate.Text = Auto.AutoCreate();
            // btnInfo.Enabled = false; // disabilitare il pulsante all'avvio
        }
        
        private void btnCrea_Click(object sender, EventArgs e)
        {            
            a = new Auto(txtMarca.Text, txtModello.Text);
            // btnInfo.Enabled = (a != null); // abilita il pulsante se l'oggetto viene creato
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAutoCreate.Text = Auto.AutoCreate();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // esempio operatore "null condizionale" o "Elvis"
            // MessageBox.Show(a?.Informazioni());

            if (a == null)
                MessageBox.Show("Devi prima creare l'oggetto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show(a.Informazioni(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            string s = a.Marca;
            
            a.Potenza = 120;
            
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (a != null)
                a.AggiungiProprietario(txtProprietario.Text);
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                MessageBox.Show(a[1] + " è il primo proprietario dell'auto");
            }
        }
    }
}
