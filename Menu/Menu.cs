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
                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());
                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new JurassicJava());
                menuItems.Add(new Water());
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
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
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
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
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
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new JurassicJava());
                drinks.Add(new Water());
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
