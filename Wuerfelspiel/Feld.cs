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
        private bool gesetzt;

        public Feld(int akzeptierteAugenzahl)
        {
            this.akzeptierteAugenzahl = akzeptierteAugenzahl;
            gesetzt = false;
        }

        public int AkzeptierteAugenzahl
        {
            get
            {
                return akzeptierteAugenzahl;
            }
        }

        public void Setzen(Wuerfel[] wuerfel)
        {
            if (gesetzt)
            {
                throw new ArgumentException("Nochmaliges Setzten nicht erlaubt.");
            }
            foreach(Wuerfel w in wuerfel)
            {
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    wert+=akzeptierteAugenzahl;
                }
                gesetzt = true;
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
