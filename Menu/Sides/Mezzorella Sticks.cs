using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Mozzerella stick side
    /// </summary>
    public class Mezzorella_Sticks
    {
        /// <summary>
        /// Getter/Setter for Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Size of side
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Getter for Ingredients
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                return ingredients;
            }
        }
    }
}
