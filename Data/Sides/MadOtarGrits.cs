/*
 * Author: Nick Ruffini
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Side Mad Otar Grits
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class MadOtarGrits
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.22;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 105;
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
                    price = 1.22;
                    calories = 105;
                }
                else if (value == Size.Medium)
                {
                    price = 1.58;
                    calories = 142;
                }
                else
                {
                    price = 1.93;
                    calories = 179;
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
            return String.Format("{0} Mad Otar Grits", size.ToString());
        }
    }
}

