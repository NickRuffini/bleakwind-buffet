/*
 * Author: Nick Ruffini
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Side Vokun Salad
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.93;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 41;
        public override uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Represents the size of the side
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
        public override List<string> SpecialInstructions
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
