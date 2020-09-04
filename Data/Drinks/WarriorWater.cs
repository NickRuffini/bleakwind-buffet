/*
 * Author: Nick Ruffini
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Drink Warrior Water!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.00;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 0;
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
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
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
        /// Override method that converts the drink into string form
        /// </summary>
        /// <returns>Size of the drink, followed by the name of the drink</returns>
        public override string ToString()
        {
            return String.Format("{0} Warrior Water", size.ToString());
        }
    }
}
