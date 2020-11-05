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

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] TypeOfItem, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            Items = Menu.Search(Menu.FullMenu(), SearchTerms);
            Items = Menu.FilterByCategory(Items, TypeOfItem);
            Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);

            searchTerms = SearchTerms;
            typeOfItem = TypeOfItem;
            priceMin = PriceMin;
            priceMax = PriceMax;
            calMin = CalMin;
            calMax = CalMax;
        }
    }
}
