using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
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
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests Calories for sweet large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
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
            Assert.Equal<uint>(16, tea.Calories);
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
            Assert.Equal<uint>(32, tea.Calories);
        }
        /// <summary>
        /// Tests for correct Ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsNoLemonNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }
        /// <summary>
        /// Tests for correct Ingredients with Lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsWithLemonNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }
        /// <summary>
        /// Tests ingredients no lemon sweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsNoLemonSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }
        /// <summary>
        /// Tests for correct Ingredients with Lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsWithLemonSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.Sweet = true;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Empty(tt.Special);
        }
        [Fact]
        public void HoldIceShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }
        [Fact]
        public void AddLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }
        [Fact]
        public void SpecialShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }
    }
}
