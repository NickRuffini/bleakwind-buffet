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


        public CurrencyControl()
        {
            InitializeComponent();
        }
    }
}
