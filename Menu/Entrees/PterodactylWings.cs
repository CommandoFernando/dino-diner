using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Chicken wing Entree
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Getter/Setter for price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// List of ingredients for wings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Default constructor initializes
        /// Price and calories to default values
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
