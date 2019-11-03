using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner;
using System.ComponentModel;


namespace MenuTest
{
    class MockMenuItem : IOrderItem {
        private double price = 0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Price {
            get { return price; }
        }
        public string Description { get { return "A Mock Item"; } }

        public string[] Special { get { return new string[0];  } }

        public MockMenuItem(double price)
        {
            this.price = price;
        }
    }

    public class OrderTest
    {
        [Fact]
        public void OrderShouldHaveTheCorrectCost()
        {
            Order order = new Order();
            //order.Add(new SteakosaurusBurger());
            Assert.Equal(0, order.TotalCost);
        }
        [Fact]
        public void OrderTotalCostShouldNotBeNegative()
        {
            Order order = new Order();

        }
    }
}
