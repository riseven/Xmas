using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Xmas
{
    public partial class XmasForm : Form
    {
        private Mundo mundo;
        private Jugador jugador1, jugador2;

        Dictionary<Keys, bool> keysPressed;

        public XmasForm()
        {
            InitializeComponent();

            keysPressed = new Dictionary<Keys, bool>();
            keysPressed[Keys.W] = false;
            keysPressed[Keys.A] = false;
            keysPressed[Keys.S] = false;
            keysPressed[Keys.D] = false;
            keysPressed[Keys.I] = false;
            keysPressed[Keys.J] = false;
            keysPressed[Keys.K] = false;
            keysPressed[Keys.L] = false;

            // Creamos el mundo
            mundo = new Mundo(Resources.mundo);            

            jugador1 = new Jugador();
            jugador2 = new Jugador();

            jugador1.X = 58;
            jugador1.Y = 1;
            jugador1.MiBitmap = Resources.mj;
            jugador1.MiMundo = mundo;
            jugador1.MiVisor = visorControl1;

            jugador2.X = 62;
            jugador2.Y = 1;
            jugador2.MiBitmap = Resources.mj;
            jugador2.MiMundo = mundo;
            jugador2.MiVisor = visorControl2;

            mundo.Jugadores.Add(jugador1);
            mundo.Jugadores.Add(jugador2);

            visorControl1.MiJugador = jugador1;
            visorControl1.OtroJugador = jugador2;
            visorControl1.MiMundo = mundo;

            visorControl2.MiJugador = jugador2;
            visorControl2.OtroJugador = jugador1;
            visorControl2.MiMundo = mundo;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (keysPressed[Keys.W])
            {
                jugador1.Mover(0, 1);
            }
            else if (keysPressed[Keys.A])
            {
                jugador1.Mover(-1, 0);
            }
            else if (keysPressed[Keys.S])
            {
                jugador1.Mover(0, -1);
            }
            else if (keysPressed[Keys.D])
            {
                jugador1.Mover(1, 0);
            }

            if (keysPressed[Keys.I])
            {
                jugador2.Mover(0, 1);
            }
            else if (keysPressed[Keys.J])
            {
                jugador2.Mover(-1, 0);
            }
            else if (keysPressed[Keys.K])
            {
                jugador2.Mover(0, -1);
            }
            else if (keysPressed[Keys.L])
            {
                jugador2.Mover(1, 0);
            }

            // Actualizamos los jugadores
            jugador1.Actualizar();
            jugador2.Actualizar();

            // Pintamos
            visorControl1.Pintar();
            visorControl2.Pintar();

            // Volcamos las imagenes a la pantalla
            visorControl1.Volcar();
            visorControl2.Volcar();
        }

        private void botonTeclado_KeyDown(object sender, KeyEventArgs e)
        {
            keysPressed[e.KeyCode] = true;
        }

        private void botonTeclado_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed[e.KeyCode] = false;
        }
    }
}