/*  Drink.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Enum that defines the soda flavors
    /// </summary>
    public enum SodasaurusFlavor
    {
        /// <summary>
        /// Cola Flavor
        /// </summary>
        Cola,
        /// <summary>
        /// Orage flavor
        /// </summary>
        Orange,
        /// <summary>
        /// Vanilla flavor
        /// </summary>
        Vanilla,
        /// <summary>
        /// Chocolate flavor
        /// </summary>
        Chocolate,
        /// <summary>
        /// Rootbeer flavor
        /// </summary>
        RootBeer,
        /// <summary>
        /// Cherry flavor
        /// </summary>
        Cherry,
        /// <summary>
        /// Lime flavor
        /// </summary>
        Lime,
    }
    /// <summary>
    /// Drink Class
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Gets or protected sets the Ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// Method for holding the ice
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
