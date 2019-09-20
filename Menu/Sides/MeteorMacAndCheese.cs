using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Side of mack and cheese
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        private Size size;
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
        /// Ingredient list for mac and cheese
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "macaroni nooles", "cheese product", "pork sausage" };
            }
        }
    }
}
