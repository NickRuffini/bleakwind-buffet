﻿/*
 * Author: Nick Ruffini
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Side Dragonborn Waffle Fries
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        private double price = 0.42;
        public override double Price
        {
            get { return price; }        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        private uint calories = 77;
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
                    price = 0.42;
                    calories = 77;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else if (value == Size.Medium)
                {
                    price = 0.76;
                    calories = 89;
                    OnPropertyChanged("Size");
                    OnPropertyChanged("Price");
                    OnPropertyChanged("Calories");
                    OnPropertyChanged("Name");
                }
                else
                {
                    price = 0.96;
                    calories = 100;
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
        /// Override method that converts the fries into a string
        /// </summary>
        /// <returns>Size of the fries, followed by the name</returns>
        public override string ToString()
        {
            return String.Format("{0} Dragonborn Waffle Fries", size.ToString());
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Crispy fried potato waffle fries.";
            }
        }
    }
}

