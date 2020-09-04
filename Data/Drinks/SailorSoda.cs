/*
 * Author: Nick Ruffini
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Drink Sailor's Soda
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.42;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 117;
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
                    price = 1.42;
                    calories = 117;
                }
                else if (value == Size.Medium)
                {
                    price = 1.74;
                    calories = 153;
                }
                else
                {
                    price = 2.07;
                    calories = 205;
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
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
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
            set { flavor = value; }
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
            return String.Format("{0} {1} Sailor Soda", size.ToString(), flavor.ToString());
        }
    }
}
