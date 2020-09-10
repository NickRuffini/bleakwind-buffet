/*
 * Author: Nick Ruffini
 * Class name: IOrderItem.cs
 * Purpose: Interface used to represent all items
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
