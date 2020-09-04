/*
 * Author: Nick Ruffini
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Side Vokun Salad
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.93;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 41;
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
                    price = 0.93;
                    calories = 41;
                }
                else if (value == Size.Medium)
                {
                    price = 1.28;
                    calories = 52;
                }
                else
                {
                    price = 1.82;
                    calories = 73;
                }
            }
        }

        /// <summary>
        /// List containing instructions in string form regarding the addition of properties
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        /// <summary>
        /// Override method that converts the salad into a string
        /// </summary>
        /// <returns>Name of the salad</returns>
        public override string ToString()
        {
            return String.Format("{0} Vokun Salad", size.ToString());
        }
    }
}
