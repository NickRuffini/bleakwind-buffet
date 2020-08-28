/*
 * Author: Nick Ruffini
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Side Fried Miraak
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class FriedMiraak
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.78;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 151;
        public uint Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        /// <summary>
        /// Represents the size of the side
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
                    price = 1.78;
                    calories = 151;
                }
                else if (value == Size.Medium)
                {
                    price = 2.01;
                    calories = 236;
                }
                else
                {
                    price = 2.88;
                    calories = 306;
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
            return String.Format("{0} Fried Miraak", size.ToString());
        }
    }
}
