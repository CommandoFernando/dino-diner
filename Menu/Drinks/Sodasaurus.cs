/*  Sodasaurus.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for soda
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged
    {
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;
        /// <summary>
        /// Soda flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
            }
        }
        private Size size;
        /// <summary>
        /// Constructor, price and calories to default values
        /// </summary>
        public Sodasaurus()
        {
            this.Size = Size.Small;
            this.Price = 1.50;
            this.Calories = 112;
        }
        /// <summary>
        /// Size 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        NotifyOfPropertyChange("Ingredients");
                        break;
                    default:
                        Price = 1.50;
                        Calories = 112;
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
        /// List of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cane Sugar", "Water", "Natural Flavor" };
            }
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return Size + " " + flavor + " Sodasaurus";
        }
        /// <summary>
        /// returns the description
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets the special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
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
        protected override void NotifyOfPropertyChange(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
