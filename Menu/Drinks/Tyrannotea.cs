/*  Tyrannotea.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Tea drink class
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Bool tells whether sweet
        /// </summary>
        public bool Sweet { get; set; } = false;
        /// <summary>
        /// bool tells whether lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
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
        /// Method for adding lemon to tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
