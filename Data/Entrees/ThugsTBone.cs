/*
 * Author: Nick Ruffini
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Entree Thugs T-Bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the item
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// Gets the calories of the item
        /// </summary>
        public uint Calories
        {
            get { return 982; }
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
            return "Thugs T-Bone";
        }
    }
}