/* SideSelection.xaml.cs
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
using DinoDiner;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Backing field for side
        /// </summary>
        public Side Side {get; set;} = null;
        /// <summary>
        /// Side selection default Constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Overloaded side selection constructor sets the Side to side passed in
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        /// <summary>
        /// Method for adding fryceritops to order
        /// </summary>
        /// <param name="sender">default sender</param>
        /// <param name="args">default args</param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            //BtnAddFryceritops.IsEnabled = false;
            //BtnAddMeteorMacAndCheese.IsEnabled = false;
        }
        /// <summary>
        /// Method for adding mac and cheese to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default args</param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                order.Items.Add(new MeteorMacAndCheese());
            }
        }
        /// <summary>
        /// Method for Adding Mezzorella sticks to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new MezzorellaSticks());
        }
        /// <summary>
        /// method for adding triceritots to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            Order order = (Order)DataContext;
            order.Items.Add(new Triceritots());
        }
        /// <summary>
        /// Side selection method
        /// </summary>
        /// <param name="side">the side that you want to select</param>
        protected void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }
        /// <summary>
        /// Helper Method for selecting the size of a side
        /// </summary>
        /// <param name="size">the size that you want</param>
        public void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
            }
            //NavigationService?.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for selecting large side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectLarge(Object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for selecting medium side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectMedium(Object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// method for selecting small size side
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        protected void OnSelectSmall(Object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
