using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Block
    {
        List<Feld> felder;

        public Block()
        {

        }

        public int Summe
        {
            get
            {
                int ergebnis = 0;
                
                foreach(Feld f in felder)
                {
                    ergebnis += f.Wert;
                }

                return ergebnis;
            }
        }

        public List<Feld> Felder
        {
            get
            {
                return felder;
            }
        }
    }
}
