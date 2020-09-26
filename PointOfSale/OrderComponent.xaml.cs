/*
 * Author: Nick Ruffini
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Order Component. Oversees the overall Order (2nd level)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Initializes our XAML and starts us off on the Menu Screen
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            containerBorder.Child = new MenuSelectionComponent();
        }

        /// <summary>
        /// Changes what screen we are displaying in our border
        /// </summary>
        /// <param name="obj">Menu Screen/Item Screen we are changing to</param>
        public void SwapScreen(UIElement obj)
        {
            containerBorder.Child = obj;
        }

        /// <summary>
        /// Cancel button event handler that clears out the list of items in the "cart"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.orderList.Items.Clear();
        }
    }
}
