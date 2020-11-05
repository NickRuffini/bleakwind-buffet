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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Generic;
using System.Linq;

namespace BleakwindBuffet.Data.Generic
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
            List<IOrderItem> drinkList = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = size;
                drinkList.Add(aj);

                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = size;
                drinkList.Add(cc);

                CandlehearthCoffee ccd = new CandlehearthCoffee();
                ccd.Size = size;
                ccd.Decaf = true;
                drinkList.Add(ccd);

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = size;
                drinkList.Add(mm);

                WarriorWater ww = new WarriorWater();
                ww.Size = size;
                drinkList.Add(ww);

                foreach (SodaFlavor sodaFlavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = sodaFlavor;
                    drinkList.Add(ss);
                }
            }

            return drinkList;
        }

        /// <summary>
        /// Populates a list with all the available items at Bleakwind Buffet!
        /// </summary>
        /// <returns> An enumerable containing an instance of all available items </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            IEnumerable<IOrderItem> drinks = Drinks();
            IEnumerable<IOrderItem> entrees = Entrees();
            IEnumerable<IOrderItem> sides = Sides();

            IEnumerable<IOrderItem> list1 = drinks.Concat(entrees);
            IEnumerable<IOrderItem> list2 = list1.Concat(sides);

            return list2;
        }

        /// <summary>
        /// Searches all the items for matches!
        /// </summary>
        /// <param name="Items"> Items we are searching through </param>
        /// <param name="SearchTerms"> What term we are looking for </param>
        /// <returns> IEnumerable of the values we get back from this search </returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> Items, string SearchTerms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (SearchTerms == null)
            {
                return FullMenu();
            }

            foreach(IOrderItem item in Items)
            {
                if(item.ToString() != null && item.ToString().ToLower().Contains(SearchTerms.ToLower()))
                {
                    if (item is SailorSoda soda)
                    {
                        if (soda.Size == Size.Small)
                        {
                            if ("Small Sailor Soda".Contains(SearchTerms))
                            {
                                results.Add(item);
                            }
                        }
                        else if (soda.Size == Size.Medium)
                        {
                            if ("Medium Sailor Soda".Contains(SearchTerms))
                            {
                                results.Add(item);
                            }
                        }
                        else
                        {
                            if ("Large Sailor Soda".Contains(SearchTerms))
                            {
                                results.Add(item);
                            }
                        }
                    }
                    else
                    {
                        results.Add(item);
                    }
                    
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the items by category (entree, drink or side)
        /// </summary>
        /// <param name="Items"> Items we are searching through </param>
        /// <param name="categories"> What categories we are including (entree, drink or side) </param>
        /// <returns> IEnumerable of the values we get back from this filter </returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> Items, IEnumerable<string> categories)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (categories == null || categories.Count() == 0)
            {
                return Items;
            }

            foreach (IOrderItem item in Items)
            {
                if(item is Entree && categories.Contains("Entrees"))
                {
                    results.Add(item);
                }
                if (item is Side && categories.Contains("Sides"))
                {
                    results.Add(item);
                }
                if (item is Drink && categories.Contains("Drinks"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the items by calorie amounts
        /// </summary>
        /// <param name="Items"> Items we are searching through </param>
        /// <param name="min"> Floor of the calorie amount </param>
        /// <param name="max"> Ceiling of the calorie amount </param>
        /// <returns> IEnumerable of the values we get back from this filter </returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> Items, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null)
            {
                return Items;
            }

            if (min == null)
            {
                foreach (IOrderItem item in Items)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in Items)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in Items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the items by price
        /// </summary>
        /// <param name="Items"> Items we are searching through </param>
        /// <param name="min"> Floor of the price </param>
        /// <param name="max"> Ceiling of the price </param>
        /// <returns> IEnumerable of the values we get back from this filter </returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> Items, double? min, double? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null)
            {
                return Items;
            }

            if (min == null)
            {
                foreach (IOrderItem item in Items)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in Items)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in Items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
