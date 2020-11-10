/*
 * Author: Nick Ruffini
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Drink Aretino Apple Juice!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.62;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 44;
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
                    price = 0.62;
                    calories = 44;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                    /*
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));*/
                }
                else if (value == Size.Medium)
                {
                    price = 0.87;
                    calories = 88;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                    
                }
                else
                {
                    price = 1.01;
                    calories = 132;
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
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                if (value == true)
                {
                    specialInstructions.Add("Add ice");
                    OnPropertyChanged("Ice");
                    OnPropertyChanged("SpecialInstructions");

                }
                else
                {
                    specialInstructions.Remove("Add ice");
                    OnPropertyChanged("Ice");
                    OnPropertyChanged("SpecialInstructions");
                }
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
        /// Override method that converts the drink into proper string form
        /// </summary>
        /// <returns>The size of the drink folowed by the name of the drink</returns>
        public override string ToString()
        {
            return String.Format("{0} Aretino Apple Juice", size.ToString());
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fresh squeezed apple juice.";
            }
        }
    }
}
