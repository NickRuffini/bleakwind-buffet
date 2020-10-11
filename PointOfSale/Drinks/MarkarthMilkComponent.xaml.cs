/*
 * Author: Nick Ruffini
 * Class name: MarkarthMilkComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Drink Markarth Milk
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for MarkarthMilkComponent.xaml
    /// </summary>
    public partial class MarkarthMilkComponent : UserControl
    {
        MarkarthMilk mm;

        public MarkarthMilkComponent()
        {
            InitializeComponent();
            mm = new MarkarthMilk();
            this.DataContext = mm;

            foreach (string enumValue in Enum.GetNames(typeof(BleakwindBuffet.Data.Enums.Size)))
            {
                MMComboBox.Items.Add(enumValue);
                if (enumValue == "Small")
                {
                    MMComboBox.SelectedItem = enumValue;
                }
            }
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MMComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is MarkarthMilk)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Small") mm.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") mm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") mm.Size = BleakwindBuffet.Data.Enums.Size.Large;
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
            this.AddItem(sender, mm.ToString(), mm);
            this.SwitchScreen(sender);
        }
    }
}
