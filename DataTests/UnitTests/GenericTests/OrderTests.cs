using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Generic;
using BleakwindBuffet.Data.Enums;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests.GenericTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAObservableCollection()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(o);
        }

        [Fact]
        public void OrderIsEmptyByDefault()
        {
            Order o = new Order();
            Assert.Empty(o);
        }

        [Fact]
        public void CanAddToOrder()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Collection<IOrderItem>(o,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString())
            );
        }

        [Fact]
        public void CanRemoveFromOrder()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Collection<IOrderItem>(o,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString())
            );

            o.Remove(aj);
            o.Remove(bb);
            o.Remove(dwf);

            Assert.Empty(o);
        }

        [Fact]
        public void SalesTaxRateIsSetByDefault()
        {
            Order o = new Order();
            Assert.Equal(0.12, o.SalesTaxRate);
        }

        [Fact]
        public void SalesTaxRateCanBeSet()
        {
            Order o = new Order();
            Assert.Equal(0.12, o.SalesTaxRate);

            o.SalesTaxRate = 0.15;
            Assert.Equal(0.15, o.SalesTaxRate);
        }

        [Fact]
        public void ChangingSalesTaxRateNotifiesSalesTaxRateProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "SalesTaxRate", () =>
            {
                o.SalesTaxRate = 0.15;
            });
        }

        [Fact]
        public void SubtotalReturnsCorrectValue()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Equal(7.36, o.Subtotal);
        }

        [Fact]
        public void TaxReturnsCorrectValue()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Equal(7.36 * 0.12, o.Tax);
        }

        [Fact]
        public void TotalReturnsCorrectValue()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Equal(7.36 + (7.36*0.12), o.Total);
        }

        [Fact]
        public void CaloriesReturnsCorrectValue()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();

            o.Add(aj);
            o.Add(bb);
            o.Add(dwf);

            Assert.Equal((uint)853, o.Calories);
        }

        [Fact]
        public void OrderNumberUpdatesCorrectly()
        {
            Order o = new Order();
            Assert.Equal(2, o.Number);

            Order o2 = new Order();
            Assert.Equal(3, o2.Number);

            Order o3 = new Order();
            Assert.Equal(4, o3.Number);
        }

        [Fact]
        public void AddingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(new AretinoAppleJuice());
            });
        }

        [Fact]
        public void AddingItemNotifiesTaxProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(new AretinoAppleJuice());
            });
        }

        [Fact]
        public void AddingItemNotifiesTotalProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(new AretinoAppleJuice());
            });
        }

        [Fact]
        public void AddingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();

            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(new AretinoAppleJuice());
            });
        }

        [Fact]
        public void RemovingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            o.Add(aj);

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Remove(aj);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTaxProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            o.Add(aj);

            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Remove(aj);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTotalProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            o.Add(aj);

            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Remove(aj);
            });
        }

        [Fact]
        public void RemovingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();
            o.Add(aj);

            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Remove(aj);
            });
        }

        [Fact]
        public void ChangingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();

            o.Add(aj);

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                aj.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingItemNotifiesTaxProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();

            o.Add(aj);

            Assert.PropertyChanged(o, "Tax", () =>
            {
                aj.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingItemNotifiesTotalProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();

            o.Add(aj);

            Assert.PropertyChanged(o, "Total", () =>
            {
                aj.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();

            AretinoAppleJuice aj = new AretinoAppleJuice();

            o.Add(aj);

            Assert.PropertyChanged(o, "Calories", () =>
            {
                aj.Size = Size.Medium;
            });
        }


    }
}
