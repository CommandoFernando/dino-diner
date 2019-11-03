/*  Tyrannotea.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tea drink class
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, INotifyPropertyChanged
    {
        private bool sweet = false;
        /// <summary>
        /// Bool tells whether sweet
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// bool tells whether lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// bool for ice
        /// </summary>
       // private bool Ice { get; set; } = true;
        private Size size;
        /// <summary>
        /// Constructor sets Price and Calories to default values
        /// </summary>
        public Tyrannotea()
        {
            this.Price = .99;
            this.Calories = 8;
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
                        Price = 1.99;
                        if (Sweet)
                        {
                            Calories = 64;
                        }
                        else { Calories = 32; }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet)
                        {
                            Calories = 32;
                        }
                        else { Calories = 16; }
                        break;
                    case Size.Small:
                        Price = .99;
                        if (Sweet)
                        {
                            Calories = 16;
                        }
                        else { Calories = 8; }
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
                List<string> ingredients = new List<string>() { "Tea", "Water" };
                if (Sweet) { ingredients.Add("Cane Sugar"); }
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
                if (Sweet) special.Add("Add Cane Sugar");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Method for adding lemon to tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// M
        /// </summary>
        public void MakeSweet()
        {
            this.Sweet = true;
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Description");
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            if (Sweet) { return Size + " Sweet Tyrannotea"; }
            else { return Size + " Tyrannotea"; }
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
