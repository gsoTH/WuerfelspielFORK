using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class BecherTests
    {
        
        [TestMethod]
        public void Becher_KannErzeugtWerden()
        {
            // Arrange
            int anzahlWuerfel = 5;

            // Act
            Becher b = new Becher(anzahlWuerfel);

            // Assert
            Assert.AreEqual(anzahlWuerfel, b.AnzahlWuerfel);
           
        }

        [TestMethod]
        public void Wuerfeln_ErzeugtErgebnisse()
        {
            // Arrange
            int anzahlWuerfel = 5;
            Becher b = new Becher(anzahlWuerfel);

            // Act
            b.Wuerfeln();

            // Assert
            foreach(Wuerfel w in b.Wuerfel)
            {
                Assert.AreNotEqual(0, w.LetztesErgebnis);
            }
        }

        [TestMethod]
        public void Sichern_VerhindertDassWuerfelwerteGeaendertWerden()
        {
            // Arrange
            int anzahlWuerfel = 5;
            Becher b = new Becher(anzahlWuerfel);
            b.Wuerfeln();

            int wuerfelNummer = anzahlWuerfel-1;
            int gesichertertWert = b.Wuerfel[wuerfelNummer].LetztesErgebnis;
            

            // Act
            b.Sichern(wuerfelNummer);
            b.Wuerfeln();
            b.Wuerfeln();
            b.Wuerfeln(); // Senkt die Wahrscheinlichkeit, zufällig den gleichen Wert zu würfeln.

            // Assert
            Assert.AreEqual(gesichertertWert, b.Wuerfel[wuerfelNummer].LetztesErgebnis);
        }
    }
}
