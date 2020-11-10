/*
 * Author: Nick Ruffini
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Entree Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }

        /// <summary>
        /// Represents sausage in the meal
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold sausage");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold sausage");
                    OnPropertyChanged("SpecialInstructions");
                }
                sausageLink = value;

                OnPropertyChanged("SausageLink");
            }
        }

        /// <summary>
        /// Represents egg in the meal
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
        /// Represents hash browns in the meal
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold hash browns");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold hash browns");
                    OnPropertyChanged("SpecialInstructions");
                }
                hashBrowns = value;

                OnPropertyChanged("HashBrowns");
            }
        }

        /// <summary>
        /// Represents pancakes in the meal
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold pancake");
                    OnPropertyChanged("SpecialInstructions");
                }
                else
                {
                    specialInstructions.Remove("Hold pancake");
                    OnPropertyChanged("SpecialInstructions");
                }
                pancake = value;

                OnPropertyChanged("Pancake");
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
        /// Override method that converts the meal into a string
        /// </summary>
        /// <returns>Name of the meal</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

        /// <summary>
        /// Returns the string value of the item's description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
    }
}
