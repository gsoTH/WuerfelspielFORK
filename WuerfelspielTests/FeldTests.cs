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

            Becher becher = new Becher(5);
            foreach(Wuerfel w in becher.Wuerfel)
            {
                w.Wuerfeln();
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    summeAllerAkzeptierterAugen += w.LetztesErgebnis;
                }
            }

            // Act
            f.Setzen(becher.Wuerfel);

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

            Becher becher = new Becher(5);
            foreach(Wuerfel w in becher.Wuerfel)
            {
                w.Wuerfeln();
                if(w.LetztesErgebnis == akzeptierteAugenzahl)
                {
                    summeAllerAkzeptierterAugen += w.LetztesErgebnis;
                }
            }

            // Act
            f.Setzen(becher.Wuerfel);

            // Assert
            Assert.AreEqual(summeAllerAkzeptierterAugen, f.Wert);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Setzen_NochmalSetzenUnmoeglich()
        {
            // Arrange
            int akzeptierteAugenzahl = 6;
            Feld f = new Feld(akzeptierteAugenzahl);
            Becher becher = new Becher(5);

            // Act
            f.Setzen(becher.Wuerfel);
            f.Setzen(becher.Wuerfel);
        }

    }
}
