using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Xmas
{
    public partial class VisorControl : UserControl
    {
        private Jugador miJugador;
        private Jugador otroJugador;
        private Mundo miMundo;

        private Bitmap flipBitmap;
        private Image flipImage;
        private Graphics flipGraphics;

        public Jugador MiJugador
        {
            get
            {
                return miJugador;
            }
            set
            {
                miJugador = value;
            }
        }
        public Jugador OtroJugador
        {
            get
            {
                return otroJugador;
            }
            set
            {
                otroJugador = value;
            }
        }
        public Mundo MiMundo
        {
            get
            {
                return miMundo;
            }
            set
            {
                miMundo = value;
            }
        }
        public String TextoPregunta
        {
            set
            {
                textBoxPregunta.Text = value;
                if (value == "")
                {
                    botonResponder.Enabled = false;
                }
                else
                {
                    botonResponder.Enabled = true;
                }
            }
        }

        public VisorControl()
        {
            InitializeComponent();

            botonResponder.Enabled = false;

            flipBitmap = new Bitmap(440, 400);
            flipImage = Image.FromHbitmap(flipBitmap.GetHbitmap());
            flipGraphics = Graphics.FromImage(flipImage);
        }

        public void Pintar()
        {
            // Obtengo mi posicion
            int px = MiJugador.X;
            int py = MiJugador.Y;


            flipGraphics.Clear(this.BackColor);

            
            

            // Obtengo los bitmaps a mi alrededor
            for (int i = -5; i <= 5; i++)
            {
                int x = px + i;
                for (int j = -5; j <= 5; j++)
                {
                    int y = py + j;

                    try
                    {
                        Brush b = MiMundo.GetPaintColor(MiJugador, x, y);

                        flipGraphics.FillRectangle(b, (i + 5) * 40, (10 - (j + 5)) * 40, 40, 40);
                        //Bitmap b = MiMundo.BitmapsCeldas[MiMundo.Celdas[x][y]];
                        //flip.DrawImage(b, (i+5)*40, (10-(j+5))*40);
                    }
                    catch 
                    {

                    }
                }
            }

            // Ahora pintamos el pj
            flipGraphics.DrawImage(MiJugador.MiBitmap, 5 * 40, 5 * 40);

            // Ahora pintamos el otro pj
            Bitmap otro = OtroJugador.MiBitmap;
            int ox = OtroJugador.X;
            int oy = OtroJugador.Y;
            flipGraphics.DrawImage(otro, (ox - px + 5) * 40, (10 - (oy - py + 5)) * 40);

            //g.Clear(this.BackColor);
        }

        public void Volcar()
        {
            Graphics g = this.CreateGraphics();
            g.DrawImage(flipImage, 0, 0);
            g.Dispose();
        }

    }
}
