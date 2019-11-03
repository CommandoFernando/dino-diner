/* DrinkSelection.xaml.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private CretaceousCombo combo = new CretaceousCombo();
        /// <summary>
        /// Backing field for Drink
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor overload that takes a drink parameter
        /// </summary>
        /// <param name="drink">the selected drink</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// Method for done button
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">defauult</param>
        public void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for adding jurassic java
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo.Drink = new JurassicJava();
                this.Drink = new JurassicJava();
                order.Add(this.Drink);
            }
        }
        /// <summary>
        /// Method for adding sodasaurus
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo.Drink = new Sodasaurus();
                Sodasaurus soda = new Sodasaurus();
                this.Drink = soda;               
                order.Add(this.Drink);
            }

        }
        /// <summary>
        /// Method for adding tyrannotea
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo.Drink = new Tyrannotea();
                this.Drink = new Tyrannotea();
                order.Add(this.Drink);

            }
        }
        /// <summary>
        /// Method for adding water
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo.Drink = new Water();
                this.Drink = new Water();
                order.Add(this.Drink);
            }
        }
        /// <summary>
        /// Helper Method for selecting the size
        /// </summary>
        /// <param name="size">the size that you want</param>
        public void SelectSize(DinoDiner.Menu.Size size)
        {
            if (this.Drink != null)
            {
                combo.Drink.Size = size;
                this.Drink.Size = size;
            }
            //NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for selecting large side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        /// <summary>
        /// Method for selecting medium side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        /// <summary>
        /// method for selecting small size side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
        public void OnSpecial(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava)
            {
                BtnSpecial.Content = "Decaf";
            }
            if(this.Drink == new Tyrannotea())
            {
                BtnSpecial.Content = "Sweet";
            }
            if(this.Drink is Sodasaurus)
            {
                NavigationService?.Navigate(new FlavorSelection(this.Drink as Sodasaurus));
            }
            if(this.Drink is Water)
            {
                BtnSpecial.IsEnabled = false;
               // NavigationService?.Navigate(new DrinkSelection());
            }
        }
     //   public void OnHold

    }
}
