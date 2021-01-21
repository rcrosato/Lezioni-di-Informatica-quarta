using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DemoGrafica2D
{
    public partial class FrmMain : Form
    {
        // un oggetto di tipo Graphics rappresenta un'area di disegno (canvas) dove poter utilizzare le API di Windows per la grafica 2D GDI+
        Graphics myCanvas;


        private void CreaContenitoreGrafico()
        {
            // crea la superficie di disegno
            myCanvas = pnlDisegno.CreateGraphics();

            // per evitare la scalettatura
            myCanvas.SmoothingMode = SmoothingMode.AntiAlias;

            // forza il ridisegno del pannello
            pnlDisegno.Invalidate();
        }


        public FrmMain()
        {
            InitializeComponent();
            CreaContenitoreGrafico();
            cmbComando.SelectedIndex = 0;
        }

        private void btnDisegna_Click(object sender, EventArgs e)
        {
            // definisce una penna da usare per disegnare
            Pen penna = new Pen(Color.Green, 5);

            // in base alla scelta dell'utente utilizziamo varie primitive grafiche
            switch (cmbComando.SelectedIndex)
            {
                case 0: // disegno di una linea
                    Point p1, p2;
                    p1 = new Point(0, 0);
                    p2 = new Point(pnlDisegno.Width, pnlDisegno.Height);

                    myCanvas.DrawLine(penna, p1, p2);
                    break;

                case 1: // disegno di un rettangolo
                    penna.Color = Color.Blue;
                    // specifico il vertice in alto a sinistra, larghezza e l'altezza
                    myCanvas.DrawRectangle(penna, 10, 10, 300, 200);
                    break;

                case 2: // disegno di un'ellisse
                    penna.Color = Color.Red;
                    // specifico il vertice in alto a sinistra, larghezza e l'altezza
                    myCanvas.DrawEllipse(penna, 10, 10, 300, 200);
                    break;

                case 3: // disegno di un arco
                    penna.Color = Color.Yellow;
                    // rettangolo che contiene l'arco, angolo iniziale, ampiezza 
                    myCanvas.DrawArc(penna, 10, 10, 300, 300, 0, 270);
                    break;

                case 4: // disegno di un poligono
                    Point[] punti =
                    {
                        new Point(100, 300), new Point(200, 400),
                        new Point(150, 250), new Point(100, 300)
                    };

                    myCanvas.DrawPolygon(penna, punti);
                    break;

                case 5: // curca di Bezier
                    Point[] punti1 =
                    {
                        new Point(100, 100), new Point(400, 300),
                        new Point(700, 500), new Point(500, 200)
                    };
                    myCanvas.DrawBezier(penna, punti1[0], punti1[1], punti1[2], punti1[3]);
                    break;

                case 6: // riempimento di figure
                    SolidBrush pennello = new SolidBrush(Color.Red);
                    myCanvas.FillRectangle(pennello, 250, 250, 200, 200);

                    LinearGradientBrush pennelloGradiente = new LinearGradientBrush(new Point(0, 0), new Point(400, 400), Color.Blue, Color.Red);
                    myCanvas.FillEllipse(pennelloGradiente, 10, 10, 400, 300);
                    break;

                case 7: // testo
                    Font carattere = new Font("Verdana", 30);
                    myCanvas.DrawString("Ciao a tutti", carattere, new SolidBrush(Color.Green), 100, 100);
                    break;
            }
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            CreaContenitoreGrafico();
        }

        private void FrmMain_ResizeBegin(object sender, EventArgs e)
        {
            MessageBox.Show("Dovresti ripulire il pannello per ricreare il canvas con le nuove dimensioni");
        }

        Point p0; // punto iniziale per il disegno con il mouse

        private void pnlDisegno_MouseDown(object sender, MouseEventArgs e)
        {
            p0 = e.Location;
        }

        private void pnlDisegno_MouseMove(object sender, MouseEventArgs e)
        {
            lblStato.Text = $"X: {e.X,6}  Y: {e.Y,6}";

            if (e.Button == MouseButtons.Left)
            {
                Pen penna = new Pen(Color.Blue, 2);
                myCanvas.DrawLine(penna, p0, e.Location);
            }
            p0 = e.Location;
        }
    }
}
