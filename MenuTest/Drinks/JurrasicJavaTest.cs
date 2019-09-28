using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Java test class
    /// </summary>
    public class JurrasicJavaTest
    {
        /// <summary>
        /// Tests Default Price
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }
        /// <summary>
        /// Tests default Calories
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests default size
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        /// <summary>
        /// Tests default Ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        /// <summary>
        /// Tests default Space for cream
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }
        /// <summary>
        /// Tests calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        /// <summary>
        /// Tests calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        /// <summary>
        /// Tests calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        /// <summary>
        /// Tests price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }
        /// <summary>
        /// Tests price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }
        /// <summary>
        /// Tests price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }
        /// <summary>
        /// Tests that the HoldIce method changes ice to false
        /// </summary>
        [Fact]
        public void HoldIceShouldChangeIcePropertyToFalse()
        {
            JurassicJava java = new JurassicJava();
            java.Ice = true;
            java.HoldIce();
            Assert.False(java.Ice);
        }
        /// <summary>
        /// Tests that the RoomForCream changes to true with method
        /// </summary>
        [Fact]
        public void RoomForCreamShouldChangeCreamPropertyToTrue()
        {
            JurassicJava java = new JurassicJava();
            java.RoomForCream = false ;
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        /// <summary>
        /// Tests AddIceMethod
        /// </summary>
        [Fact]
        public void AddIceShouldSetIcePropertyToTrue()
        {
            JurassicJava java = new JurassicJava();
            java.Ice = false;
            java.AddIce();
            Assert.True(java.Ice);
        }
        /// <summary>
        /// Tests for correct ingredients
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
    }
}
