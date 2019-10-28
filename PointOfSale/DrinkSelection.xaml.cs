﻿/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Backing field for Drink
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor overload that takes a drink parameter
        /// </summary>
        /// <param name="drink">the selected drink</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }
        /// <summary>
        /// Method for done button
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">defauult</param>
        public void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Method for adding jurassic java
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new JurassicJava());
            }
        }
        /// <summary>
        /// Method for adding sodasaurus
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Sodasaurus());
            }
        }
        /// <summary>
        /// Method for adding tyrannotea
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Tyrannotea());
            }
        }
        /// <summary>
        /// Method for adding water
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="args">default</param>
        public void AddWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }
    }
}
