using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace DemoMedia
{
    public partial class FrmMain : Form
    {
        // Nota: per incorporare un file nell'eseguibile impostare, in "Esplora soluzioni", "Azioni di compilazione" -> "Risorsa incorporata" per il file interessato

        string[] nomiImg = { "connecting_0", "connecting_1", "connecting_2", "connecting_3" };

        public FrmMain()
        {
            InitializeComponent();
            cbxSceltaImmagine.Items.Clear();
            cbxSceltaImmagine.Items.AddRange(nomiImg);

            CaricaFont();
        }

        /// <summary>
        /// restituisce una stringa che contiene i nomi di tutti i controlli (anche quelli annidati) contenuti nel contenitore
        /// </summary>
        /// <param name="contenitore">controllo da esaminare</param>
        /// <returns>elenco (uno per riga) di tutti i controlli contenuti</returns>
        private string EsaminaContenitore(Control contenitore)
        {
            string  s = "";
            for (int i = 0; i < contenitore.Controls.Count; i++)
            {
                s += contenitore.Controls[i].Name + "\n";

                if (contenitore.Controls[i].Controls.Count > 0)
                    s += EsaminaContenitore(contenitore.Controls[i]);
            }
            return s;
        }

        private void CaricaFont()
        {   
            // estrae la risorsa "font" e la salva su file 
            File.WriteAllBytes("temp.ttf", Properties.Resources.Computerfont);

            // aggiunge il font caricandolo dal file 
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("temp.ttf");

            Font font = new Font(pfc.Families[0], 16);

            // imposta il font per tutte le label

            for(int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Tag != null && this.Controls[i].Tag.ToString() == "speciale")
                    (this.Controls[i] as Label).Font = font;
            }
            MessageBox.Show(EsaminaContenitore(this));
        }

        private void btnCaricaImmagine_Click(object sender, EventArgs e)
        {
            // se l'immagine è stata aggiunta alle risorse del progetto (dal menu Progetto -> Proprietà di ...) si può caricare nel seguente modo
            pictureBox1.Image = Properties.Resources.away;

            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            // se è stata copiata nella cartella dell'exe può essere caricata con il metodo Load
            // Nota: aggiunto il file al progetto in "Esplora soluzioni" impostare la proprietà Copia nella directory per il file immagine
            string nomeImg = "asleep.png";
            pictureBox1.Load(nomeImg);
        }

        private void cbxSceltaImmagine_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ottiene il nome dell'immagine selezionata
            string nomeRisorsa = cbxSceltaImmagine.SelectedItem.ToString();

            // ottiene un riferimento alla risorsa attraverso il nome selezionato
            Bitmap pict = (Bitmap)Properties.Resources.ResourceManager.GetObject(nomeRisorsa);

            // imposta l'immagine del PictureBox
            pictureBox1.Image = pict;
        }

        // ---------------------------------

        /*
         * Nota: per riprodurre file wav si può usare la classe System.Media.SoundPlayer. 
         * 
         * Invece per riprodurre file mp3 ci possiamo appoggiare al WindowsMediaPlayer: va aggiunto un riferimento alla DSLL wmp.dll (presente in C:\windows\system32) da "Esplora soluzioni" -> "Riferimenti" -> "Aggiungi riferimento", Sfoglia e individuare la dll (oppure scegliere "COM" e quindi "Windows Media Player")
         *
         * Per ulteriori informazioni vedere "Embedding the Windows Media Player Control in a C# Solution",  
         * https://docs.microsoft.com/en-us/windows/win32/wmp/embedding-the-windows-media-player-control-in-a-c--solution
         */

        private void btnPlayWav_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = Properties.Resources.boing;
            player.PlaySync();
        }

        private void btnPlayMP3_Click(object sender, EventArgs e)
        {
            // Windows Media Player sembra non accettare direttamente uno stream (come SoundPlayer) ma è necessario impostare il percorso del file, salvo quindi la risorsa audio in un file temporaneo e riproduco quello
            
            File.WriteAllBytes("temp.mp3", Properties.Resources.GameBackground);

            WindowsMediaPlayer player = new WindowsMediaPlayer();            
            player.URL = "temp.mp3";
            player.settings.setMode("loop", true);
            player.controls.play();  // oppure player.settings.autoStart = true;            
        }
    }
}
