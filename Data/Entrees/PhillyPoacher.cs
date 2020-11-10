/*
 * Author: Nick Ruffini
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Entree Philly Poacher
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold sirloin");
                    OnPropertyChanged("SpecialInstructions");
                }
                sirloin = value;

                OnPropertyChanged("Sirloin");
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold onion");
                    OnPropertyChanged("SpecialInstructions");
                }
                onion = value;

                OnPropertyChanged("Onion");
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold roll");
                    OnPropertyChanged("SpecialInstructions");
                }
                roll = value;

                OnPropertyChanged("Roll");
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

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
            }
        }
    }
}