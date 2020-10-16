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

        OrderComponent oc;
        Order o;

        /// <summary>
        /// Number of $100 bills we have in drawer
        /// </summary>
        private int registerHundredDollars = 0;
        public int RegisterHundredDollars
        {
            get
            {
                return registerHundredDollars;
            }
            set
            {
                registerHundredDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHundredDollars"));
            }
        }

        /// <summary>
        /// Number of $50 bills we have in drawer
        /// </summary>
        private int registerFiftyDollars = 0;
        public int RegisterFiftyDollars
        {
            get
            {
                return registerFiftyDollars;
            }
            set
            {
                registerFiftyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFiftyDollars"));
            }
        }

        /// <summary>
        /// Number of $20 bills we have in drawer
        /// </summary>
        private int registerTwentyDollars = 0;
        public int RegisterTwentyDollars
        {
            get
            {
                return registerTwentyDollars;
            }
            set
            {
                registerTwentyDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwentyDollars"));
            }
        }

        /// <summary>
        /// Number of $100 bills we have in drawer
        /// </summary>
        private int registerTenDollars = 0;
        public int RegisterTenDollars
        {
            get
            {
                return registerTenDollars;
            }
            set
            {
                registerTenDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTenDollars"));
            }
        }

        /// <summary>
        /// Number of $5 bills we have in drawer
        /// </summary>
        private int registerFiveDollars = 0;
        public int RegisterFiveDollars
        {
            get
            {
                return registerFiveDollars;
            }
            set
            {
                registerFiveDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterFiveDollars"));
            }
        }

        /// <summary>
        /// Number of $2 bills we have in drawer
        /// </summary>
        private int registerTwoDollars = 0;
        public int RegisterTwoDollars
        {
            get
            {
                return registerTwoDollars;
            }
            set
            {
                registerTwoDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterTwoDollars"));
            }
        }

        /// <summary>
        /// Number of $1 bills we have in drawer
        /// </summary>
        private int registerOneDollars = 0;
        public int RegisterOneDollars
        {
            get
            {
                return registerOneDollars;
            }
            set
            {
                registerOneDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterOneDollars"));
            }
        }

        /// <summary>
        /// Number of $1 coins we have in drawer
        /// </summary>
        private int registerOneDollarCoin = 0;
        public int RegisterOneDollarCoin
        {
            get
            {
                return registerOneDollarCoin;
            }
            set
            {
                registerOneDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterOneDollarCoin"));
            }
        }

        /// <summary>
        /// Number of $0.50 coins we have in drawer
        /// </summary>
        private int registerHalfDollarCoin = 0;
        public int RegisterHalfDollarCoin
        {
            get
            {
                return registerHalfDollarCoin;
            }
            set
            {
                registerHalfDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterHalfDollarCoin"));
            }
        }

        /// <summary>
        /// Number of quarters we have in drawer
        /// </summary>
        private int registerQuarters = 0;
        public int RegisterQuarters
        {
            get
            {
                return registerQuarters;
            }
            set
            {
                registerQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterQuarters"));
            }
        }

        /// <summary>
        /// Number of dimes we have in drawer
        /// </summary>
        private int registerDimes = 0;
        public int RegisterDimes
        {
            get
            {
                return registerDimes;
            }
            set
            {
                registerDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterDimes"));
            }
        }

        /// <summary>
        /// Number of nickels we have in drawer
        /// </summary>
        private int registerNickels = 0;
        public int RegisterNickels
        {
            get
            {
                return registerNickels;
            }
            set
            {
                registerNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterNickels"));
            }
        }

        /// <summary>
        /// Number of pennies we have in drawer
        /// </summary>
        private int registerPennies = 0;
        public int RegisterPennies
        {
            get
            {
                return registerPennies;
            }
            set
            {
                registerPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RegisterPennies"));
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

        public double AmountDue
        {
            get
            {
                return Math.Round(TotalCost - GivenAmount, 2);
            }
        }

        public RegisterViewModel(double totalCost)
        {
            TotalCost = totalCost;
        }
    }
}
