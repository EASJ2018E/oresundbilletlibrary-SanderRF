using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundLibrary;

namespace OereSundTEst
{
    [TestClass]
    public class OereSundCarTest
    {
        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            var car = new OeresundLibrary.OeresundCar();

            //Act
            int price = 410;

            //Assert
            Assert.AreEqual(price,car.Price());
            
        }

        [TestMethod]
        public void TestDiscountCar()
        {
            //Arrange
            var car = new OeresundLibrary.OeresundCar();

            //Act
            int price = 161;

            //Assert
            Assert.AreEqual(price, car.DiscountPrice());

        }

        [TestMethod]
        public void TesOeresundCar()
        {
            //Arrange
            var car = new OeresundLibrary.OeresundCar();

            //Act
            string vehicle = "Øresund Bil";

            //Assert
            Assert.AreEqual(vehicle, car.Vehicle());

        }
    }
}
