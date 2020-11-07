/*
 * Author: Nick Ruffini
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Generic;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests.GenericTests
{
    public class MenuTests
    {
        [Fact]
        public void PopulatesEntreesCorrectly()
        {
            IEnumerable<IOrderItem> test = Menu.Entrees();


            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString())
                );
        }

        [Fact]
        public void PopulatesSidesCorrectly()
        {
            IEnumerable<IOrderItem> test = Menu.Sides();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
                );
        }

        [Fact]
        public void PopulatesDrinksCorrectly()
        {
            IEnumerable<IOrderItem> test = Menu.Drinks();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString())
                );
        }

        [Fact]
        public void PopulatesFullMenuCorrectly()
        {
            IEnumerable<IOrderItem> test = Menu.FullMenu();

            Assert.Collection<IOrderItem>(test,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
                );
        }

        [Fact]
        public void SearchReturnsFullMenuIfSearchTermsNull()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new SailorSoda());
            list.Add(new DragonbornWaffleFries());

            IEnumerable<IOrderItem> result = Menu.Search(list, null);
            List<IOrderItem> test = result.ToList<IOrderItem>();

            List<IOrderItem> test2 = Menu.fullMenu.ToList<IOrderItem>();
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

        [Fact]
        public void SearchEmptyListReturnsEmptyList()
        {
            IEnumerable<IOrderItem> result = Menu.Search(null, "Burger");

            Assert.Null(result);
        }

        [Fact]
        public void FilterByCategoryReturnsNullIfItemsNull()
        {
            List<string> categories = new List<string>();
            categories.Add("Entrees");
            categories.Add("Drinks");

            IEnumerable<IOrderItem> result = Menu.FilterByCategory(null, categories);

            Assert.Null(result);
        }

        [Fact]
        public void FilterByCategoryReturnsItemsIfNoCategories()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new SailorSoda());
            list.Add(new DragonbornWaffleFries());

            IEnumerable<IOrderItem> result = Menu.FilterByCategory(list, null);

            Assert.Equal(list, result);
        }

        [Fact]
        public void FilterByCategoryReturnsCorrectResults()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();

            SailorSoda ss = new SailorSoda();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            list.Add(bb);
            list.Add(ss);
            list.Add(dwf);

            List<string> categories = new List<string>();
            categories.Add("Entrees");

            IEnumerable<IOrderItem> result = Menu.FilterByCategory(list, categories);
            Assert.Contains(bb, result);
            Assert.DoesNotContain(ss, result);
            Assert.DoesNotContain(dwf, result);

            categories.Add("Drinks");
            result = Menu.FilterByCategory(list, categories);
            Assert.Contains(bb, result);
            Assert.Contains(ss, result);
            Assert.DoesNotContain(dwf, result);

            categories.Add("Sides");
            result = Menu.FilterByCategory(list, categories);
            Assert.Contains(bb, result);
            Assert.Contains(ss, result);
            Assert.Contains(dwf, result);
        }

        [Fact]
        public void FilterByCaloriesReturnsNullIfItemsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterByCalories(null, 0, 100);

            Assert.Null(result);

            result = Menu.FilterByCalories(null, null, null);

            Assert.Null(result);

            result = Menu.FilterByCalories(null, 50, null);

            Assert.Null(result);

            result = Menu.FilterByCalories(null, null, 100);

            Assert.Null(result);
        }

        [Fact]
        public void FilterByCaloriesReturnsItemsIfMaxAndMinNull()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new SailorSoda());
            list.Add(new DragonbornWaffleFries());

            IEnumerable<IOrderItem> result = Menu.FilterByCalories(list, null, null);

            Assert.Equal(list, result);
        }

        [Fact]
        public void FilterByCaloriesReturnsCorrectResults()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();

            SailorSoda ss = new SailorSoda();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            list.Add(bb);
            list.Add(ss);
            list.Add(dwf);

            IEnumerable<IOrderItem> result = Menu.FilterByCalories(list, null, 100);
            Assert.Contains(dwf, result);
            Assert.DoesNotContain(bb, result);
            Assert.DoesNotContain(ss, result);

            result = Menu.FilterByCalories(list, 100, 200);
            Assert.Contains(ss, result);
            Assert.DoesNotContain(bb, result);
            Assert.DoesNotContain(dwf, result);

            result = Menu.FilterByCalories(list, 200, null);
            Assert.Contains(bb, result);
            Assert.DoesNotContain(ss, result);
            Assert.DoesNotContain(dwf, result);
        }

        [Fact]
        public void FilterByPriceReturnsNullIfItemsNull()
        {
            IEnumerable<IOrderItem> result = Menu.FilterByPrice(null, 0, 20.00);

            Assert.Null(result);

            result = Menu.FilterByPrice(null, null, null);

            Assert.Null(result);

            result = Menu.FilterByPrice(null, 5.00, null);

            Assert.Null(result);

            result = Menu.FilterByPrice(null, null, 10.00);

            Assert.Null(result);
        }

        [Fact]
        public void FilterByPriceReturnsItemsIfMaxAndMinNull()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new SailorSoda());
            list.Add(new DragonbornWaffleFries());

            IEnumerable<IOrderItem> result = Menu.FilterByCalories(list, null, null);

            Assert.Equal(list, result);
        }

        [Fact]
        public void FilterByPriceReturnsCorrectResults()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();

            SailorSoda ss = new SailorSoda();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            list.Add(bb);
            list.Add(ss);
            list.Add(dwf);

            IEnumerable<IOrderItem> result = Menu.FilterByPrice(list, null, 0.50);
            Assert.Contains(dwf, result);
            Assert.DoesNotContain(bb, result);
            Assert.DoesNotContain(ss, result);

            result = Menu.FilterByPrice(list, 1.40, 3.00);
            Assert.Contains(ss, result);
            Assert.DoesNotContain(bb, result);
            Assert.DoesNotContain(dwf, result);

            result = Menu.FilterByPrice(list, 1.50, null);
            Assert.Contains(bb, result);
            Assert.DoesNotContain(ss, result);
            Assert.DoesNotContain(dwf, result);
        }
    }
}
