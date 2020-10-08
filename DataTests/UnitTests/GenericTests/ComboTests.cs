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

            Assert.Equal(7.36, c.Price);
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

            Assert.Equal(7.36, c.Price);

            c.Drink.Size = Data.Enums.Size.Medium;

            Assert.Equal(7.61, c.Price);
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
        public void ChangingDrinkNotifiesSideNameProperty()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SideName", () =>
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

            Assert.Equal(7.36, c.Price);

            PhillyPoacher pp = new PhillyPoacher();
            c.Entree = pp;

            Assert.Equal(8.27, c.Price, 2);
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
        public void ChangingEntreeNotifiesSideNameProperty()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Combo c = new Combo();

            Assert.PropertyChanged(c, "SideName", () =>
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

            Assert.Equal(7.36, c.Price);

            c.Side.Size = Data.Enums.Size.Medium;

            Assert.Equal(7.70, c.Price);
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
    }
}
