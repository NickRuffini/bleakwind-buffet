using BleakwindBuffet.Data.Generic;
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

        /// <summary>
        /// Button click handler for customer paying with a card!
        /// If there are no errors with the payment, prints out receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardButton_Click(object sender, RoutedEventArgs e)
        {
            OrderComponent oc = this.FindAncestor<OrderComponent>();
            RoundRegister.CardTransactionResult swipeResult;
            if (oc.DataContext is Order o)
            {
                swipeResult = RoundRegister.CardReader.RunCard(o.Total);
                switch (swipeResult)
                {
                    case RoundRegister.CardTransactionResult.Approved:
                        MessageBox.Show("Card Approved");

                        // Print order receipt
                        oc.printReceipt("Card");

                        oc.orderList.Items.Clear();
                        oc.containerBorder.Child = new MenuSelectionComponent();
                        oc.DataContext = new Order();
                        break;
                    case RoundRegister.CardTransactionResult.Declined:
                        MessageBox.Show("Card Declined");
                        break;
                    case RoundRegister.CardTransactionResult.IncorrectPin:
                        MessageBox.Show("Incorrect Pin");
                        break;
                    case RoundRegister.CardTransactionResult.InsufficientFunds:
                        MessageBox.Show("Insufficient Funds");
                        break;
                    case RoundRegister.CardTransactionResult.ReadError:
                        MessageBox.Show("Read Error");
                        break;
                }
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            OrderComponent oc = this.FindAncestor<OrderComponent>();
            if (oc.DataContext is Order o)
            {
                oc.containerBorder.Child = new CashPaymentComponent(new RegisterViewModel(o.Total));
            }
        }
    }
}
