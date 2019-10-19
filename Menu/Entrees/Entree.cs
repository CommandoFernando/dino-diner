/*  Entree.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree Class
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
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
        /// <summary>
        /// gets and sets description
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets description of special instructions
        /// </summary>
        public abstract string[] Special { get; }
    }
}
