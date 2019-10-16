/*  CretaceousCombo.cs
 *  Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo Class
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// The Calories of the Item (uint)
        /// </summary>
        public uint Calories {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
            set
            {
                Calories = value;
            }
        }
        /// <summary>
        /// Entree object for combo
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Drink Object for combo
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Side object for combo
        /// </summary>
        public Side Side { get; set; }

        private Size size = Size.Small;
        /// <summary>
        /// Size property for Combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }
        /// <summary>
        /// Combo price getter
        /// </summary>
        public double Price
        {
            get {
                return Drink.Price + Side.Price + Entree.Price - .025;
            }
        }
        /// <summary>
        /// Combo Ingredient list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        private CretaceousCombo() { }
        /// <summary>
        /// Combo constructor Sets Entree to entree and initializes Side and Drink to default Value
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>string for combo</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                //ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                //ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                //ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
                //Entree.Special;
            }
        }
    }
}
