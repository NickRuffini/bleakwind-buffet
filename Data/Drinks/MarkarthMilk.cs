/*
 * Author: Nick Ruffini
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Drink Markarth Milk!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.05;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 56;
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
                    price = 1.05;
                    calories = 56;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else if (value == Size.Medium)
                {
                    price = 1.11;
                    calories = 72;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
                else
                {
                    price = 1.22;
                    calories = 93;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
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
        /// Override method that converts the drink into string form
        /// </summary>
        /// <returns>The size of the drink, followed by the name of the drink</returns>
        public override string ToString()
        {
            return String.Format("{0} Markarth Milk", size.ToString());
        }
    }
}
