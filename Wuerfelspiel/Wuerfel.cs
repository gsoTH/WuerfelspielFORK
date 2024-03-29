﻿using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private Random rnd;
        private int letztesErgebnis;
        private bool gesichert;

        public Wuerfel():this(6)
        {

        }

        public Wuerfel(int anzahlSeiten)
        {
            if(anzahlSeiten <= 1)
            {
                throw new ArgumentOutOfRangeException("Negative Werte nicht möglicht.");
            }

            rnd = new Random();
            this.anzahlSeiten = anzahlSeiten;
            letztesErgebnis = 0;
            gesichert = false;
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

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }

            set
            {
                gesichert = value;
            }
        }

        public int Wuerfeln()
        {
            if(gesichert == false)
            {
                letztesErgebnis = rnd.Next(1, anzahlSeiten+1);
            }
            return letztesErgebnis;
        }

        public void SicherungUmschalten()
        {
            gesichert = !gesichert;
        }
    }
}
