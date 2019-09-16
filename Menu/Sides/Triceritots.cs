﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    ///Tater tot side
    /// </summary>
    public class Triceritots
    {
        /// <summary>
        /// Getter/Setter for Price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Size of side
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Ingredient list for Triceritots
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
    }
}
