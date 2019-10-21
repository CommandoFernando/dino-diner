/* Order.cs
 * Author: Fernando Velarde
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Order Class
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Items added to the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
                return items;
            }
            set
            {
                ObservableCollection<IOrderItem> item = new ObservableCollection<IOrderItem>();
                item = value;
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
        public double SalesTaxRate { get; protected set; }
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
    }
}
