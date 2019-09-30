/*  Sodasaurus.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for soda
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem
    {
        private SodasaurusFlavors flavor = SodasaurusFlavors.Cola;
        /// <summary>
        /// Soda flavor
        /// </summary>
        public SodasaurusFlavors Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
        private Size size;
        /// <summary>
        /// Constructor, price and calories to default values
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;
        }
        /// <summary>
        /// Size 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    default:
                        Price = 1.50;
                        Calories = 112;
                            break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cane Sugar", "Water", "Natural Flavor" };
            }
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return "Sodasaurus";
        }
    }
}
