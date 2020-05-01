using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndividualProject_S00180206;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            ShowDiscription dardevil = new ShowDiscription();
            int finalViewership = 12265321;
            //Act
            dardevil.ViewerCount=(12265321);
            //Assert
            Assert.AreEqual(finalViewership, dardevil.ViewerCount);
        }
    }
}
