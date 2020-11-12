/*
 * Author: Zachery Brunner
 * Edited By: Nick Ruffini
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal((uint)784, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (includeSirloin)
            {
                Assert.DoesNotContain("Hold sirloin", pp.SpecialInstructions);
                Assert.DoesNotContain("Hold onion", pp.SpecialInstructions);
                Assert.DoesNotContain("Hold roll", pp.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
                Assert.Contains("Hold onion", pp.SpecialInstructions);
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        [Fact]
        public void ChangingSirloinNotifiesSpecialInstructionsProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Sirloin = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesSpecialInstructionsProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Onion = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Onion = false;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesSpecialInstructionsProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Roll = true;
            });
            Assert.PropertyChanged(pp, "SpecialInstructions", () =>
            {
                pp.Roll = false;
            });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(pp);
        }

        [Fact]
        public void DescriptionReturnsCorrectValue()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", pp.Description);
        }
    }
}