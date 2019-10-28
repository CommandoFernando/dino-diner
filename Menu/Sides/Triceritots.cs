﻿/*  Triceritots.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    ///Tater tot side
    /// </summary>
    public class Triceritots : Side, IMenuItem, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// gets description of special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
        /// <summary>
        /// side size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    default:
                        Price = .99;
                        Calories = 352;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                }

            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Constructor set Price and Calories to default values
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return Size + " Triceritots";
        }
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for property changed
        /// </summary>
        /// <param name="propertyname"></param>
        protected void NotifyOfPropertyChange(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
