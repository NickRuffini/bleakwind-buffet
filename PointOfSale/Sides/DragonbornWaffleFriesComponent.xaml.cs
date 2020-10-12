/*
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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesComponent.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesComponent : UserControl
    {
        DragonbornWaffleFries dwf;

        public DragonbornWaffleFriesComponent()
        {
            InitializeComponent();
            dwf = new DragonbornWaffleFries();
            this.DataContext = dwf;

            foreach (string enumValue in Enum.GetNames(typeof(BleakwindBuffet.Data.Enums.Size)))
            {
                DWFComboBox.Items.Add(enumValue);
                if (enumValue == "Small")
                {
                    DWFComboBox.SelectedItem = enumValue;
                }
            }
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DWFComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is DragonbornWaffleFries)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Small") dwf.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") dwf.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") dwf.Size = BleakwindBuffet.Data.Enums.Size.Large;
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
            this.AddItem(sender, dwf);
            this.SwitchScreen(sender);
        }
    }
}
