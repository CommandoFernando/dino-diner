﻿/* MainWindow.xaml.cs
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Order();
            OrderList.NavigationService = OrderUI.NavigationService;

        }
        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }
        private void SetFrameDataContext()
        {
            //FrameworkElement content = OrderUI.Content as FrameworkElement;
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
            //content.DataContext = OrderUI.DataContext;
        }
        private void BindDataContextToPage()
        {
            if(OrderUI.Content is FrameworkElement element)
            {
                element.DataContext = OrderUI.DataContext;
            }
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderUI.NavigationService.CanGoBack)
            {
                OrderUI.NavigationService.GoBack();
            }
            else
            {
                OrderUI.NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
