/*  CretaceousCombo.cs
 *  Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo Class
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
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
        private Entree entree;
        private Drink drink;
        private Side side;
        /// <summary>
        /// Entree object for combo
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                this.entree = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
            }
        }
        /// <summary>
        /// Drink Object for combo
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                this.drink = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
            }
        }
        /// <summary>
        /// Side object for combo
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                this.side = value;
                Side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Ingredients");
                    NotifyOfPropertyChange("Description");
                    NotifyOfPropertyChange("Size");
                    NotifyOfPropertyChange("Price");
                };
            }
        }

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
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
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
        /// Combo constructor with no parameters
        /// </summary>
        public CretaceousCombo() {
            this.Entree = new Brontowurst();
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }
        /// <summary>
        /// Combo constructor Sets Entree to entree and initializes Side and Drink to default Value
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }
        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>string for combo</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
        /// <summary>
        /// The description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                //ingredients.Add(Entree.ToString());
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
        /// <summary>
        /// The PropertyChanged event handler; notifies of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for property changed
        /// </summary>
        /// <param name="propertyname"></param>
        protected void NotifyOfPropertyChange(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
