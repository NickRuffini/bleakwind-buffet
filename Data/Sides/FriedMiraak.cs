/*
 * Author: Nick Ruffini
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Side Fried Miraak
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 1.78;
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 151;
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
                    price = 1.78;
                    calories = 151;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else if (value == Size.Medium)
                {
                    price = 2.01;
                    calories = 236;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else
                {
                    price = 2.88;
                    calories = 306;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
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
        /// Override method that converts the side into a string
        /// </summary>
        /// <returns>The size of the side, followed by the name of the side</returns>
        public override string ToString()
        {
            return String.Format("{0} Fried Miraak", size.ToString());
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Perfectly prepared hash brown pancakes.";
            }
        }
    }
}
