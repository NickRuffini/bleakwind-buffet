/*
 * Author: Nick Ruffini
 * Class name: EntreeTests.cs
 * Purpose: Testing class for the Entree
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class EntreeTests
    {
        [Fact]
        public void NameReturnsCorrectString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.Name);

            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.Name);

            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.Name);
        }

        [Fact]
        public void TypeOfItemReturnsCorrectValue()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Entrees", bb.TypeOfItem);

            GardenOrcOmelette gom = new GardenOrcOmelette();
            Assert.Equal("Entrees", gom.TypeOfItem);
        }
    }
}
