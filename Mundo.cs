using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;

namespace Xmas
{
    public enum TypeCelda 
    {
        Muro,
        Pasillo,
        Puerta
    }

    public class Mundo
    {
        private int tamX;
        private int tamY;
        private TypeCelda[][] celdas;
        private Dictionary<TypeCelda, System.Drawing.Bitmap> bitmapsCeldas;
        private List<Jugador> jugadores;
        private Dictionary<Point, Puerta> puertas;


        public int TamX
        {
            get
            {
                return tamX;
            }
        }
        public int TamY
        {
            get
            {
                return tamY;
            }
        }
        public TypeCelda[][] Celdas
        {
            get
            {
                return celdas;
            }
        }
        public Dictionary<TypeCelda, Bitmap> BitmapsCeldas
        {
            get
            {
                return bitmapsCeldas;
            }
        }
        public List<Jugador> Jugadores
        {
            get
            {
                return jugadores;
            }
        }

        public Mundo()
        {
            tamX = tamY = 0;
            celdas = new TypeCelda[0][];
        }

        public Mundo(String s)
        {
            CreateFromString(new StringReader(s));
        }

        public Mundo(FileInfo file)
        {
            FileStream fs = file.OpenRead();
            StreamReader sr = new StreamReader(fs);
            StringReader str = new StringReader(sr.ReadToEnd());
            CreateFromString(str);
            sr.Close();
            

            string firstLine = sr.ReadLine();
            string[] size = firstLine.Split(' ');
            tamX = int.Parse(size[0]) ;
            tamY = int.Parse(size[1]) ;

            celdas = new TypeCelda[tamX][];
            for ( int i = 0 ; i < celdas.Length ; i++ )
            {
                celdas[i] = new TypeCelda[tamY];
            }

            for (int x = 0; x < tamX; x++)
            {
                for (int y = 0; y < tamY; y++)
                {
                    celdas[x][y] = TypeCelda.Pasillo;
                }
            }

            sr.Close();
        }

        private void CreateFromString(StringReader sr)
        {
            string firstLine = sr.ReadLine();
            string[] size = firstLine.Split(' ');
            tamX = int.Parse(size[0]);
            tamY = int.Parse(size[1]);

            celdas = new TypeCelda[tamX][];
            for (int i = 0; i < celdas.Length; i++)
            {
                celdas[i] = new TypeCelda[tamY];
            }

            puertas = new Dictionary<Point, Puerta>();

            for (int y = tamY-1; y >= 0; y--)
            {
                string fila = sr.ReadLine();
                string[] trozos = fila.Split(';');
                int numPuerta = 1;
                for (int x = 0; x < tamX; x++)
                {
                    switch (fila[x])
                    {
                        case '#':
                            celdas[x][y] = TypeCelda.Muro;
                            break;
                        case ' ':
                            celdas[x][y] = TypeCelda.Pasillo;
                            break;
                        case '|':
                        case '-':
                            celdas[x][y] = TypeCelda.Puerta;
                            // Añadimos la puerta
                            puertas[new Point(x, y)] = new Puerta(int.Parse(trozos[numPuerta++]));
                            break;
                        default:
                            throw new Exception("Caracter no valido");
                    }
                }
            }

            sr.Close();

            // Creamos los bitmaps
            bitmapsCeldas = new System.Collections.Generic.Dictionary<TypeCelda, System.Drawing.Bitmap>();
            bitmapsCeldas[TypeCelda.Muro] = Resources.muro;
            bitmapsCeldas[TypeCelda.Pasillo] = Resources.pasillo;

            jugadores = new List<Jugador>();
        }

        public bool IntentoMoverme(Jugador j, int x, int y)
        {
            foreach (Jugador jug in jugadores)
            {
                if (jug.X == x && jug.Y == y)
                {
                    return false;
                }
            }

            if (celdas[x][y] == TypeCelda.Pasillo)
            {
                return true;
            }
            else if (celdas[x][y] == TypeCelda.Muro)
            {
                return false;
            }
            else if (celdas[x][y] == TypeCelda.Puerta)
            {
                Puerta p = puertas[new Point(x, y)];
                if (p.Opener == j)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public Brush GetPaintColor(Jugador j, int x, int y)
        {
            if (celdas[x][y] == TypeCelda.Muro)
            {
                return Brushes.Brown;
            }
            else if (celdas[x][y] == TypeCelda.Pasillo)
            {
                return Brushes.Khaki;
            }
            else if (celdas[x][y] == TypeCelda.Puerta)
            {
                Puerta p = puertas[new Point(x,y)];
                if (p.Opener == null)
                {
                    return Brushes.BlueViolet;
                }
                else if (p.Opener == j)
                {
                    return Brushes.Khaki;
                }
                else
                {
                    return Brushes.Red;
                }
            }
            return Brushes.Gray;
        }

        public Puerta PuertaEn(int x, int y)
        {
            if (puertas.ContainsKey(new Point(x, y)))
            {
                Puerta p = puertas[new Point(x, y)];
                if (p.Opener == null)
                {
                    return p;
                }
                return null;
            }
            return null;
        }
    }
}
