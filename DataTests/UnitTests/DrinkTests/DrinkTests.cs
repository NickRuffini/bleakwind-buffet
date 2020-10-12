/*
 * Author: Nick Ruffini
 * Class name: DrinkTests.cs
 * Purpose: Testing class for the Drink
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class DrinkTests
    {
        [Fact]
        public void NameReturnsCorrectString()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal("Small Aretino Apple Juice", aj.Name);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal("Small Candlehearth Coffee", cc.Name);

            WarriorWater ww = new WarriorWater();
            Assert.Equal("Small Warrior Water", ww.Name);
        }
    }
}
