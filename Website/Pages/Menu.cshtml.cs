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
        public List<IMenuItem> menu;
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        public void OnGet()
        {
            menu = Menu.AvailableMenuItems;
        }
        public void OnPost()
        {
            menu = Menu.AvailableMenuItems;
        }
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