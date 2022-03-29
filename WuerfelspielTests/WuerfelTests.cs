using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;
using System.Linq;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_AnzahlSeitenKannAngegebenWerden()
        {
            // Arrange
            int anzahlSeiten = 12;

            // Act
            Wuerfel w = new Wuerfel(anzahlSeiten);

            // Assert
            Assert.AreEqual(anzahlSeiten, w.AnzahlSeiten);
        }

        [TestMethod]
        public void Wuerfel_OhneParameterWirdEinStandardwuerfelErzeugt()
        {
            // Act
            Wuerfel w = new Wuerfel();

            // Assert
            Assert.AreEqual(6, w.AnzahlSeiten);
        }

        [TestMethod]
        public void Wuerfeln_ErzeugtErgebnis()
        {
            // Arrange
            int obereGrenze = 6;
            int untereGrenze = 1;
            Wuerfel w = new Wuerfel(obereGrenze);
            int anzahlVersuche = 100;
            int[] ergebnisse = new int[anzahlVersuche];


            // Act
            for (int i = 0; i < anzahlVersuche; i++)
            {
                ergebnisse[i] = w.Wuerfeln();
            }

            // Assert
            Assert.IsTrue(ergebnisse.Max()<= obereGrenze);
            Assert.IsTrue(ergebnisse.Min()>= untereGrenze);

        }

        [TestMethod]
        public void LetztesErgebnis_HatErgebnisVomLetztenWuerfeln()
        {
            // Arrange
            Wuerfel w = new Wuerfel();

            // Act
            int ergebnis = w.Wuerfeln();

            // Assert
            Assert.AreEqual(ergebnis, w.LetztesErgebnis);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Wuerfel_NegativeAnzahlSeitenUnmoeglich()
        {
             // Act
            Wuerfel w = new Wuerfel(-1);
        }

        [TestMethod]
        public void Gesichert_KannVeraendertWerden()
        {
            // Arrange
            Wuerfel w = new Wuerfel();

            // Act
            w.Gesichert = true;

            // Assert
            Assert.IsTrue(w.Gesichert);
        }
    }
}
