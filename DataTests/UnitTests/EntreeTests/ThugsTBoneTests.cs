﻿/*
 * Author: Zachery Brunner
 * Edited By: Nick Ruffini
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAOrderItem()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal(6.44, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal((uint)982, tt.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tt.ToString());
        }

        [Fact]
        public void IsOfTypeINotifyPropertyChanged()
        {
            ThugsTBone tt = new ThugsTBone();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(tt);
        }

        [Fact]
        public void DescriptionReturnsCorrectValue()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", ttb.Description);
        }
    }
}