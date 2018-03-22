using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialUnitTest;

namespace EssentialTrainingTest
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            // Expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Cholula"));
            // Expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));

        }
    }
}

