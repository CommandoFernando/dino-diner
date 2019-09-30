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
    public class CretaceousCombo
    {
        /// <summary>
        /// The Calories of the Item (uint)
        /// </summary>
        public uint Calories { get; set; }
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
        /// <summary>
        /// Custom to string for combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"";
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
    }
}
