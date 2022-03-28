using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Feld
    {
        private int akzeptierteAugenzahl;
        private int wert;

        public Feld(int akzeptierteAugenzahl)
        {
            this.akzeptierteAugenzahl = akzeptierteAugenzahl;
        }

        public int AkzeptierteAugenzahl
        {
            get
            {
                return akzeptierteAugenzahl;
            }
        }

        public void Setzen(Wurf wurf)
        {
            foreach(Wuerfel w in wurf.Wuerfel)
            {
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    wert+=akzeptierteAugenzahl;
                }
            }
        }

        public int Wert
        {
            get
            {
                return wert;
            }
        }
    }
}
