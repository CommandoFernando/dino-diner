/*  Water.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Water drink class
    /// </summary>
    public class Water : Drink, IMenuItem
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
        /// ToString override method
        /// </summary>
        /// <returns>name of Item</returns>
        public override string ToString()
        {
            return "Water";
        }
    }
}
