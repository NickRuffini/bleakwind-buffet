/*
 * Author: Nick Ruffini
 * Class name: SideTests.cs
 * Purpose: Testing class for the Side
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class SideTests
    {
        [Fact]
        public void NameReturnsCorrectString()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal("Small Vokun Salad", vs.Name);

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Equal("Small Dragonborn Waffle Fries", dwf.Name);

            FriedMiraak fm = new FriedMiraak();
            Assert.Equal("Small Fried Miraak", fm.Name);
        }

        [Fact]
        public void TypeOfItemReturnsCorrectValue()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Equal("Sides", dwf.TypeOfItem);

            FriedMiraak fm = new FriedMiraak();
            Assert.Equal("Sides", fm.TypeOfItem);
        }
    }
}
