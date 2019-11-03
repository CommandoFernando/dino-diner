/* SideSelection.xaml.cs
 * Author: Fernando Velarde
 */
using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner;

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
        private Side side;
        private CretaceousCombo combo = new CretaceousCombo();
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
            this.side = side;
        }
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// Method for adding fryceritops to order
        /// </summary>
        /// <param name="sender">default sender</param>
        /// <param name="args">default args</param>
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            combo.Side = new Fryceritops();
            this.side = new Fryceritops();
            Order order = (Order)DataContext;
            order.Add(this.side);
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
            combo.Side = new MeteorMacAndCheese();
            this.side = new MeteorMacAndCheese();
            if(DataContext is Order order)
            {
                order.Add(this.side);
            }
        }
        /// <summary>
        /// Method for Adding Mezzorella sticks to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            combo.Side = new MezzorellaSticks();
            this.side = new MezzorellaSticks();
            Order order = (Order)DataContext;
            order.Add(this.side);
        }
        /// <summary>
        /// method for adding triceritots to order
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            combo.Side = new Triceritots();
            this.side = new Triceritots();
            Order order = (Order)DataContext;
            order.Add(this.side);
        }
        /// <summary>
        /// Side selection method
        /// </summary>
        /// <param name="side">the side that you want to select</param>
        protected void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                this.side = side;
                order.Add(side);
            }
        }
        /// <summary>
        /// Helper Method for selecting the size of a side
        /// </summary>
        /// <param name="size">the size that you want</param>
        public void SelectSize(DinoDiner.Menu.Size size)
        {
            if(this.side != null)
            {
                this.side.Size = size;
            }
            NavigationService?.Navigate(new MenuCategorySelection());
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
    }
}
