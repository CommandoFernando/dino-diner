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
        private bool Lemon { get; set; } = false;
        private Size size;
        /// <summary>
        /// Constructor sets Price and Calories to default values
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0;
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
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
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
                return new List<string>() { "Tea" };
            }
        }
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
