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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger rex;
        public CustomizeTRexKingBurger(TRexKingBurger rex)
        {
            InitializeComponent();
            this.rex = rex;
        }
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            rex.HoldBun();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            rex.HoldLettuce();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            rex.HoldTomato();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            rex.HoldOnion();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            rex.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            rex.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            rex.HoldMustard();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            rex.HoldMayo();
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                // NavigationService.GoBack();
                NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(rex)));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
