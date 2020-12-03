using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportello
{
    public partial class FrmMain : Form
    {
        Dipendente d;
        List<Dipendente> dipendenti;

        public FrmMain()
        {
            InitializeComponent();

            dipendenti = new List<Dipendente>();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // ottengo il numero di controlli contenuti nella form e ciclo su di essi
            int n = this.Controls.Count;
            MessageBox.Show("n = " + n);
            for(int i = 0; i < n; i++)
            {
                MessageBox.Show(this.Controls[i].Name);
            }


            // ottengo il numero di controlli contenuti in gbxDatiDipendente e ciclo su di essi
            n = gbxDatiDipendente.Controls.Count;
            MessageBox.Show("n = " + n);
            for (int i = 0; i < n; i++)
            {
                MessageBox.Show(gbxDatiDipendente.Controls[i].Name);
            }            
        }

        

        private void btnCrea_Click(object sender, EventArgs e)
        {
            try
            {
                d = new Dipendente(txtCognome.Text, txtNome.Text);
                pnlDatiStipendio.Visible = true;
                lblInfo.Text = "Dipendente " + d.Cognome + " " + d.Nome;

                dipendenti.Add(d);
            }
            catch (Exception errore)
            {
                MessageBox.Show("Attenzione: " + errore.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImpostaStipendio_Click(object sender, EventArgs e)
        {
            try
            {
                d.Stipendio = nudStipendio.Value;
            }
            catch (Exception errore)
            {
                MessageBox.Show("Attenzione: " + errore.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            lblStipendioDip.Text = "Stipendio impostato a " + d.Stipendio + " Euro";
        }
    }
}
