/*
 * Author: Nick Ruffini
 * Class name: Entree.cs
 * Purpose: Abstract class used to represent all entrees
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Returns the toString of the item
        /// </summary>
        public string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the drink
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Returns what type of item it is in string form
        /// </summary>
        public string TypeOfItem
        {
            get
            {
                return "Entrees";
            }
        }
    }
}
