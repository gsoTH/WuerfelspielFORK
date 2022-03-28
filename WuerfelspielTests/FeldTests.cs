using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class FeldTests
    {
        [TestMethod]
        public void Feld_KannErzeugtWerden()
        {
            // Arrange
            int akzeptierteAugenzahl = 1;

            // Act
            Feld f = new Feld(akzeptierteAugenzahl);
            
            // Assert 
            Assert.AreEqual(akzeptierteAugenzahl, f.AkzeptierteAugenzahl);
        }

        [TestMethod]
        public void Setzen_WurfWirdEntgegengenommenUndWertKorrektBerechnet()
        {
            // Arrange
            int akzeptierteAugenzahl = 1;
            Feld f = new Feld(akzeptierteAugenzahl);

            int summeAllerAkzeptierterAugen = 0;

            Wurf wurf = new Wurf(5);
            foreach(Wuerfel w in wurf.Wuerfel)
            {
                w.Wuerfeln();
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    summeAllerAkzeptierterAugen += w.LetztesErgebnis;
                }
            }

            // Act
            f.Setzen(wurf);

            // Assert
            Assert.AreEqual(summeAllerAkzeptierterAugen, f.Wert);
        }

        [TestMethod]
        public void Setzen_WurfWirdEntgegengenommenUndWertKorrektBerechnet2()
        {
            // Arrange
            int akzeptierteAugenzahl = 6;
            Feld f = new Feld(akzeptierteAugenzahl);

            int summeAllerAkzeptierterAugen = 0;

            Wurf wurf = new Wurf(5);
            foreach(Wuerfel w in wurf.Wuerfel)
            {
                w.Wuerfeln();
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    summeAllerAkzeptierterAugen += w.LetztesErgebnis;
                }
            }

            // Act
            f.Setzen(wurf);

            // Assert
            Assert.AreEqual(summeAllerAkzeptierterAugen, f.Wert);
        }

    }
}
