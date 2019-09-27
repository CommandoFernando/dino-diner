using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        /// <summary>
        /// Tests Default Price
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }
        /// <summary>
        /// Tests default Calories
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// Tests default size
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        /// <summary>
        /// Tests default for Ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        /// <summary>
        /// Tests default for Lemon
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        /// <summary>
        /// Tests default for sweet
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        /// <summary>
        /// Tests Calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests price for Small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
        }
        /// <summary>
        /// Tests price for Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        /// <summary>
        /// Tests price for Medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        /// <summary>
        /// Tests hold ice method
        /// </summary>
        [Fact]
        public void HoldIceShouldSetIceToFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        /// <summary>
        /// Tests hold ice method
        /// </summary>
        [Fact]
        public void AddLemonShouldSetLemonToTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        /// <summary>
        /// Tests Calories for sweet small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for sweet medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(64, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for sweet large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<uint>(128, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for unsweet small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForUnSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for unsweet small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForUnSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for unsweet small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForUnSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Small;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }
    }
}
