﻿/*
 * Author: Nick Ruffini
 * Class name: DragonbornWaffleFriesComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Side Dragonborn Waffle Fries
 */

using System;
using System.Collections.Generic;
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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesComponent.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesComponent : UserControl
    {
        public DragonbornWaffleFriesComponent()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event for the return button that brings us back to the menu screen!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.SwitchScreen(sender);
        }

        /// <summary>
        /// Click event for the add button that adds a item to the listbox and switches the screen back to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.AddItem(sender, "Dragonborn Waffle Fries");
            this.SwitchScreen(sender);
        }
    }
}
