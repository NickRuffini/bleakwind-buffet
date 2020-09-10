/*
 * Author: Nick Ruffini
 * Class name: Menu.cs
 * Purpose: Static class used to represent the menu at Bleakwind Buffet!
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Populates a list with all the available entrees at Bleakwind Buffet!
        /// </summary>
        /// <returns> An enumerable containing an instance of all available entrees </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            entreeList.Add(new BriarheartBurger());
            entreeList.Add(new DoubleDraugr());
            entreeList.Add(new GardenOrcOmelette());
            entreeList.Add(new PhillyPoacher());
            entreeList.Add(new SmokehouseSkeleton());
            entreeList.Add(new ThalmorTriple());
            entreeList.Add(new ThugsTBone());

            return entreeList;
        }

        /// <summary>
        /// Populates a list with all the available sides at Bleakwind Buffet!
        /// </summary>
        /// <returns> An enumerable containing an instance of all available sides </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = size;
                sideList.Add(dwf);

                FriedMiraak fm = new FriedMiraak();
                fm.Size = size;
                sideList.Add(fm);

                MadOtarGrits mog = new MadOtarGrits();
                mog.Size = size;
                sideList.Add(mog);

                VokunSalad vs = new VokunSalad();
                vs.Size = size;
                sideList.Add(vs);
            }

            return sideList;
        }

        /// <summary>
        /// Populates a list with all the available drinks at Bleakwind Buffet!
        /// </summary>
        /// <returns> An enumerable containing an instance of all available drinks </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {

        }
    }
}
