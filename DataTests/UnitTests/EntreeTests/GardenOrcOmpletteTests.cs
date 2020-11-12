/*
 * Author: Zachery Brunner
 * Edited By: Nick Ruffini
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(go);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = false;
            Assert.False(go.Broccoli);
            go.Broccoli = true;
            Assert.True(go.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = false;
            Assert.False(go.Tomato);
            go.Tomato = true;
            Assert.True(go.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = false;
            Assert.False(go.Cheddar);
            go.Cheddar = true;
            Assert.True(go.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal((uint)404, go.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Tomato = includeTomato;
            go.Cheddar = includeCheddar;
            if (includeBroccoli)
            {
                Assert.DoesNotContain("Hold broccoli", go.SpecialInstructions);
                Assert.DoesNotContain("Hold mushrooms", go.SpecialInstructions);
                Assert.DoesNotContain("Hold tomato", go.SpecialInstructions);
                Assert.DoesNotContain("Hold cheddar", go.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold broccoli", go.SpecialInstructions);
                Assert.Contains("Hold mushrooms", go.SpecialInstructions);
                Assert.Contains("Hold tomato", go.SpecialInstructions);
                Assert.Contains("Hold cheddar", go.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Broccoli = true;
            });
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = true;
            });
            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Mushrooms = true;
            });
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = true;
            });
            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Tomato = true;
            });
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = true;
            });
            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Cheddar = true;
            });
            Assert.PropertyChanged(go, "SpecialInstructions", () =>
            {
                go.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = true;
            });
            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = false;
            });
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(go);
        }

        [Fact]
        public void DescriptionReturnsCorrectValue()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", goo.Description);
        }
    }
}