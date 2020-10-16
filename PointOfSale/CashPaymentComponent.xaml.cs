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

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            OrderComponent oc = this.FindAncestor<OrderComponent>();
            oc.containerBorder.Child = new MenuSelectionComponent();
        }
    }
}
