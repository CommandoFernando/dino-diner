using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Steak burger Entree
    /// </summary>
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        /// <summary>
        /// Getter/Setter for price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// List of ingredients for SteakBurger
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Default constructor for steak burger
        /// Sets the price and calories to default values
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Method for removing the bun from ingredient list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// method for removing the pickle from the list of ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Method for removing the Ketchup from the list of ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Method for removing the mustard from the list of ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
