/*  JurassicJava.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for Coffee
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Bool for leaving room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// bool for whether coffee is decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;
        private Size size;
        /// <summary>
        /// Ice inheritence override for hot Java
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// Public constructor sets price and calories to default values
        /// </summary>
        public JurassicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Size = Size.Small;
        }
        /// <summary>
        /// Method for leaving room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method for adding Ice
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    default:
                        Price = .59;
                        Calories = 2;
                        break;
                }
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Price");
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
                return new List<string>() { "Coffee", "Water", };
            }
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            if (Decaf) { return Size + " Decaf Jurassic Java"; }
            return Size + " Jurassic Java";
        }
        /// <summary>
        /// gets description of special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                //if (Decaf) special.Add("Defac");
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Leave room for cream");
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
