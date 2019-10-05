/* Menu.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu class for listing menu items
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Getter for all available menu items list
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                return menuItems;
            }

        }
        /// <summary>
        /// getter for available entrees list
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> availableEntrees = new List<Entree>();
                return availableEntrees;
            }
        }
        /// <summary>
        /// getter for available sides list
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> sides = new List<Side>();
                return sides;
            }
        }
        /// <summary>
        /// getter for available drinks list
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinks = new List<Drink>();
                return drinks;
            }
        }
        /// <summary>
        /// getter for available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos { get; }
        /// <summary>
        /// ToString override method
        /// </summary>
        /// <returns>menu items on seperate lines</returns>
        public override string ToString()
        {
            List<IMenuItem> menu = AvailableMenuItems;
            List<string> menu2 = new List<string>();
            foreach (IMenuItem m in menu)
            {
                menu2.Add(m.ToString());
                menu2.Add("/n");
            }
            return menu2.ToString();
        }
    }
}
