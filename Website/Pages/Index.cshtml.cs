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

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] TypeOfItem, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            Items = Menu.Search(Menu.FullMenu(), SearchTerms);
        }
    }
}
