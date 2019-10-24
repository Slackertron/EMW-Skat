using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skat;

namespace SkatTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // Tester om metoden smider en exception på en negativ pris.
        public void TestNegativePris()
        {
            //Arrange
            double pris = -20000;
            string type = "Personbil";
            
            //Act og Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> Afgift.BilAfgift(pris, type));
        }

        [TestMethod]
        // Tester om metoden får nul når den bliver givet nul pris.
        public void Test0Pris()
        {
            //Arrange
            double pris = 0;
            string type = "Personbil";
            double expectedResult = 0;

            //Act
            double result = Afgift.BilAfgift(pris, type);

            //Assert
            Assert.AreEqual(expectedResult,result);
        }

        [TestMethod]
        // Tester om metoden kan håndtere og udregne det korrekte svar.
        public void TestUnder200000Pris()
        {
            //Arrange
            double pris = 198000;
            string type = "Personbil";
            double expectedResult = 168300;

            //Act
            double result = Afgift.BilAfgift(pris, type);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        // Tester om metoden kan håndtere og udregne det korrekte svar.
        public void Test200000Pris()
        {
            //Arrange
            double pris = 200000;
            string type = "Personbil";
            double expectedResult = 170000;

            //Act
            double result = Afgift.BilAfgift(pris, type);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        // Tester om metoden kan håndtere og udregne det korrekte svar.
        public void TestOver200000Pris()
        {
            //Arrange
            double pris = 230000;
            string type = "Personbil";
            double expectedResult = 215000;

            //Act
            double result = Afgift.BilAfgift(pris, type);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        // Tester om metoden smider en exception hvis prisen er over eller lig med max værdien for en double.
        public void TestMaxValuePris()
        {
            //Arrange
            double pris = double.MaxValue;
            string type = "Personbil";

            //Act og Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Afgift.BilAfgift(pris, type));
        }

        [TestMethod]
        // Tester om metoden kan håndtere og udregne det korrekte svar.
        public void TestElbil200000Pris()
        {
            //Arrange
            double pris = 200000;
            string type = "Elbil";
            double expectedResult = 34000;

            //Act
            double result = Afgift.BilAfgift(pris, type);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
