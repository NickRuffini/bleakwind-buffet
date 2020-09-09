/*
 * Author: Nick Ruffini
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Side Mad Otar Grits
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.22;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 105;
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
        /// Override method converts the grits into a string
        /// </summary>
        /// <returns>Size of the grits, followed by the name of the grits</returns>
        public override string ToString()
        {
            return String.Format("{0} Mad Otar Grits", size.ToString());
        }
    }
}

