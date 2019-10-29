/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; } = null;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Overload constructor that takes an entree
        /// </summary>
        /// <param name="entree">the entree you want to select</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }
        /// <summary>
        /// Method for adding Brontowurst to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new Brontowurst();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for adding DinoNuggets to order
        /// </summary>
        /// <param name="sender">Default</param>
        /// <param name="args">Default</param>
        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new DinoNuggets();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for adding pbj to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService?.Navigate(new CustomizePBJ(pbj));
            }
        }
        /// <summary>
        /// Method for adding wings to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new PterodactylWings();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// /Method for adding steak burger to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new SteakosaurusBurger();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for adding King Burger to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new TRexKingBurger();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// method for adding Wrap to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.Entree = new VelociWrap();
                order.Add(this.Entree);
            }
            NavigationService?.Navigate(new MenuCategorySelection());
        }
    }
}
