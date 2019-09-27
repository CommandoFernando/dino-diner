using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        /// <summary>
        /// Tests Flavor: Cola
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Cola;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Cola, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: Orange
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Orange;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Orange, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: Vanilla
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Vanilla;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Vanilla, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: Chocolate
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Chocolate;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Chocolate, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: RootBeer
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.RootBeer;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.RootBeer, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: Cherry
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Cherry;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Cherry, soda.Flavor);
        }
        /// <summary>
        /// Tests Flavor: Lime
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavors.Lime;
            Assert.Equal<SodasaurusFlavors>(SodasaurusFlavors.Lime, soda.Flavor);
        }
        /// <summary>
        /// Tests Default Price
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        /// <summary>
        /// Tests default Calories
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        /// <summary>
        /// Tests default size
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }
        /// <summary>
        /// Tests price for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }
        /// <summary>
        /// Tests price for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(2.00, soda.Price);
        }
        /// <summary>
        /// Tests price for Large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }
        /// <summary>
        /// Tests default for Ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        /// <summary>
        /// Tests Calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        /// <summary>
        /// Tests Calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(156, soda.Calories);
        }
        /// <summary>
        /// Tests Calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(208, soda.Calories);
        }
        [Fact]
        public void HoldIceShouldSetIceToFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
    }
}
