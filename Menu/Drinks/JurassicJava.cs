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
        private bool Decaf { get; set; } = false;
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
            this.Size = Size.Small;
        }
        /// <summary>
        /// Method for leaving room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        /// <summary>
        /// Method for adding Ice
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
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
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    default:
                        Price = .59;
                        Calories = 2;
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
                return new List<string>() { "Coffee", "Water",};
            }
        }
    }
}
