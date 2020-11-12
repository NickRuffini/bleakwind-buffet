/*
 * Author: Zachery Brunner
 * Edited By: Nick Ruffini
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (cc.Ice == true)
            {
                if (cc.RoomForCream == true)
                {
                    Assert.Contains("Add ice", cc.SpecialInstructions);
                    Assert.Contains("Add cream", cc.SpecialInstructions);
                }
                else
                {
                    Assert.Contains("Add ice", cc.SpecialInstructions);
                    Assert.DoesNotContain("Add cream", cc.SpecialInstructions);
                }
            }
            else
            {
                if (cc.RoomForCream == true)
                {
                    Assert.DoesNotContain("Add ice", cc.SpecialInstructions);
                    Assert.Contains("Add cream", cc.SpecialInstructions);
                }
                else
                {
                    Assert.DoesNotContain("Add ice", cc.SpecialInstructions);
                    Assert.DoesNotContain("Add cream", cc.SpecialInstructions);
                }
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = decaf;
            cc.Size = size;
            Assert.Equal(name, cc.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = true;
            });
            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCaloriesProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = false;
            });
            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = true;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Decaf", () =>
            {
                cc.Decaf = false;
            });
            Assert.PropertyChanged(cc, "Decaf", () =>
            {
                cc.Decaf = true;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.Ice = true;
            });
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.Ice = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesSpecialInstructionsProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.RoomForCream = true;
            });
            Assert.PropertyChanged(cc, "SpecialInstructions", () =>
            {
                cc.RoomForCream = false;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(cc);
        }

        [Fact]
        public void ChangingSizeNotifiesNameProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Small;
            });
            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesNameProperty()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Decaf = true;
            });
            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Decaf = false;
            });
        }

        [Fact]
        public void DescriptionReturnsCorrectValue()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", cc.Description);
        }
    }
}
