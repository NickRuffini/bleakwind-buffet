/*
 * Author: Nick Ruffini
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Entree Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold sirloin");
                }
                else
                {
                    specialInstructions.Remove("Hold sirloin");
                }
                sirloin = value;
            }
        }

        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold onion");
                }
                else
                {
                    specialInstructions.Remove("Hold onion");
                }
                onion = value;
            }
        }

        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold roll");
                }
                else
                {
                    specialInstructions.Remove("Hold roll");
                }
                roll = value;
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
            return "Philly Poacher";
        }
    }
}