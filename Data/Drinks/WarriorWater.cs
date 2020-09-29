/*
 * Author: Nick Ruffini
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Drink Warrior Water!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.00;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 0;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
            }
        }

        /// <summary>
        /// Represents lemon in the drink
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                if (value == true)
                {
                    specialInstructions.Add("Add lemon");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                }
                else
                {
                    specialInstructions.Remove("Add lemon");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
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
        /// <returns>Size of the drink, followed by the name of the drink</returns>
        public override string ToString()
        {
            return String.Format("{0} Warrior Water", size.ToString());
        }
    }
}
