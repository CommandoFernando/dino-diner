using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Enum that defines the sizes (small, medium, large)
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Small sized side
        /// </summary>
        Small,
        /// <summary>
        /// Medium sized side
        /// </summary>
        Medium, 
        /// <summary>
        /// Large size side
        /// </summary>
        Large
    }
    /// <summary>
    /// Abstract side class
    /// </summary>
    public abstract class Side
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
        public List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }

    }
}
