/*  Entree.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Entree Class
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Entree Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Entree Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Entree Ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
