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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        /// <summary>
        /// Property for adjusting the Text Box that this Currency Control Represents (100 dollars, 50 cents, etc.)
        /// </summary>
        public static DependencyProperty MoneyAmountProperty = DependencyProperty.Register("MoneyAmount", typeof(string), typeof(CurrencyControl));
        public string MoneyAmount
        {
            get
            {
                return (string)GetValue(MoneyAmountProperty);
            }
            set
            {
                SetValue(MoneyAmountProperty, value);
            }
        }

        /// <summary>
        /// Property for adjusting the value in the Text Box that represents how much of a type of currency we have received
        /// </summary>
        public static DependencyProperty AmountFromCustomerProperty = DependencyProperty.Register("AmountFromCustomer", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public int AmountFromCustomer
        {
            get
            {
                return (int)GetValue(AmountFromCustomerProperty);
            }
            set
            {
                SetValue(AmountFromCustomerProperty, value);
            }
        }

        /// <summary>
        /// Property for adjusting the value in the Text Box that represents how much of a type of currency we have received
        /// </summary>
        public static DependencyProperty AmountToGiveBackProperty = DependencyProperty.Register("AmountToGiveBack", typeof(int), typeof(CurrencyControl));
        public int AmountToGiveBack
        {
            get
            {
                return (int)GetValue(AmountToGiveBackProperty);
            }
            set
            {
                SetValue(AmountToGiveBackProperty, value);
            }
        }


        public CurrencyControl()
        {
            InitializeComponent();
            AmountFromCustomer = 0;
            AmountToGiveBack = 0;
        }

        /// <summary>
        /// Add button handler that increments how much we have received of this currency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AmountFromCustomer++;
            e.Handled = true;
        }

        /// <summary>
        /// Subtract button handler that decrements how much we have received of this currency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            if (AmountFromCustomer > 0)
            {
                AmountFromCustomer--;
            }
            
            e.Handled = true;
        }
    }
}
