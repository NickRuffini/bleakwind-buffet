﻿/*
 * Author: Nick Ruffini
 * Class name: MadOtarGritsComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Side Mad Otar Grits
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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for MadOtarGritsComponent.xaml
    /// </summary>
    public partial class MadOtarGritsComponent : UserControl
    {
        MadOtarGrits mog;

        public MadOtarGritsComponent()
        {
            InitializeComponent();
            mog = new MadOtarGrits();
            this.DataContext = mog;

            foreach (string enumValue in Enum.GetNames(typeof(BleakwindBuffet.Data.Enums.Size)))
            {
                MOGComboBox.Items.Add(enumValue);
                if (enumValue == "Small")
                {
                    MOGComboBox.SelectedItem = enumValue;
                }
            }
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MOGComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MadOtarGrits)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Small") mog.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") mog.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") mog.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
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
            this.AddItem(sender, "Mad Otar Grits");
            this.SwitchScreen(sender);
        }
    }
}
