using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private Random rnd;
        private int letztesErgebnis;

        public Wuerfel():this(6)
        {
            //anzahlSeiten = 6;
        }

        public Wuerfel(int anzahlSeiten)
        {
            if(anzahlSeiten <= 1)
            {
                throw new ArgumentOutOfRangeException("Negative Werte nicht möglicht.");
            }
            rnd = new Random();
            this.anzahlSeiten = anzahlSeiten;
        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public int LetztesErgebnis 
        {
            get
            {
                return letztesErgebnis;
            }
        }

        public int Wuerfeln()
        {
            letztesErgebnis = rnd.Next(1, anzahlSeiten);
            return letztesErgebnis;
        }
    }
}
