/*
 * Author: Nick Ruffini
 * Class name: ExtensionMethod.xaml.cs
 * Purpose: Class used to store helper methods that are useful for the program flow!
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.ExtensionMethod;
using PointOfSale.Entrees;
using PointOfSale.Drinks;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.Sides;
using BleakwindBuffet.Data.Generic;

namespace PointOfSale.ExtensionMethod
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// Finds the control passed to the function
        /// </summary>
        /// <typeparam name="T">Some control</typeparam>
        /// <param name="element"></param>
        /// <returns>The control we were looking for when found</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent == null)
            {
                return null;
            }
            if (parent is T)
            {
                return parent as T;
            }
            return parent.FindAncestor<T>();
        }
        /// <summary>
        /// Switches the screen from the current User Control to another by going up to the OrderComponent level!
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="sender">Button Pressed</param>
        public static void SwitchScreen(this DependencyObject elem, object sender)
        {
            if (sender is Button)
            {
                FrameworkElement switchToScreen;
                var orderControl = elem.FindAncestor<OrderComponent>();

                switch (((Button)sender).Name)
                {
                    case "briarheartBurgerButton":
                        switchToScreen = new BriarheartBurgerComponent(new BleakwindBuffet.Data.Entrees.BriarheartBurger());
                        break;
                    case "returnButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    case "addButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    case "editButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    case "doubleDraugrButton":
                        switchToScreen = new DoubleDraugrComponent(new BleakwindBuffet.Data.Entrees.DoubleDraugr());
                        break;
                    case "thalmorTripleButton":
                        switchToScreen = new ThalmorTripleComponent(new BleakwindBuffet.Data.Entrees.ThalmorTriple());
                        break;
                    case "smokehouseSkeletonButton":
                        switchToScreen = new SmokehouseSkeletonComponent(new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton());
                        break;
                    case "gardenOrcOmeletteButton":
                        switchToScreen = new GardenOrcOmeletteComponent(new BleakwindBuffet.Data.Entrees.GardenOrcOmelette());
                        break;
                    case "phillyPoacherButton":
                        switchToScreen = new PhillyPoacherComponent(new BleakwindBuffet.Data.Entrees.PhillyPoacher());
                        break;
                    case "thugsTBoneButton":
                        switchToScreen = new ThugsTBoneComponent(new BleakwindBuffet.Data.Entrees.ThugsTBone());
                        break;
                    case "sailorSodaButton":
                        switchToScreen = new SailorSodaComponent(new SailorSoda());
                        break;
                    case "markarthMilkButton":
                        switchToScreen = new MarkarthMilkComponent(new MarkarthMilk());
                        break;
                    case "aretinoAppleJuiceButton":
                        switchToScreen = new AretinoAppleJuiceComponent(new AretinoAppleJuice());
                        break;
                    case "candlehearthCoffeeButton":
                        switchToScreen = new CandlehearthCoffeeComponent(new CandlehearthCoffee());
                        break;
                    case "warriorWaterButton":
                        switchToScreen = new WarriorWaterComponent(new WarriorWater());
                        break;
                    case "vokunSaladButton":
                        switchToScreen = new VokunSaladComponent(new BleakwindBuffet.Data.Sides.VokunSalad());
                        break;
                    case "friedMiraakButton":
                        switchToScreen = new FriedMiraakComponent(new BleakwindBuffet.Data.Sides.FriedMiraak());
                        break;
                    case "madOtarGritsButton":
                        switchToScreen = new MadOtarGritsComponent(new BleakwindBuffet.Data.Sides.MadOtarGrits());
                        break;
                    case "dragonbornWaffleFriesButton":
                        switchToScreen = new DragonbornWaffleFriesComponent(new BleakwindBuffet.Data.Sides.DragonbornWaffleFries());
                        break;
                    case "comboButton":
                        Combo c = new Combo();
                        c.Entree = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
                        c.Drink = new AretinoAppleJuice();
                        c.Side = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
                        switchToScreen = new ComboComponent(c);
                        break;
                    default:
                        throw new NotImplementedException("Unknown category selected");
                }
                orderControl?.SwapScreen(switchToScreen);
            }
        }
        /// <summary>
        /// Adds an item to the listbox in OrderComponent
        /// </summary>
        /// <param name="elem"></param>
        /// <param name="sender">Button Pressed</param>
        /// <param name="itemName">String of the item name</param>
        public static void AddItem(this DependencyObject elem, object sender, IOrderItem item)
        {
            if (sender is Button)
            {
                var orderControl = elem.FindAncestor<OrderComponent>();
                Order listOfItems = (Order)orderControl.DataContext;

                if (orderControl is OrderComponent)
                {
                    if (item.SpecialInstructions.Count > 0)
                    {
                        //string concat = String.Join(", ", item.SpecialInstructions);
                        //orderControl.orderList.Items.Add("$" + item.Price + ": " + itemName + " - " + concat);
                        orderControl.orderList.Items.Add(item);
                    }
                    else
                    {
                        //orderControl.orderList.Items.Add("$" + item.Price + ":   " + itemName);
                        orderControl.orderList.Items.Add(item);
                    }
                    
                    listOfItems.Add(item);
                }
            }
        }
    }
}
