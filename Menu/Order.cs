/* Order.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Collections.Specialized;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Order Class
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Protected Sales tax rate variable
        /// </summary>
        protected double salesTaxRate = 0;
        List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Items added to the order
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// total price from prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subT = 0;
                foreach (IOrderItem i in Items)
                {
                    subT += i.Price;
                }
                if (subT > 0) { return subT; }
                else { return 0; }
            }
        }
        /// <summary>
        /// sales tax
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
        }
        /// <summary>
        /// amount of sales tax (SalesTaxRate * SubTotalCost)
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// Total Cost of the sale (SubtotalCost + SalesTaxCost)
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
        /// <summary>
        /// an event handler for property changed, notifies when an order property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Constructor for order
        /// </summary>
        public Order()
        {
            
        }
        /// <summary>
        /// Add item to order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }
        /// <summary>
        /// Method for removing item from order
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                item.PropertyChanged += OnPropertyChanged;
                NotifyAllPropertiesChanged();
            }
            return removed;

        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }
        /// <summary>
        /// helper function for INotifyPropertyChanged
        /// </summary>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
        }
    }
}
