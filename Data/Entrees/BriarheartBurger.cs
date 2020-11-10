/*
 * Author: Nick Ruffini
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Entree Briarheart Burger
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public override double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public override uint Calories
        {
            get { return 732; }
        }

        /// <summary>
        /// Represents ketchup on the burger!
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
        /// Represents the bun of the burger!
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
        /// Represents the mustard on the burger
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
                pickle= value;
                
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
        /// Override method that converts the burger into string form
        /// </summary>
        /// <returns>The name of the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }
    }
}
