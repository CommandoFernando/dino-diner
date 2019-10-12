/* MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Changes page from category selection
        /// to Combo Selection page
        /// </summary>
        /// <param name="sender">Default</param>
        /// <param name="args">Default</param>
        private void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// Changes page from category selection
        /// to Entree selection page
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        private void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Changes page from Category selection
        /// to Side Selection
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Changes page from Category Selection
        /// to Drink Selection
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());

        }
    }
}
