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
using BleakwindBuffet.Data.Generic;

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

    }
}
