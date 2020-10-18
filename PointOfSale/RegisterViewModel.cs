/*
 * Author: Nick Ruffini
 * Class name: RegisterViewModel.cs
 * Purpose: Class that serves as the view model between the RoundRegister dll and our GUI
 */

using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Generic;
using PointOfSale.ExtensionMethod;
using System.Windows.Media;

namespace PointOfSale
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Number of $100 bills we have in drawer
        /// </summary>
        public int RegisterHundredDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Hundreds;
            }
        }

        /// <summary>
        /// Number of $50 bills we have in drawer
        /// </summary>
        public int RegisterFiftyDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Fifties;
            }
        }

        /// <summary>
        /// Number of $20 bills we have in drawer
        /// </summary>
        public int RegisterTwentyDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Twenties;
            }
        }

        /// <summary>
        /// Number of $100 bills we have in drawer
        /// </summary>
        public int RegisterTenDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Tens;
            }
        }

        /// <summary>
        /// Number of $5 bills we have in drawer
        /// </summary>
        public int RegisterFiveDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Fives;
            }
        }

        /// <summary>
        /// Number of $2 bills we have in drawer
        /// </summary>
        public int RegisterTwoDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Twos;
            }
        }

        /// <summary>
        /// Number of $1 bills we have in drawer
        /// </summary>
        public int RegisterOneDollars
        {
            get
            {
                return RoundRegister.CashDrawer.Ones;
            }
        }

        /// <summary>
        /// Number of $1 coins we have in drawer
        /// </summary>
        public int RegisterOneDollarCoin
        {
            get
            {
                return RoundRegister.CashDrawer.Dollars;
            }
        }

        /// <summary>
        /// Number of $0.50 coins we have in drawer
        /// </summary>
        public int RegisterHalfDollarCoin
        {
            get
            {
                return RoundRegister.CashDrawer.HalfDollars;
            }
        }

        /// <summary>
        /// Number of quarters we have in drawer
        /// </summary>
        public int RegisterQuarters
        {
            get
            {
                return RoundRegister.CashDrawer.Quarters;
            }
        }

        /// <summary>
        /// Number of dimes we have in drawer
        /// </summary>
        public int RegisterDimes
        {
            get
            {
                return RoundRegister.CashDrawer.Dimes;
            }
        }

        /// <summary>
        /// Number of nickels we have in drawer
        /// </summary>
        public int RegisterNickels
        {
            get
            {
                return RoundRegister.CashDrawer.Nickels;
            }
        }

        /// <summary>
        /// Number of pennies we have in drawer
        /// </summary>
        public int RegisterPennies
        {
            get
            {
                return RoundRegister.CashDrawer.Pennies;
            }
        }

        /// <summary>
        /// Number of $100 bills we have are receiving from customer
        /// </summary>
        private int customerHundredDollars = 0;
        public int CustomerHundredDollars
        {
            get
            {
                return customerHundredDollars;
            }
            set
            {
                customerHundredDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundredDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $50 bills we are receiving from customer
        /// </summary>
        private int customerFiftyDollars = 0;
        public int CustomerFiftyDollars
        {
            get
            {
                return customerFiftyDollars;
            }
            set
            {
                customerFiftyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFiftyDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $20 bills we are receiving from customer
        /// </summary>
        private int customerTwentyDollars = 0;
        public int CustomerTwentyDollars
        {
            get
            {
                return customerTwentyDollars;
            }
            set
            {
                customerTwentyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwentyDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $10 bills we are receiving from customer
        /// </summary>
        private int customerTenDollars = 0;
        public int CustomerTenDollars
        {
            get
            {
                return customerTenDollars;
            }
            set
            {
                customerTenDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTenDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $5 bills we are receiving from customer
        /// </summary>
        private int customerFiveDollars = 0;
        public int CustomerFiveDollars
        {
            get
            {
                return customerFiveDollars;
            }
            set
            {
                customerFiveDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFiveDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $2 bills we are receiving from customer
        /// </summary>
        private int customerTwoDollars = 0;
        public int CustomerTwoDollars
        {
            get
            {
                return customerTwoDollars;
            }
            set
            {
                customerTwoDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwoDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $1 bills we are receiving from customer
        /// </summary>
        private int customerOneDollars = 0;
        public int CustomerOneDollars
        {
            get
            {
                return customerOneDollars;
            }
            set
            {
                customerOneDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOneDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $1 coins we are receiving from customer
        /// </summary>
        private int customerOneDollarCoin = 0;
        public int CustomerOneDollarCoin
        {
            get
            {
                return customerOneDollarCoin;
            }
            set
            {
                customerOneDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOneDollarCoin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $0.50 coins we are receiving from customer
        /// </summary>
        private int customerHalfDollarCoin = 0;
        public int CustomerHalfDollarCoin
        {
            get
            {
                return customerHalfDollarCoin;
            }
            set
            {
                customerHalfDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollarCoin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of quarters we are receiving from customer
        /// </summary>
        private int customerQuarters = 0;
        public int CustomerQuarters
        {
            get
            {
                return customerQuarters;
            }
            set
            {
                customerQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of dimes we are receiving from customer
        /// </summary>
        private int customerDimes = 0;
        public int CustomerDimes
        {
            get
            {
                return customerDimes;
            }
            set
            {
                customerDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of nickels we are receiving from customer
        /// </summary>
        private int customerNickels = 0;
        public int CustomerNickels
        {
            get
            {
                return customerNickels;
            }
            set
            {
                customerNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of pennies we are receiving from customer
        /// </summary>
        private int customerPennies = 0;
        public int CustomerPennies
        {
            get
            {
                return customerPennies;
            }
            set
            {
                customerPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenAmount"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDueTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));

                CalculateChange();
            }
        }

        /// <summary>
        /// Number of $100 bills we owe customer
        /// </summary>
        private int owedHundredDollars = 0;
        public int OwedHundredDollars
        {
            get
            {
                return owedHundredDollars;
            }
            set
            {
                owedHundredDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedHundredDollars"));
            }
        }

        /// <summary>
        /// Number of $50 bills we owe customer
        /// </summary>
        private int owedFiftyDollars = 0;
        public int OwedFiftyDollars
        {
            get
            {
                return owedFiftyDollars;
            }
            set
            {
                owedFiftyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedFiftyDollars"));
            }
        }

        /// <summary>
        /// Number of $20 bills we owe customer
        /// </summary>
        private int owedTwentyDollars = 0;
        public int OwedTwentyDollars
        {
            get
            {
                return owedTwentyDollars;
            }
            set
            {
                owedTwentyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedTwentyDollars"));
            }
        }

        /// <summary>
        /// Number of $10 bills we owe customer
        /// </summary>
        private int owedTenDollars = 0;
        public int OwedTenDollars
        {
            get
            {
                return owedTenDollars;
            }
            set
            {
                owedTenDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedTenDollars"));
            }
        }

        /// <summary>
        /// Number of $5 bills we owe customer
        /// </summary>
        private int owedFiveDollars = 0;
        public int OwedFiveDollars
        {
            get
            {
                return owedFiveDollars;
            }
            set
            {
                owedFiveDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedFiveDollars"));
            }
        }

        /// <summary>
        /// Number of $2 bills we owe customer
        /// </summary>
        private int owedTwoDollars = 0;
        public int OwedTwoDollars
        {
            get
            {
                return owedTwoDollars;
            }
            set
            {
                owedTwoDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedTwoDollars"));
            }
        }

        /// <summary>
        /// Number of $1 bills we owe customer
        /// </summary>
        private int owedOneDollars = 0;
        public int OwedOneDollars
        {
            get
            {
                return owedOneDollars;
            }
            set
            {
                owedOneDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedOneDollars"));
            }
        }

        /// <summary>
        /// Number of $1 coins we owe customer
        /// </summary>
        private int owedOneDollarCoin = 0;
        public int OwedOneDollarCoin
        {
            get
            {
                return owedOneDollarCoin;
            }
            set
            {
                owedOneDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedOneDollarCoin"));
            }
        }

        /// <summary>
        /// Number of $0.50 coins we owe customer
        /// </summary>
        private int owedHalfDollarCoin = 0;
        public int OwedHalfDollarCoin
        {
            get
            {
                return owedHalfDollarCoin;
            }
            set
            {
                owedHalfDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedHalfDollarCoin"));
            }
        }

        /// <summary>
        /// Number of quarters we owe customer
        /// </summary>
        private int owedQuarters = 0;
        public int OwedQuarters
        {
            get
            {
                return owedQuarters;
            }
            set
            {
                owedQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedQuarters"));
            }
        }

        /// <summary>
        /// Number of dimes we owe customer
        /// </summary>
        private int owedDimes = 0;
        public int OwedDimes
        {
            get
            {
                return owedDimes;
            }
            set
            {
                owedDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedDimes"));
            }
        }

        /// <summary>
        /// Number of nickels we owe customer
        /// </summary>
        private int owedNickels = 0;
        public int OwedNickels
        {
            get
            {
                return owedNickels;
            }
            set
            {
                owedNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedNickels"));
            }
        }

        /// <summary>
        /// Number of pennies we owe customer
        /// </summary>
        private int owedPennies = 0;
        public int OwedPennies
        {
            get
            {
                return owedPennies;
            }
            set
            {
                owedPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OwedPennies"));
            }
        }

        /// <summary>
        /// Holds the total cost of the order
        /// </summary>
        private double totalCost;
        public double TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                totalCost = value;
            }
        }

        /// <summary>
        /// Holds the the amount we have been given by the customer
        /// </summary>
        public double GivenAmount
        {
            get
            {
                return Math.Round(CustomerHundredDollars * 100 + CustomerFiftyDollars * 50 + CustomerTwentyDollars * 20 + CustomerTenDollars * 10 + CustomerFiveDollars * 5 + CustomerTwoDollars * 2 + CustomerOneDollars * 1 + CustomerOneDollarCoin * 1 + CustomerHalfDollarCoin * 0.5 + CustomerQuarters * 0.25 + CustomerDimes * 0.10 + CustomerNickels * 0.05 + CustomerPennies * 0.01, 2);
            }
        }

        /// <summary>
        /// Amount due that is dipslayed; doesn't go below 0!
        /// </summary>
        public double AmountDueTotal
        {
            get
            {
                if (AmountDue < 0)
                {
                    return 0;
                }
                else
                {
                    return Math.Round(TotalCost - GivenAmount, 2);
                }
            }
        }

        /// <summary>
        /// Amount due that isn't displayed; goes below 0 so we can see how much change we owe the customer
        /// </summary>
        public double AmountDue
        {
            get
            {
                return TotalCost - GivenAmount;
            }
        }

        /// <summary>
        /// Keeps track of how much change we owe the customer
        /// </summary>
        public double ChangeDue
        {
            get
            {
                if (AmountDue < 0)
                {
                    return Math.Round(AmountDue * -1, 2);
                }
                else
                {
                    return 0;
                }

            }
        }

        public RegisterViewModel(double totalCost)
        {
            TotalCost = totalCost;
        }

        /// <summary>
        /// Calculates the type of each coin/dollar we need to return in change!
        /// </summary>
        public void CalculateChange()
        {
            double change = ChangeDue;

            OwedHundredDollars = (int)(change / 100);
            change = change % 100;

            OwedFiftyDollars = (int)(change / 50);
            change = change % 50;

            OwedTwentyDollars = (int)(change / 20);
            change = change % 20;

            OwedTenDollars = (int)(change / 10);
            change = change % 10;

            OwedFiveDollars = (int)(change / 5);
            change = change % 5;

            OwedTwoDollars = (int)(change / 2);
            change = change % 2;

            OwedOneDollars = (int)(change / 1);
            change = change % 1;

            OwedOneDollarCoin = (int)(change / 1);
            change = change % 1;

            OwedHalfDollarCoin = (int)(change / 0.5);
            change = change % 0.5;

            OwedQuarters = (int)(change / 0.25);
            change = change % 0.25;

            OwedDimes = (int)(change / 0.1);
            change = change % 0.1;

            OwedNickels = (int)(change / 0.05);
            change = change % 0.05;
            
            OwedPennies = (int)(change / 0.01);
        }

        /// <summary>
        /// Opens the drawer, adds the money we receive from customer, deducts money we give as change
        /// </summary>
        public void FinalizeOrder()
        {
            CashDrawer.OpenDrawer();

            CashDrawer.Hundreds += CustomerHundredDollars;
            CashDrawer.Fifties += CustomerFiftyDollars;
            CashDrawer.Twenties += CustomerTwentyDollars;
            CashDrawer.Tens += CustomerTenDollars;
            CashDrawer.Fives += CustomerFiveDollars;
            CashDrawer.Twos += CustomerTwoDollars;
            CashDrawer.Ones += CustomerOneDollars;
            CashDrawer.Dollars += CustomerOneDollarCoin;
            CashDrawer.HalfDollars += CustomerHalfDollarCoin;
            CashDrawer.Quarters += CustomerQuarters;
            CashDrawer.Dimes += CustomerDimes;
            CashDrawer.Nickels += CustomerNickels;
            CashDrawer.Pennies += CustomerPennies;

            CashDrawer.Hundreds -= OwedHundredDollars;
            CashDrawer.Fifties -= OwedFiftyDollars;
            CashDrawer.Twenties -= OwedTwentyDollars;
            CashDrawer.Tens -= OwedTenDollars;
            CashDrawer.Fives -= OwedFiveDollars;
            CashDrawer.Twos -= OwedTwoDollars;
            CashDrawer.Ones -= OwedOneDollars;
            CashDrawer.Dollars -= OwedOneDollarCoin;
            CashDrawer.HalfDollars -= OwedHalfDollarCoin;
            CashDrawer.Quarters -= OwedQuarters;
            CashDrawer.Dimes -= OwedDimes;
            CashDrawer.Nickels -= OwedNickels;
            CashDrawer.Pennies -= OwedPennies;
        }
    }
}
