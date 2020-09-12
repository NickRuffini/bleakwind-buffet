/*
 * Author: Nick Ruffini
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Entree Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem
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
                }
                else
                {
                    specialInstructions.Remove("Hold sausage");
                }
                sausageLink = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold egg");
                }
                egg = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold hash browns");
                }
                hashBrowns = value;
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
                }
                else
                {
                    specialInstructions.Remove("Hold pancake");
                }
                pancake = value;
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
    }
}
