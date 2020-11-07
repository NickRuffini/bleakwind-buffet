/*
 * Author: Nick Ruffini
 * Class: MenuSearchFilterTests.cs
 * Purpose: Test the Menu Search and Filter functionality on our index page!
 */

using System;
using Xunit;
using BleakwindBuffet.Data.Generic;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Linq;

namespace WebsiteTests
{
    public class MenuSearchFilterTests
    {
        [Fact]
        public void SearchReturnsFullMenuIfSearchTermsNull()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new SailorSoda());
            list.Add(new DragonbornWaffleFries());

            IEnumerable<IOrderItem> result = Menu.Search(list, null);
            List<IOrderItem> test = result.ToList<IOrderItem>();

            List<IOrderItem> test2 = Menu.FullMenu().ToList<IOrderItem>();
            //IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();

            Assert.Equal(test, test2);

            //Assert.True(result.Equals(fullMenu));
        }

        [Fact]
        public void SearchReturnsCorrectResults()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();

            SailorSoda ss = new SailorSoda();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            list.Add(bb);
            list.Add(ss);
            list.Add(dwf);

            IEnumerable<IOrderItem> result = Menu.Search(list, "Burger");
            Assert.Contains(bb, result);

            result = Menu.Search(list, "Soda");
            Assert.Contains(ss, result);

            result = Menu.Search(list, "Waffle");
            Assert.Contains(dwf, result);
        }

        [Fact]
        public void SearchForSodaReturnsCorrectResults()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            SailorSoda ss = new SailorSoda();
            ss.Size = BleakwindBuffet.Data.Enums.Size.Medium;

            list.Add(ss);

            IEnumerable<IOrderItem> result = Menu.Search(list, "Soda");
            Assert.Contains(ss, result);

            list.Remove(ss);

            ss.Size = BleakwindBuffet.Data.Enums.Size.Large;
            list.Add(ss);

            result = Menu.Search(list, "Soda");
            Assert.Contains(ss, result);
        }
    }
}
