using PointOfSale.ExtensionMethod;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreenComponent.xaml
    /// </summary>
    public partial class PaymentOptionsScreenComponent : UserControl
    {
        public PaymentOptionsScreenComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the user from the Payment Options Screen to the Menu Selection Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            OrderComponent oc = this.FindAncestor<OrderComponent>();
            oc.containerBorder.Child = new MenuSelectionComponent();
        }
    }
}
