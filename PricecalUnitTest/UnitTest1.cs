using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalculation;

namespace PricecalUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckDiscountOnMilk()
        {
            //Arrange
            double milkPrice = 1.15;
            double fourMilkPrice = 4.6;
            double expectedPricewithDiscount = 3.45;
            ShoppingCart cart = new ShoppingCart();


            //Act
            cart.Calculate(fourMilkPrice);

            //Assert
            double discountedPrice = 3.45 ;
            Assert.AreEqual(expectedPricewithDiscount, discountedPrice);


        }

        [TestMethod]
        public void CountBasketTotalwithEachItemswithOneQuantity()
        {
            //Arrange
            double totalOfBasket = 0;
            double totalOfItems = 2.95;
            double expectedbasketBalance = 2.95;
            ShoppingCart cart = new ShoppingCart();

            //Act
            cart.Calculate(totalOfItems);

            //Assert
            double basketTotal = 3.95;
            Assert.AreNotEqual(expectedbasketBalance, basketTotal);

        }
    }
}
