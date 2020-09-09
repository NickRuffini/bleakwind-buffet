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
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
        }

        /// <summary>
        /// Represents the sirloin in the sandwich
        /// </summary>
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

        /// <summary>
        /// Represents onion in the sandwich
        /// </summary>
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

        /// <summary>
        /// Represents the roll of the sandwich
        /// </summary>
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
        /// Override method that converts the sandwich into a string
        /// </summary>
        /// <returns>The name of the sandwich</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}