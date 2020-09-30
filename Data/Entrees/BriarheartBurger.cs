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
        public event PropertyChangedEventHandler PropertyChanged;

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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold ketchup");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold bun");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold mustard");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold pickle");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                pickle= value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                else
                {
                    specialInstructions.Remove("Hold cheese");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
    }
}
