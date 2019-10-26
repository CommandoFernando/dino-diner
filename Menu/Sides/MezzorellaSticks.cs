/*  MezzorellaSticks.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Mozzerella stick side
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem, INotifyPropertyChanged
    {

        private Size size;
        /// <summary>
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        Calories = 720;
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    default:
                        Price = .99;
                        Calories = 540;
                        NotifyOfPropertyChange("Special");
                        NotifyOfPropertyChange("Ingredients");
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
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return Size + " Mezzorella Sticks";
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
