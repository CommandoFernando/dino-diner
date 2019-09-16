using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// PBJ entree class
    /// </summary>
    public class PrehistoricPBJ
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// Getter/Setter for Price of PBJ
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Getter/Setter for Calories of PBJ
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// List of ingredients for PBJ
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Default constructor for PBJ
        /// initializes price to default values
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Method for removing peanutbutter from ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Method for removing the Jelly from ingredients
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
