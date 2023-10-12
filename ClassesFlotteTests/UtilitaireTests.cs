using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod]
        public void ChargeUtileTest()
        {
            // Arrange
            Utilitaire utilitaire = new Utilitaire("Marque", "Modele", 95, 5000, 2500, 10);

            // Act
            int chargeUtile = utilitaire.ChargeUtile();

            // Assert
            int expectedChargeUtile = 5000 - 2500;
            Assert.AreEqual(expectedChargeUtile, chargeUtile);
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // TODO
        }
    }
}