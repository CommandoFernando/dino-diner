/* IOrderItem.cs
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
    /// Iorder interface
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Description string
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Special instructions
        /// </summary>
        string[] Special { get; }
    }
}
