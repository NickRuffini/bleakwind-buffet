/*
 * Author: Zachery Brunner
 * Edited By: Nick Ruffini
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);

        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((uint)943, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;
            if (includeBun)
            {
                Assert.DoesNotContain("Hold bun", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold ketchup", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold mustard", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold pickle", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold cheese", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold tomato", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold lettuce", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold mayo", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold bacon", tt.SpecialInstructions);
                Assert.DoesNotContain("Hold egg", tt.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
                Assert.Contains("Hold egg", tt.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });
            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });
            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });
            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });
            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });
            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });
            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });
            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });
            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });
            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesSpecialInstructionsProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = true;
            });
            Assert.PropertyChanged(tt, "SpecialInstructions", () =>
            {
                tt.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });
            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(tt);
        }
    }
}