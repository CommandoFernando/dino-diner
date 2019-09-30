/*  MezzorellaSticks.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Mozzerella stick side
    /// </summary>
    public class Mezzorella_Sticks : Side, IMenuItem
    {

        private Size size;
        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// side size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
                        break;
                    default:
                        Price = .99;
                        Calories = 540;
                        break;
                }

            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Constructor set Price and Calories to default values
        /// </summary>
        public Mezzorella_Sticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return "Mezzorella Sticks";
        }
    }
}
