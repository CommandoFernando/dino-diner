using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Side of Fries
    /// </summary>
    public class Fryceritops
    {
        /// <summary>
        /// Getter/Setter for price
        /// </summary>
        public double Price { get; set; } ///It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **222 (small)**, **365 (medium)**, and **480 (large)**.
        /// <summary>
        /// Getter/Setter Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Size of side
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Ingredient list for Fryceritops
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "potatoes, salt, vegetable oil"};
                return ingredients;
            }
        }
        public Fryceritops()
        {
            this.Price = 
        }

    }
}
