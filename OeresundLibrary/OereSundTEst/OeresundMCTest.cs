using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundLibrary;

namespace OereSundTEst
{
    [TestClass]
    public class OeresundMCTest
    {
        [TestMethod]
        public void TestPriceMC()
        {
            //Arrange
            var mc = new OeresundLibrary.OeresundMC();

            //Act
            int price = 210;

            //Assert
            Assert.AreEqual(price, mc.Price());

        }

        [TestMethod]
        public void TestDiscountCar()
        {
            //Arrange
            var mc = new OeresundLibrary.OeresundMC();

            //Act
            int price = 73;

            //Assert
            Assert.AreEqual(price, mc.DiscountPrice());

        }

        [TestMethod]
        public void TesOeresundCar()
        {
            //Arrange
            var mc = new OeresundLibrary.OeresundMC();

            //Act
            string vehicle = "Øresund MC";

            //Assert
            Assert.AreEqual(vehicle, mc.Vehicle());

        }
    }
}
