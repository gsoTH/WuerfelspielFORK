using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WurfTests
    {
        
        [TestMethod]
        public void Wurf_KannErzeugtWerden()
        {
            //Arrange
            int anzahlWuerfel = 5;

            // Act
            Wurf w = new Wurf(anzahlWuerfel);

            // Assert
            Assert.AreEqual(anzahlWuerfel, w.AnzahlWuerfel);
            Assert.IsInstanceOfType(w.Wuerfel,typeof(Array));
           
        }
    }
}
