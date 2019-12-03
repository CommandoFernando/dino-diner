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
        public DinoDiner.Menu.menu menu = new DinoDiner.Menu.menu();
        [BindProperty]
        public string search { get; set; } = "";
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public List<string> ingredientFilters { get; set; } = new List<string>();
        [BindProperty]
        public double minimumPrice { get; set; }
        [BindProperty]
        public double maximumPrice { get; set; } = 10;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if(search != null)
            {

            }
        }
    }
}