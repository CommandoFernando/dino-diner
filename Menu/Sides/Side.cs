/* Side.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract side class
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem, INotifyPropertyChanged
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
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
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
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChange(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}