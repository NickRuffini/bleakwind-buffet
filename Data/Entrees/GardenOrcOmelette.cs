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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold broccoli");
                    OnPropertyChanged("SpecialInstructions");
                }
                broccoli = value;

                OnPropertyChanged("Broccoli");
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold mushrooms");
                    OnPropertyChanged("SpecialInstructions");
                }
                mushrooms = value;

                OnPropertyChanged("Mushrooms");
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                    OnPropertyChanged("SpecialInstructions");
                }
                tomato = value;

                OnPropertyChanged("Tomato");
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
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold cheddar");
                    OnPropertyChanged("SpecialInstructions");
                }
                cheddar = value;

                OnPropertyChanged("Cheddar");
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

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            }
        }
    }
}

