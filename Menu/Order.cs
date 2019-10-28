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
        /// <summary>
        /// Items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; } //= new ObservableCollection<IOrderItem>();
        
        /// <summary>
        /// total price from prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subT = 0;
                foreach(IOrderItem i in Items)
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
        /// an event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Constructor for order
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
        }
        /// <summary>
        /// Add item to order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }
    }
}
