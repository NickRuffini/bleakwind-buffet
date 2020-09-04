/*
 * Author: Nick Ruffini
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent the Drink Candlehearth Coffee!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.75;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 7;
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
                    price = 0.75;
                    calories = 7;
                }
                else if (value == Size.Medium)
                {
                    price = 1.25;
                    calories = 10;
                }
                else
                {
                    price = 1.75;
                    calories = 20;
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

        /// <summary>
        /// Represents cream in the drink
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                if (value == true)
                {
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
                }
            }
        }

        /// <summary>
        /// Represents whether or not the coffee is decaf
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
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
            if (decaf == false)
            {
                return String.Format("{0} Candlehearth Coffee", size.ToString());
            }
            else
            {
                return String.Format("{0} Decaf Candlehearth Coffee", size.ToString());
            }
        }
    }
}
