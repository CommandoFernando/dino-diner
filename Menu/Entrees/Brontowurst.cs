﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst Entree
    /// </summary>
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// Getter/Setter for the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for the Calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// list of ingredients for Brontowurst
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }
        /// <summary>
        /// Default constructor for BrontoWurst sets 
        /// default price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Method for Holding the bread
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Method for removing the peppers from the Brontowurst
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// Method for removing the Onion from list of ingredients
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

    }
}
