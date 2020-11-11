/*
 * Author: Nick Ruffini
 * Class name: Index.cshtml.cs
 * Purpose: C# codebehind for our Index Razor Page
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Generic;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// List of items we are displaying on our index page
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// Holds what terms we previously searched for 
        /// </summary>
        public string searchTerms { get; set; }

        /// <summary>
        /// Holds what types of items (entree, drink, side) we searched for
        /// </summary>
        public string[] typeOfItem { get; set; }

        /// <summary>
        /// Holds what the minimum price we searched for is
        /// </summary>
        public double? priceMin { get; set; }

        /// <summary>
        /// Holds what the maximum price we searched for is
        /// </summary>
        public double? priceMax { get; set; }

        /// <summary>
        /// Holds what the minimum calories we searched for is
        /// </summary>
        public int? calMin { get; set; }

        /// <summary>
        /// Holds what the maximum calories we searched for is
        /// </summary>
        public int? calMax { get; set; }

        public List<string> printed = new List<string>();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] TypeOfItem, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            //Items = Menu.Search(Menu.FullMenu(), SearchTerms);
            Items = Menu.FullMenu();
            if(SearchTerms != null)
            {
                string[] words = SearchTerms.Split(' ');
                List<IOrderItem> finalList = new List<IOrderItem>();

                //Items = from item in Items where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) select item;

                foreach(string word in words)
                {
                    IEnumerable<IOrderItem> temp = from item in Items where item.ToString().Contains(word, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(word, StringComparison.InvariantCultureIgnoreCase) select item;
                    foreach (IOrderItem item in temp)
                    {
                        if (!finalList.Contains(item))
                        {
                            finalList.Add(item);
                        }
                    }
                }
                Items = finalList;
            }

            //Items = Menu.FilterByCategory(Items, TypeOfItem);
            if(TypeOfItem.Count() > 0)
            {
                Items = from item in Items where item.TypeOfItem != null && TypeOfItem.Contains(item.TypeOfItem) select item;
            }

            //Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            if (PriceMin != null && PriceMax == null)
            {
                Items = from item in Items where item.Price >= PriceMin select item;
            }
            else if (PriceMin == null && PriceMax != null)
            {
                Items = from item in Items where item.Price <= PriceMax select item;
            }
            else if (PriceMin != null && PriceMax != null)
            {
                Items = from item in Items where item.Price >= PriceMin && item.Price <= PriceMax select item;
            }

            //Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            if (CalMin != null && CalMax == null)
            {
                Items = from item in Items where item.Calories >= CalMin select item;
            }
            else if (CalMin == null && CalMax != null)
            {
                Items = from item in Items where item.Calories <= CalMax select item;
            }
            else if (CalMin != null && CalMax != null)
            {
                Items = from item in Items where item.Calories >= CalMin && item.Calories <= CalMax select item;
            }

            searchTerms = SearchTerms;
            typeOfItem = TypeOfItem;
            priceMin = PriceMin;
            priceMax = PriceMax;
            calMin = CalMin;
            calMax = CalMax;
        }
    }
}
