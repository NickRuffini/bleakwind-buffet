using System;
using System.Collections.Generic;
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
using BleakwindBuffet.Data.Generic;
using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentComponent.xaml
    /// </summary>
    public partial class CashPaymentComponent : UserControl
    {
        public CashPaymentComponent(RegisterViewModel rvm)
        {
            InitializeComponent();

            this.DataContext = rvm;
        }

        /// <summary>
        /// Handler for clicking the return button, which brings you back to the menu selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            OrderComponent oc = this.FindAncestor<OrderComponent>();
            oc.containerBorder.Child = new MenuSelectionComponent();
        }

        /// <summary>
        /// Handler for clicking the finalize button, which finalizes the sale and creates a new order!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finalizeSaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is RegisterViewModel rvm)
            {
                rvm.FinalizeOrder();

                OrderComponent oc = this.FindAncestor<OrderComponent>();

                oc.orderList.Items.Clear();
                oc.DataContext = new Order();
                oc.containerBorder.Child = new MenuSelectionComponent();
            }
        }
    }
}
