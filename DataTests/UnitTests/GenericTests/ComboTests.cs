using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Generic;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.GenericTests
{
    public class ComboTests
    {
        [Fact]
        public void DrinkIsNullByDefault()
        {
            Combo c = new Combo();
            Assert.Null(c.Drink);
        }

        [Fact]
        public void CanAssignDrink()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Equal(aj, c.Drink);
        }

        [Fact]
        public void ShouldAddCorrectCaloriesForCombo()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal((uint)853, c.Calories);
        }

        [Fact]
        public void ChangingDrinkCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal((uint)853, c.Calories);

            c.Drink.Size = Data.Enums.Size.Medium;

            Assert.Equal((uint)897, c.Calories);
        }

        [Fact]
        public void ShouldAddCorrectPriceForCombo()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal(7.36 - 1, c.Price);
        }

        [Fact]
        public void ChangingDrinkCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal(7.36 - 1, c.Price);

            c.Drink.Size = Data.Enums.Size.Medium;

            Assert.Equal(7.61 - 1, c.Price);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SettingComboUpdatesSpecialInstructions(bool includeIce)
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            if (includeIce == true)
            {
                Assert.Contains("Add ice", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
                Assert.Contains("Briarheart Burger", c.SpecialInstructions);
                Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);
                Assert.DoesNotContain("Add ice", c.SpecialInstructions);
            }
        }

        [Fact]
        public void ChangingDrinkUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            c.Drink = cc;
            Assert.Contains("Small Candlehearth Coffee", c.SpecialInstructions);
            Assert.DoesNotContain("Small Aretino Apple Juice", c.SpecialInstructions);
        }

        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = aj;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesCaloriesProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = aj;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesPriceProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Drink = aj;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesDrinkNameProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "DrinkName", () =>
            {
                c.Drink = aj;
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesSpecialInstructionsProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = aj;
            });
        }
        // ---------------------------------------------------------------------------------------------------

        [Fact]
        public void EntreeIsNullByDefault()
        {
            Combo c = new Combo();
            Assert.Null(c.Entree);
        }

        [Fact]
        public void CanAssignEntree()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;
            Assert.Equal(bb, c.Entree);
        }

        [Fact]
        public void ChangingEntreeCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal((uint)853, c.Calories);

            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;

            Assert.Equal((uint)964, c.Calories);
        }

        [Fact]
        public void ChangingEntreeCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal(7.36 - 1, c.Price);

            PhillyPoacher pp = new PhillyPoacher();
            c.Entree = pp;

            Assert.Equal(8.27 - 1, c.Price, 2);
        }

        [Fact]
        public void ChangingEntreeUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            Assert.Contains("Briarheart Burger", c.SpecialInstructions);
            Assert.Contains("Hold ketchup", c.SpecialInstructions);

            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            Assert.Contains("Double Draugr", c.SpecialInstructions);
            Assert.DoesNotContain("Briarheart Burger", c.SpecialInstructions);
            Assert.DoesNotContain("Hold ketchup", c.SpecialInstructions);
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesCaloriesProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesPriceProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeNameProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "EntreeName", () =>
            {
                c.Entree = bb;
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesSpecialInstructionsProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Entree = bb;
            });
        }

        // -------------------------------------------------------------------------------------------------------------

        [Fact]
        public void SideIsNullByDefault()
        {
            Combo c = new Combo();
            Assert.Null(c.Side);
        }

        [Fact]
        public void CanAssignSide()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;
            Assert.Equal(dwf, c.Side);
        }

        [Fact]
        public void ChangingSideCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal((uint)853, c.Calories);

            c.Side.Size = Data.Enums.Size.Medium;

            Assert.Equal((uint)865, c.Calories);
        }

        [Fact]
        public void ChangingSideCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Equal(7.36 - 1, c.Price);

            c.Side.Size = Data.Enums.Size.Medium;

            Assert.Equal(7.70 - 1, c.Price);
        }

        [Fact]
        public void ChangingSideUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            c.Entree = bb;

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);

            c.Side.Size = Data.Enums.Size.Medium;

            Assert.Contains("Medium Dragonborn Waffle Fries", c.SpecialInstructions);
            Assert.DoesNotContain("Small Dragonborn Waffle Fries", c.SpecialInstructions);
        }

        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = dwf;
            });
        }

        [Fact]
        public void ChangingSideNotifiesCaloriesProperty()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = dwf;
            });
        }

        [Fact]
        public void ChangingSideNotifiesPriceProperty()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = dwf;
            });
        }

        [Fact]
        public void ChangingSideNotifiesSideNameProperty()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SideName", () =>
            {
                c.Side = dwf;
            });
        }

        [Fact]
        public void ChangingSideNotifiesSpecialInstructionsProperty()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = dwf;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ChangingItemPropertyInComboNotifiesChange()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();

            Assert.PropertyChanged(c, "DrinkName", () =>
            {
                c.Drink.Size = Size.Medium;
            });

            c.Drink = new CandlehearthCoffee();

            if (c.Drink is CandlehearthCoffee cc)
            {
                Assert.PropertyChanged(c, "DrinkName", () =>
                {
                    cc.Decaf = true;
                });
            }

            c.Drink = new SailorSoda();

            if (c.Drink is SailorSoda ss)
            {
                Assert.PropertyChanged(c, "DrinkName", () =>
                {
                    ss.Flavor = SodaFlavor.Blackberry;
                });
            }

            if (c.Drink is SailorSoda ss2)
            {
                Assert.PropertyChanged(c, "SpecialInstructions", () =>
                {
                    ss2.Ice = false;
                });
            }

            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "SideName", () =>
            {
                c.Side.Size = Size.Medium;
            });
        }

        [Fact]
        public void DescriptionReturnsCorrectValue()
        {
            Combo c = new Combo();
            Assert.Equal("It's a Combo, folks!", c.Description);
        }

        [Fact]
        public void TypeOfItemReturnsCorrectValue()
        {
            Combo c = new Combo();
            Assert.Equal("Combos", c.TypeOfItem);
        }
    }
}
