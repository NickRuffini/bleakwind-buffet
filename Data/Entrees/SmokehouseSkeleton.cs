/*
 * Author: Nick Ruffini
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Entree Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

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

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
