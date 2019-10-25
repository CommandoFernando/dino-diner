/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Changes page from Customize combo to
        /// Flavor selection
        /// </summary>
        /// <param name="sender">Default</param>
        /// <param name="args">Default</param>
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Changes Page from Customize Combo to 
        /// Side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
