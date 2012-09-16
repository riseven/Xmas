using System;
using System.Collections.Generic;
using System.Text;

namespace Xmas
{
    public class Puerta
    {
        private Jugador opener;
        private int codigo;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public Jugador Opener
        {
            get
            {
                return opener;
            }
        }

        public Puerta(int cod)
        {
            opener = null;
            codigo = cod;
        }

        public void Open(Jugador j)
        {
            if (opener != null )
            {
                //throw new Exception("Puerta ya abierta");
                return;
            }
            opener = j;
        }

        public string GetPregunta()
        {
            string ret = "";

            switch (codigo)
            {
                case 0:
                    ret = "5+5\n¿cuanto es?";
                    break;
                default:
                    return "Hola";
            }
            return ret;
        }
    }
}
