/* ComboSelection.xaml.cs
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
using DinoDiner;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo = new CretaceousCombo();
        //private Entree entree;
        //private Side side;
        //private Drink drink;
        //private DinoDiner.Menu.Size size;
        /// <summary>
        /// ComboSelection default construction
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }
        /// <summary>
        /// Changes pages from combo selection
        /// to customize combo page
        /// </summary>
        /// <param name="sender">default sender</param>
        /// <param name="args">default args</param>
        private void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
        private void OnSelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.combo = new CretaceousCombo(new Brontowurst());
                //this.combo.Entree = new Brontowurst();
                order.Add(this.combo);
            }
            NavigationService?.Navigate(new CustomizeBrontowurst(combo.Entree as Brontowurst));

        }
        private void OnSelectDinoNuggetCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(this.combo);
            }
            NavigationService?.Navigate(new CustomizeDinoNuggets(combo.Entree as DinoNuggets));
        }
        private void OnSelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService?.Navigate(new CustomizePBJ(combo.Entree as PrehistoricPBJ));
            }
        }
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
            }
            NavigationService?.Navigate(new CustomizeCombo());
        }
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
            }
            NavigationService?.Navigate(new CustomizeSteakosaurusBurger(combo.Entree as SteakosaurusBurger));
        }
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
            }
            NavigationService?.Navigate(new CustomizeTRexKingBurger(combo.Entree as TRexKingBurger));
        }
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
            }
            NavigationService?.Navigate(new CustomizeVelociWrap(combo.Entree as VelociWrap));
        }
    }
}
