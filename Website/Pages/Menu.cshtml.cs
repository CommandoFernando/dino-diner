using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using DinoDiner;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
        public Menu menu = new Menu();
        /// <summary>
        /// Getter for menu
        /// </summary>
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }
        public List<Drink> ListDrinks()
        {
            return Menu.AvailableDrinks;
        }
    }
}