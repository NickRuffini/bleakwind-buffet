/*
 * Author: Nick Ruffini
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Entree Thalmor Triple
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
        }

        /// <summary>
        /// Represents ketchup in the burger
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold ketchup");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold ketchup");
                    OnPropertyChanged("SpecialInstructions");
                }
                ketchup = value;

                OnPropertyChanged("Ketchup");
            }
        }

        /// <summary>
        /// Represents the bun of the burger
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold bun");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold bun");
                    OnPropertyChanged("SpecialInstructions");
                }
                bun = value;

                OnPropertyChanged("Bun");
            }
        }

        /// <summary>
        /// Represents the mustard of the burger
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mustard");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold mustard");
                    OnPropertyChanged("SpecialInstructions");
                }
                mustard = value;

                OnPropertyChanged("Mustard");
            }
        }

        /// <summary>
        /// Represents the pickles on the burger
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold pickle");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold pickle");
                    OnPropertyChanged("SpecialInstructions");
                }
                pickle = value;

                OnPropertyChanged("Pickle");
            }
        }

        /// <summary>
        /// Represents the cheese on the burger
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold cheese");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold cheese");
                    OnPropertyChanged("SpecialInstructions");
                }
                cheese = value;

                OnPropertyChanged("Cheese");
            }
        }

        /// <summary>
        /// Represents the tomato on the burger
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
        /// Represents the lettuce on the burger
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold lettuce");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold lettuce");
                    OnPropertyChanged("SpecialInstructions");
                }
                lettuce = value;

                OnPropertyChanged("Lettuce");
            }
        }

        /// <summary>
        /// Represents the mayo on the burger
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold mayo");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold mayo");
                    OnPropertyChanged("SpecialInstructions");
                }
                mayo = value;

                OnPropertyChanged("Mayo");
            }
        }

        /// <summary>
        /// Represents the bacon on the burger
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold bacon");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold bacon");
                    OnPropertyChanged("SpecialInstructions");
                }
                bacon = value;

                OnPropertyChanged("Bacon");
            }
        }

        /// <summary>
        /// Represents egg on the burger
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold egg");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold egg");
                    OnPropertyChanged("SpecialInstructions");
                }
                egg = value;

                OnPropertyChanged("Egg");
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
        /// Override method that converts the burger into a string
        /// </summary>
        /// <returns>Name of the burger</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
