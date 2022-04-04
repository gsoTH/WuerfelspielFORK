using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class BlockTests
    {
        [TestMethod]
        public void Block_KannErstelltWerden()
        {
            // Act
            Block b = new Block();

            // Assert
            Assert.AreEqual(0, b.Summe);
            foreach(Feld f in b.Felder)
            {
                Assert.AreEqual(0, f.Wert);
            }

        }

        [TestMethod]
        public void Eintragen_ÜbergibtWerteAnFelder()
        {
            // Arrange
            Block b = new Block();
            Wuerfel[] w = new Wuerfel[5];

            // Act

            // Assert
            Assert.AreEqual(0, b.Summe);

        }
    }
}
