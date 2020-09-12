/*
 * Author: Nick Ruffini
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Entree Garden Orc Omelette
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem
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
                }
                else
                {
                    specialInstructions.Remove("Hold broccoli");
                }
                broccoli = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold mushrooms");
                }
                mushrooms = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                }
                tomato = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold cheddar");
                }
                cheddar = value;
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

