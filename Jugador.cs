using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Xmas
{
    public class Jugador
    {
        private int x;
        private int y;
        private Bitmap miBitmap;
        private Mundo miMundo;
        private VisorControl miVisor;
        private Puerta puertaActual;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Bitmap MiBitmap
        {
            get
            {
                return miBitmap;
            }
            set
            {
                miBitmap = value;
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
        public VisorControl MiVisor
        {
            get
            {
                return miVisor;
            }
            set
            {
                miVisor = value;
            }
        }

        public Jugador()
        {
            x = y = 0;
        }

        public void Mover(int dx, int dy)
        {
            if (puertaActual != null)
            {
                return;
            }
            if (miMundo.IntentoMoverme(this, x + dx, y + dy))
            {
                x += dx;
                y += dy;
            }
            else
            {
                // Compruebo si hay una puerta
                Puerta p = miMundo.PuertaEn(x + dx, y + dy);
                if (p != null)
                {
                    puertaActual = p;
                    miVisor.TextoPregunta = p.GetPregunta();
                    puertaActual.Open(this);
                    puertaActual = null;
                }
            }
        }

        public void Actualizar()
        {
            //x++;
        }
    }
}
