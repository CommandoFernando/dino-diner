/*  Water.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink class
    /// </summary>
    public class Water : Drink, IMenuItem, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// Bool for whether the water has Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Method for adding lemon to water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Constructor sets size and calories to default values
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
        }
        /// <summary>
        /// Size 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
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
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) { ingredients.Add("Lemon"); }
                return ingredients;
            }
        }
        /// <summary>
        /// gets the special instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return $"{Size} Water";
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
