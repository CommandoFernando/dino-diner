﻿/* Menu.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu class for listing menu items
    /// </summary>
    public class menu
    {
        /// <summary>
        /// Getter for all available menu items list
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {

                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.AddRange(AvailableEntrees);
                menuItems.AddRange(AvailableSides);
                menuItems.AddRange(AvailableDrinks);
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
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                combos.Add(new CretaceousCombo(new Brontowurst()));
                combos.Add(new CretaceousCombo(new DinoNuggets()));
                combos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                combos.Add(new CretaceousCombo(new PterodactylWings()));
                combos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                combos.Add(new CretaceousCombo(new TRexKingBurger()));
                combos.Add(new CretaceousCombo(new VelociWrap()));

                return combos;
            }
        }
        /// <summary>
        /// A getter for all the possible ingredients
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
                menu menu = new menu();
                foreach (IMenuItem item in menu.AvailableMenuItems)
                {
                    foreach (string s in item.Ingredients)
                    {
                        ingredients.Add(s);
                    }
                }
                return ingredients.ToList();
            }
        }
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
