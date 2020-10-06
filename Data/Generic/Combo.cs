/*
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
        private double price = 0.00;
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the items in the combo
        /// </summary>
        private uint calories = 0;
        public uint Calories
        {
            get { return calories; }
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
                // If a drink already exists, we need to subtract it's calories and price before adding new drink
                if (drink != null)
                {
                    price -= drink.Price;
                    calories -= drink.Calories;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    specialInstructions.Remove(drink.ToString());
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    foreach (string var in drink.SpecialInstructions)
                    {
                        specialInstructions.Remove(var);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    }
                }
                // Set the drink value equal to the new drink
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                // Add on the new drink's calories and price
                price += drink.Price;
                calories += drink.Calories;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                // Add the name of the drink to the special instructions
                specialInstructions.Add(drink.ToString());
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                // Adds the special instructions of the drink after the name!
                foreach (string var in drink.SpecialInstructions)
                {
                    specialInstructions.Add(var);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                // If a entree already exists, we need to subtract it's calories and price before adding new entree
                if (entree != null)
                {
                    price -= entree.Price;
                    calories -= entree.Calories;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    specialInstructions.Remove(entree.ToString());
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    foreach (string var in entree.SpecialInstructions)
                    {
                        specialInstructions.Remove(var);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    }
                }
                // Set the entree value equal to the new entree
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                // Add on the new entree's calories and price
                price += entree.Price;
                calories += entree.Calories;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                // Add the name of the entree to the special instructions
                specialInstructions.Add(entree.ToString());
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                // Adds the special instructions of the entree after the name!
                foreach (string var in entree.SpecialInstructions)
                {
                    specialInstructions.Add(var);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
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
                // If a entree already exists, we need to subtract it's calories and price before adding new entree
                if (side != null)
                {
                    price -= side.Price;
                    calories -= side.Calories;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    specialInstructions.Remove(side.ToString());
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    foreach (string var in side.SpecialInstructions)
                    {
                        specialInstructions.Remove(var);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    }
                }
                // Set the entree value equal to the new entree
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                // Add on the new entree's calories and price
                price += side.Price;
                calories += side.Calories;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                // Add the name of the entree to the special instructions
                specialInstructions.Add(side.ToString());
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                // Adds the special instructions of the entree after the name!
                foreach (string var in side.SpecialInstructions)
                {
                    specialInstructions.Add(var);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
    }
}
