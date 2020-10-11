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
                        switchToScreen = new BriarheartBurgerComponent();
                        break;
                    case "returnButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    case "addButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    case "doubleDraugrButton":
                        switchToScreen = new DoubleDraugrComponent();
                        break;
                    case "thalmorTripleButton":
                        switchToScreen = new ThalmorTripleComponent();
                        break;
                    case "smokehouseSkeletonButton":
                        switchToScreen = new SmokehouseSkeletonComponent();
                        break;
                    case "gardenOrcOmeletteButton":
                        switchToScreen = new GardenOrcOmeletteComponent();
                        break;
                    case "phillyPoacherButton":
                        switchToScreen = new PhillyPoacherComponent();
                        break;
                    case "thugsTBoneButton":
                        switchToScreen = new ThugsTBoneComponent();
                        break;
                    case "sailorSodaButton":
                        switchToScreen = new SailorSodaComponent();
                        break;
                    case "markarthMilkButton":
                        switchToScreen = new MarkarthMilkComponent();
                        break;
                    case "aretinoAppleJuiceButton":
                        switchToScreen = new AretinoAppleJuiceComponent(new AretinoAppleJuice());
                        break;
                    case "candlehearthCoffeeButton":
                        switchToScreen = new CandlehearthCoffeeComponent();
                        break;
                    case "warriorWaterButton":
                        switchToScreen = new WarriorWaterComponent();
                        break;
                    case "vokunSaladButton":
                        switchToScreen = new VokunSaladComponent();
                        break;
                    case "friedMiraakButton":
                        switchToScreen = new FriedMiraakComponent();
                        break;
                    case "madOtarGritsButton":
                        switchToScreen = new MadOtarGritsComponent();
                        break;
                    case "dragonbornWaffleFriesButton":
                        switchToScreen = new DragonbornWaffleFriesComponent();
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
        public static void AddItem(this DependencyObject elem, object sender, string itemName, IOrderItem item)
        {
            if (sender is Button)
            {
                var orderControl = elem.FindAncestor<OrderComponent>();
                Order listOfItems = (Order)orderControl.DataContext;

                if (orderControl is OrderComponent)
                {
                    if (item.SpecialInstructions.Count > 0)
                    {
                        string concat = String.Join(", ", item.SpecialInstructions);
                        orderControl.orderList.Items.Add("$" + item.Price + ": " + itemName + " - " + concat);
                    }
                    else
                    {
                        orderControl.orderList.Items.Add("$" + item.Price + ":   " + itemName);
                    }
                    
                    listOfItems.Add(item);
                }
            }
        }
    }
}
