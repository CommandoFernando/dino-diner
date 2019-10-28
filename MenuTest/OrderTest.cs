using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderShouldHaveTheCorrectCost()
        {
            Order order = new Order();
            order.Add(new SteakosaurusBurger());
            Assert.Equal(0, order.TotalCost);
        }
        [Fact]
        public void OrderTotalCostShouldNotBeNegative()
        {
            Order order = new Order();
        }
    }
}
