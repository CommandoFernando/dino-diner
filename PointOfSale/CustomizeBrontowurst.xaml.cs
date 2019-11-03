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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst dog;
        public CustomizeBrontowurst(Brontowurst dog)
        {
            InitializeComponent();
            this.dog = dog;
        }
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            dog.HoldBun();
        }
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            dog.HoldPeppers();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            dog.HoldOnion();
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(dog)));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
