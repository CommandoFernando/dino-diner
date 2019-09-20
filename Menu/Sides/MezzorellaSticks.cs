using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Mozzerella stick side
    /// </summary>
    public class Mezzorella_Sticks : Side
    {
        private Size size;
        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "cheese product", "breading", "Vegetable Oil" };
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
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 540;
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
    }
}
