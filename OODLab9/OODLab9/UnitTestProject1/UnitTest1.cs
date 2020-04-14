using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OODLab9;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;
            //act
            acc1.Deposit(200);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestMultipleMethod()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 200m;
            //act
            acc1.Deposit(100);
            acc1.Deposit(60);
            acc1.Deposit(40);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestHasZeroBalanceMethod()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            decimal expectedBalance = 0m;
            //act
            
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdrawSufficentFunds()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(200m);
            decimal expectedBalance = 100m;
            //act
            acc1.WithDraw(100m);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdrawInsufficentFunds()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(100m);
            decimal expectedBalance = 100m;
            //act
            acc1.WithDraw(200m);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdrawSufficentFunds_Overdraft()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            acc1.OverDraftLimit = 200m;
            decimal expectedBalance = -100m;
            //act
            acc1.WithDraw(100m);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }
        [TestMethod]
        public void TestWithdrawInsufficentFunds_Overdraft()
        {
            //arrange
            BankAccount acc1 = new BankAccount();
            acc1.OverDraftLimit = 200m;
            decimal expectedBalance = 0m;
            //act
            acc1.WithDraw(300m);
            //assert
            Assert.AreEqual(expectedBalance, acc1.Balance);
        }

    }

}
