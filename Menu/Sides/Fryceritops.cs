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
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// List of ingredients
        /// </summary>
        public List<string> Ingredients
        {
            //get { }
        }
        
    }
}
