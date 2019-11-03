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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets nuggs;
        public CustomizeDinoNuggets(DinoNuggets nuggs)
        {
            InitializeComponent();
            this.nuggs = nuggs;
        }
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nuggs.AddNugget();
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                //NavigationService.GoBack();
                NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(nuggs)));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
