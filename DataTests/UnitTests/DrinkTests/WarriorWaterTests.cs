/*
 * Author: Nick Ruffini
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldHaveCorrectPriceForSize(Size size)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(0.00, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (ww.Ice == true)
            {
                if (ww.Lemon == true)
                {
                    Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
                    Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
                }
            }
            else
            {
                if (ww.Lemon == true)
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                    Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
                }
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesSpecialInstructionsProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ChangingSizeNotifiesNameProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Name", () =>
            {
                ww.Size = Size.Large;
            });
        }

    }
}
