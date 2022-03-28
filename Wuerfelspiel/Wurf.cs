﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Wurf
    {
        private int anzahlWuerfel;
        private Wuerfel[] wuerfel;

        public Wurf(int anzahlWuerfel)
        {
            wuerfel = new Wuerfel[anzahlWuerfel];
            for (int i = 0; i < anzahlWuerfel; i++)
            {
                wuerfel[i] = new Wuerfel();
            }
            this.anzahlWuerfel = anzahlWuerfel;
        }

        public int AnzahlWuerfel
        {
            get
            {
                return anzahlWuerfel;
            }
        }

        public Wuerfel[] Wuerfel
        {
            get
            {
                return wuerfel;
            }
        }
    }
}
