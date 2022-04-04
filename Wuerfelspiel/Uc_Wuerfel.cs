using System.Drawing;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class Uc_Wuerfel : UserControl
    {
        int wert = 0;
        
        public Uc_Wuerfel()
        {
            InitializeComponent();
        }

        public int Wert
        {
            set
            {
                this.wert = value;
            }
        }

        private void Uc_Wuerfel_Paint(object sender, PaintEventArgs e)
        {
            //Hilfsvariablen
            Graphics g = e.Graphics;
            int h = this.Size.Height;
            int w = this.Size.Width;

            Brush b = new SolidBrush(Color.Black);            

            // Wird später genutzt, um Zahlen > 9 darzustellen.
            Rectangle text = new Rectangle(0,0,w,h);

            // Hier wird ein "Würfel" in mehrere Quadrate eingeteilt, um dort
            // Punkte darzustellen. Je nach this.wert werden andere Quadrate ausgefüllt.
            // 
            //   j -->
            //  i   +---+---+---+
            //  |   | 0 | 1 | 2 |
            //  V   +---+---+---+
            //      | 3 | 4 | 5 |
            //      +---+---+---+
            //      | 6 | 7 | 8 |
            //      +---+---+---+
            Rectangle[] rects = new Rectangle[9];
            
            int anteilW = w/3;
            int anteilH = h/3;

            int zaehler = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rects[zaehler] = new Rectangle(j*anteilW, i*anteilH, anteilW, anteilH);
                    zaehler++;
                }
            }
            

            switch (wert)
            {
                case 1:
                    g.FillEllipse(b, rects[4]);
                    break;
                case 2:
                    g.FillEllipse(b, rects[2]);
                    g.FillEllipse(b, rects[6]);
                    break;
                case 3:
                    g.FillEllipse(b, rects[0]);
                    g.FillEllipse(b, rects[4]);
                    g.FillEllipse(b, rects[8]);
                    break;
                case 4:
                    g.FillEllipse(b, rects[0]);
                    g.FillEllipse(b, rects[2]);
                    g.FillEllipse(b, rects[6]);
                    g.FillEllipse(b, rects[8]);
                    break;
                case 5:
                    g.FillEllipse(b, rects[0]);
                    g.FillEllipse(b, rects[2]);
                    g.FillEllipse(b, rects[4]);
                    g.FillEllipse(b, rects[6]);
                    g.FillEllipse(b, rects[8]);
                    break; 
                case 6:
                    g.FillEllipse(b, rects[0]);
                    g.FillEllipse(b, rects[3]);
                    g.FillEllipse(b, rects[6]);
                    g.FillEllipse(b, rects[2]);
                    g.FillEllipse(b, rects[5]);
                    g.FillEllipse(b, rects[8]);
                    break;
                default:
                    for (int i = 0; i < rects.Length; i++)
                    {
                        g.FillEllipse(b, rects[i]);
                    }
                    break;
            }


        }
    }
}
