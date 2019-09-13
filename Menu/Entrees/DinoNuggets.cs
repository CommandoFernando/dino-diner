using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint nuggetCount { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {   
                for(int i = 0; i<nuggetCount; i++)
                {
                    Ingredients.Add("chicken nuggets");
                }
                List<string> ingredients = new List<string>() {};
                return ingredients;
            }
            
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
            this.nuggetCount = 6;
        }
        public void AddNugget()
        {
            this.nuggetCount = nuggetCount++;
            this.Calories = Calories + 59;
            this.Price = Price + .25;
        }
    }
}
