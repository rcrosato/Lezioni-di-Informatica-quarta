using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recupero
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Valutazione> voti = new List<Valutazione>();

            voti.Add(new Valutazione("Matematica", 6));
            voti.Add(new Valutazione("Italiano", 5));
            voti.Add(new Valutazione("Matematica", 6));
            voti.Add(new Valutazione("matematica ", 7));
            voti.Add(new Valutazione("Storia", 8));
            
            Studente s = new Studente("Paolo", voti);

            MessageBox.Show(s.ToString());

            voti.Clear();
            voti.Add(new Valutazione("Matematica", 6));
            voti.Add(new Valutazione("Italiano", 7));
            voti.Add(new Valutazione("Matematica", 9));            
            voti.Add(new Valutazione("Inglese", 4));

            s.AggiornaVoti(voti);

            MessageBox.Show(s.ToString());
        }
    }
}
