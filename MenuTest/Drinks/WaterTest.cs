using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        /// <summary>
        /// Tests for default price should be .10
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests for Default Calories should be 0
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests default Ice should be true
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        /// <summary>
        /// Tests default Water size should be small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }
        /// <summary>
        /// Tests Lemon default. Should be false
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }
        /// <summary>
        /// Tests price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests price for Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Small;
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }
        /// <summary>
        /// Tests Calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Small;
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }
        /// <summary>
        /// Tests HoldIce method
        /// </summary>
        [Fact]
        public void HoldIceSetsIcePropertyToFalse()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        /// <summary>
        /// Tests AddLemon method
        /// </summary>
        [Fact]
        public void AddLemonShouldSetLemonPropertyToFalse()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        /// <summary>
        /// Tests for correct Ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsNoLemon()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }
        /// <summary>
        /// Tests for correct Ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsWithLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }
    }
}
