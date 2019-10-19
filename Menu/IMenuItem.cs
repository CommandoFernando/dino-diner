/* MenuItem.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu Item Interface
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// property with a getter for Price (double)
        /// </summary>
        double Price { get; }
        /// <summary>
        /// property with a getter for Calories (uint)
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// property with a getter for Ingredients (a List).
        /// </summary>
        List<string> Ingredients { get; }

    }
}
