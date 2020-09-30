/*
 * Author: Nick Ruffini
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Entree Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public override double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public override uint Calories
        {
            get { return 404; }
        }

        /// <summary>
        /// Represents the broccoli in the omelette
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold broccoli");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold broccoli");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }

        /// <summary>
        /// Represents mushrooms in the omelette
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mushrooms");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold mushrooms");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }

        /// <summary>
        /// Represents tomato in the omelette
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold tomato");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// Represents cheddar in the omelette
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold cheddar");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold cheddar");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
        /// Override method that converts the omelette into string form
        /// </summary>
        /// <returns>The name of the omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

