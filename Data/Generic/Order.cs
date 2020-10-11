using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.Data.Generic
{
    /// <summary>
    /// Class that represents an Order, which is a collection of order items from the menu!
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// Sales Tax Rate, which is used in calculations throughout the class
        /// </summary>
        private double salesTaxRate = 0.12;
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
            }
        }

        /// <summary>
        /// Holds the sum of all the prices of the order items (without tax)
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (IOrderItem item in this)
                {
                    total += item.Price;
                }
                return Math.Round(total, 2);
            }
        }

        /// <summary>
        /// Holds the amount of tax paid for an order
        /// </summary>
        public double Tax
        {
            get
            {
                double numNotRounded = Subtotal * SalesTaxRate;
                return Math.Round(numNotRounded, 2);
            }
        }

        /// <summary>
        /// Adds the Subtotal and Tax amounts to get the final price
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2);
            }
        }

        /// <summary>
        /// Returns the total amount of calories within the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint totalCalories = 0;
                foreach(IOrderItem item in this)
                {
                    totalCalories += item.Calories;
                }
                return totalCalories;
            }
        }

        /// <summary>
        /// Returns a unique order number for this specific order!
        /// </summary>
        private static int nextOrderNumber = 1;
        public int Number
        {
            get
            {
                return nextOrderNumber;
            }
        }

        /// <summary>
        /// Constructor for a new order!
        /// </summary>
        public Order()
        {
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Event Listener for when our collection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        /// <summary>
        /// Event Listener for when the ITEMS themselves change in our collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
