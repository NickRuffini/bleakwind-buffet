﻿/*
 * Author: Nick Ruffini
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Drink Sailor's Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.42;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 117;
        public override uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Represents the size of the drink
        /// </summary>
        private Size size = Size.Small;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    price = 1.42;
                    calories = 117;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else if (value == Size.Medium)
                {
                    price = 1.74;
                    calories = 153;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else
                {
                    price = 2.07;
                    calories = 205;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Represents ice in the drink
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                if (value == false)
                {
                    specialInstructions.Add("Hold ice");
                    OnPropertyChanged("Ice");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                    OnPropertyChanged("Ice");
                    OnPropertyChanged("SpecialInstructions");
                }
            }
        }

        /// <summary>
        /// Represents the flavor of the drink!
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set 
            { 
                flavor = value;
                OnPropertyChanged("Flavor");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// List containing instructions in string form regarding the addition of properties
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        /// <summary>
        /// Override method that converts the drink into string form
        /// </summary>
        /// <returns>The size of the drink, followed by the flavor of the drink, followed by the name of the drink</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} Sailor Soda", size.ToString(), flavor.ToString());
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }
    }
}
