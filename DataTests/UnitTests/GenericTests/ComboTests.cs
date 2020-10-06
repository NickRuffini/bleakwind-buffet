using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Generic;

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
        public void CaloriesAreZeroByDefault()
        {
            Combo c = new Combo();
            Assert.Equal((uint)0, c.Calories);
        }

        [Fact]
        public void PriceIsZeroByDefault()
        {
            Combo c = new Combo();
            Assert.Equal(0, c.Price);
        }

        [Fact]
        public void SpecialInstructionsAreEmptyByDefault()
        {
            Combo c = new Combo();
            Assert.Empty(c.SpecialInstructions);
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
        public void ShouldAddCorrectCaloriesForDrink()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Equal((uint)44, c.Calories);
        }

        [Fact]
        public void ChangingDrinkCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Equal((uint)44, c.Calories);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            c.Drink = cc;
            Assert.Equal((uint)7, c.Calories);
        }

        [Fact]
        public void ShouldAddCorrectPriceForDrink()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Equal(0.62, c.Price);
        }

        [Fact]
        public void ChangingDrinkCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Equal(0.62, c.Price);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            c.Drink = cc;
            Assert.Equal(0.75, c.Price);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SettingDrinkUpdatesSpecialInstructions(bool includeIce)
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            c.Drink = aj;

            if (includeIce == true)
            {
                Assert.Contains("Add ice", c.SpecialInstructions);
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);
            }
        }

        [Fact]
        public void ChangingDrinkUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            Assert.Contains("Small Aretino Apple Juice", c.SpecialInstructions);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            c.Drink = cc;
            Assert.Contains("Small Candlehearth Coffee", c.SpecialInstructions);
            Assert.DoesNotContain("Small Aretino Apple Juice", c.SpecialInstructions);
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
        public void ShouldAddCorrectCaloriesForEntree()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;
            Assert.Equal((uint)732, c.Calories);
        }

        [Fact]
        public void ChangingEntreeCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;
            Assert.Equal((uint)732, c.Calories);

            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            Assert.Equal((uint)843, c.Calories);
        }

        [Fact]
        public void ShouldAddCorrectPriceForEntree()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;
            Assert.Equal(6.32, c.Price);
        }

        [Fact]
        public void ChangingEntreeCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;
            Assert.Equal(6.32, c.Price);

            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            Assert.Equal(7.32, c.Price);
        }

        [Fact]
        public void SettingEntreeUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            c.Entree = bb;

            Assert.Contains("Hold ketchup", c.SpecialInstructions);
            Assert.Contains("Briarheart Burger", c.SpecialInstructions);
        }

        [Fact]
        public void ChangingEntreeUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            c.Entree = bb;

            Assert.Contains("Hold ketchup", c.SpecialInstructions);
            Assert.Contains("Briarheart Burger", c.SpecialInstructions);

            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            Assert.Contains("Double Draugr", c.SpecialInstructions);
            Assert.DoesNotContain("Briarheart Burger", c.SpecialInstructions);
            Assert.DoesNotContain("Hold ketchup", c.SpecialInstructions);
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
        public void ShouldAddCorrectCaloriesForSide()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;
            Assert.Equal((uint)77, c.Calories);
        }

        [Fact]
        public void ChangingSideCorrectlyUpdatesCalories()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;
            Assert.Equal((uint)77, c.Calories);

            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;
            Assert.Equal((uint)151, c.Calories);
        }

        [Fact]
        public void ShouldAddCorrectPriceForSide()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;
            Assert.Equal(0.42, c.Price);
        }

        [Fact]
        public void ChangingSideCorrectlyUpdatesPrice()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;
            Assert.Equal(0.42, c.Price);

            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;
            Assert.Equal(1.78, c.Price);
        }

        [Fact]
        public void SettingSideUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            c.Side = dwf;

            Assert.Contains("Small Dragonborn Waffle Fries", c.SpecialInstructions);
        }

        [Fact]
        public void ChangingSideUpdatesSpecialInstructions()
        {
            Combo c = new Combo();

            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = Data.Enums.Size.Medium;
            c.Side = dwf;

            Assert.Contains("Medium Dragonborn Waffle Fries", c.SpecialInstructions);

            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;
            Assert.Contains("Small Fried Miraak", c.SpecialInstructions);
            Assert.DoesNotContain("Medium Dragonborn Waffle Fries", c.SpecialInstructions);
        }
    }
}
