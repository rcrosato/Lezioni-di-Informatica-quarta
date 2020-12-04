using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DemoControlli
{
    public partial class FrmMain : Form
    {
        List<string> listaComuni;
        List<string>[] listeFrazioni;

        private void InizializzaDati()
        {
            // crea e riempie una lista con i nomi dei comuni
            listaComuni = new List<string>();
            listaComuni.Add("Valdagno");
            listaComuni.Add("Cornedo Vicentino");
            listaComuni.Add("Castelgomberto");

            listeFrazioni = new List<string>[listaComuni.Count];
            listeFrazioni[0] = new List<string>() { "Piana", "Centro", "Massignani", "Novale", "Castelvecchio", "Ponte dei Nori" };
            listeFrazioni[1] = new List<string>() { "Cereda", "Spagnago", "Muzzolon" };
            listeFrazioni[2] = new List<string>() { "Valle", "Monte Schiavi" };
        }

        public FrmMain()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss:F");

            InizializzaDati();

            // utilizza la lista per aggiungere i dati al ComboBox
            cmbPaeseResidenza.Items.AddRange(listaComuni.ToArray());
        }

        private void tmrStatusBarClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss.ff");
        }

        private void lklContatti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("https://www.iisvaldagno.it");
            p.Start();
        }

        private void cmbPaeseResidenza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // innescato quando cambia la selezione 

            // pulisco la lista delle frazioni
            lbxFrazioni.Items.Clear();

            // indicePaese è l'indice del comune selezionato
            int indicePaese = cmbPaeseResidenza.SelectedIndex;

            // ciclo su tutte le frazioni del comune selezionato
            for(int i = 0; i < listeFrazioni[indicePaese].Count; i++)
            {
                lbxFrazioni.Items.Add(listeFrazioni[indicePaese][i]);
            }

            // il ciclo precedente può essere sostituito dalla seguente istruzione:
            // lbxFrazioni.Items.AddRange(listeFrazioni[cmbPaeseResidenza.SelectedIndex].ToArray());
        }

        private void btnCreaPulsanti_Click(object sender, EventArgs e)
        {
            // Creare una serie di "nudNPulsanti" pulsanti  quadrati, di colori diversi (casuali) in modo tale da riempire al massimo il FlowLayoutPanel flpPulsanti

            // numero di pulsanti indicato dall'utente
            int n = Convert.ToInt32(nudNPulsanti.Value);

            pgbAvanzamento.Value = 0;
            pgbAvanzamento.Minimum = 0;                 
            pgbAvanzamento.Maximum = n - 1;
            pgbAvanzamento.Step = 1;

            flpPulsanti.Controls.Clear();

            // calcolo il numero di pulsanti per riga
            int nBtn = Convert.ToInt32(Math.Ceiling(Math.Sqrt(n)));

            // calcolo il lato del singolo pulsante
            int wBtn = Convert.ToInt32(flpPulsanti.Width / nBtn);

            Random g = new Random();

            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();

                // impostare btn in modo tale che sia quadrato, di colore casuale, con testo l'indice del ciclo +1; le dimenzioni del singolo pulsante devono essere tali che il numero totale di pulsanti riempia al massimo il flp

                // imposto le dimensioni del pulsante (quadrato)
                btn.Width = btn.Height = wBtn;

                // imposto testo e dimensioni del font
                btn.Text = (i+1).ToString();
                btn.Font = new Font("Tahoma", wBtn / 4);
                
                // rendo piatto e senza bordi il pulsante
                btn.Margin = new Padding(0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // impostiamo i colori del pulsante
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(g.Next(0, 256), g.Next(0, 256), g.Next(0, 256));


                // aggiungiamo un gestore dell'evento Click ai pulsanti
                btn.Click += Btn_Click;

                // inserisce il pulsante nel FlowLayoutPanel
                flpPulsanti.Controls.Add(btn);

                pgbAvanzamento.PerformStep(); // avanza la progress bar di uno step
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b;
            b = (Button)sender;  // cast del sender (mittente dell'evento) a Button (perchè sappiamo con certezza che il sender sarà un Button)
            MessageBox.Show("Hai premuto " + b.Text);            
        }
    }
}
