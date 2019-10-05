﻿/*  DinoNuggets.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Chicken Nugget Entree
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {

        private uint nuggetCount { get; set; }

        /// <summary>
        /// List of ingredients for the chicken nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Default constructor sets the price, calories,
        /// and Nugget count fields to their default settings.
        /// </summary>
        public DinoNuggets()
        {
            this.nuggetCount = 6;
            this.Calories = 59 * nuggetCount;
            this.Price = 4.25;
        }
        /// <summary>
        /// Method for adding an additional chicken nugget to the entree
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            this.Calories += 59;
            this.Price += .25;
        }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
