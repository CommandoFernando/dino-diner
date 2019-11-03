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
using DinoDiner;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        //private Entree entree;
        //private Side side;
        //private Drink drink;
        private CretaceousCombo combo;
        private DinoDiner.Menu.Size size;
        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// Changes page from Customize combo to
        /// Flavor selection
        /// </summary>
        /// <param name="sender">Default</param>
        /// <param name="args">Default</param>
        private void OnSelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }
        private void OnCustomizeEntree(object sender, RoutedEventArgs args)
        {
            if(combo.Entree is Brontowurst)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(combo.Entree as Brontowurst));
            }
            if (combo.Entree is DinoNuggets)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(combo.Entree as DinoNuggets));
            }
            if (combo.Entree is PrehistoricPBJ)
            {
                NavigationService.Navigate(new CustomizePBJ(combo.Entree as PrehistoricPBJ));
            }
            if (combo.Entree is PterodactylWings)
            {
            
            }
            if (combo.Entree is SteakosaurusBurger)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo.Entree as SteakosaurusBurger));
            }
            if (combo.Entree is TRexKingBurger)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(combo.Entree as TRexKingBurger));
            }
            if (combo.Entree is VelociWrap)
            {
                NavigationService.Navigate(new CustomizeVelociWrap(combo.Entree as VelociWrap));
            }
        }
        private void OnSelectSmall()
        {
            combo.Size = DinoDiner.Menu.Size.Small;
        }
        private void OnSelectMedium()
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
        }
        private void OnSelectLarge()
        {
            combo.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
