/*  JurassicJava.cs
*   Author: Fernando Velarde
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for Coffee
    /// </summary>
    public class JurassicJava : Drink
    {
        private bool RoomForCream { get; set; } = false;
        private bool Decaf = false;
        private Size size;
        /// <summary>
        /// Ice inheritence override for hot Java
        /// </summary>
        public override bool Ice { get; protected set; } = false;
        /// <summary>
        /// Public constructor sets price and calories to default values
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0;
            this.Calories = 0;
        }
        /// <summary>
        /// Method for leaving room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
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
                return new List<string>() { "Coffee", "Water", "Sugar", "Cream" };
            }
        }
    }
}
