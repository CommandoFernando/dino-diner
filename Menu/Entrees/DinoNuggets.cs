using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Chicken Nugget Entree
    /// </summary>
    public class DinoNuggets
    {
        private uint nuggetCount { get; set; }
        /// <summary>
        /// Getter/Setter for the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for the calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// List of ingredients for the chicken nuggets
        /// </summary>
        public List<string> Ingredients
        {
            get
            {   
                for(int i = 0; i<nuggetCount; i++)
                {
                    Ingredients.Add("chicken nuggets");
                }
                List<string> ingredients = new List<string>() {};
                return ingredients;
            }
            
        }
        /// <summary>
        /// Default constructor sets the price, calories,
        /// and Nugget count fields to their default settings.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
            this.nuggetCount = 6;
        }
        /// <summary>
        /// Method for adding an additional chicken nugget to the entree
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount = nuggetCount++;
            this.Calories = Calories + 59;
            this.Price = Price + .25;
        }
    }
}
