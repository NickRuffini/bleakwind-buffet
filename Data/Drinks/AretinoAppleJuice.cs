/*
 * Author: Nick Ruffini
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent the Drink Aretino Apple Juice!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.62;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 44;
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        /// <summary>
        /// Represents the size of the drink
        /// </summary>
        private Size size = Size.Small;
        public Size Size
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
                }
                else if (value == Size.Medium)
                {
                    price = 0.87;
                    calories = 88;
                }
                else
                {
                    price = 1.01;
                    calories = 132;
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
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
            }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} Aretino Apple Juice", size.ToString());
        }
    }
}
