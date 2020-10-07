﻿/*
 * Author: Nick Ruffini
 * Class name: Combo.cs
 * Purpose: Class used to represent a Combo deal
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data.Generic
{
    /// <summary>
    /// Class that represents a combination of a Drink, Side and Entree!
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public double Price
        {
            get { return drink.Price + entree.Price + side.Price; }
        }

        /// <summary>
        /// Gets the calories of the items in the combo
        /// </summary>
        public uint Calories
        {
            get { return drink.Calories + entree.Calories + side.Calories; }
        }

        /// <summary>
        /// Represents the drink in the Combo
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the side
        /// </summary>
        public string DrinkName
        {
            get
            {
                return drink.ToString();
            }
        }

        /// <summary>
        /// Represents the entree in the Combo
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the side
        /// </summary>
        public string EntreeName
        {
            get
            {
                return entree.ToString();
            }
        }

        /// <summary>
        /// Represents the side in the Combo
        /// </summary>
        private Side side;
        public Side Side
        {
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the side
        /// </summary>
        public string SideName
        {
            get
            {
                return side.ToString();
            }
        }

        /// <summary>
        /// List containing instructions in string form regarding the addition of properties
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                list.Add(EntreeName);
                list.AddRange(Entree.SpecialInstructions);
                list.Add(DrinkName);
                list.AddRange(Drink.SpecialInstructions);
                list.Add(SideName);
                list.AddRange(Side.SpecialInstructions);
                return list;
            }
        }
    }
}
