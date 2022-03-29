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
            //Arrange
            int anzahlWuerfel = 5;

            // Act
            Becher b = new Becher(anzahlWuerfel);

            // Assert
            Assert.AreEqual(anzahlWuerfel, b.AnzahlWuerfel);
           
        }
    }
}
