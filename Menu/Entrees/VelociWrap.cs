/*  VelociWrap.cs
*   Author: Fernando Velarde
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Velociwrap menu item
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Tells whether the wrap has dressing or not
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Tells whether the wrap has lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Tells whether the wrap has cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// Ingredient list for VelociWrap
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// VelociWrap default constructor
        /// sets price and calories to default values
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Method for removing dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// Method for Removing the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Method for Removing the Cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
