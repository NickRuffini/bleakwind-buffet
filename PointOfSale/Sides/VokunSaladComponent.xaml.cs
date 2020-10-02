/*
 * Author: Nick Ruffini
 * Class name: VokunSaladComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Side Vokun Salad
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
    /// Interaction logic for VokunSaladComponent.xaml
    /// </summary>
    public partial class VokunSaladComponent : UserControl
    {
        VokunSalad vs;

        public VokunSaladComponent()
        {
            InitializeComponent();
            vs = new VokunSalad();
            this.DataContext = vs;

            foreach (string enumValue in Enum.GetNames(typeof(BleakwindBuffet.Data.Enums.Size)))
            {
                VSComboBox.Items.Add(enumValue);
                if (enumValue == "Small")
                {
                    VSComboBox.SelectedItem = enumValue;
                }
            }
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VSComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is VokunSalad)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Small") vs.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") vs.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") vs.Size = BleakwindBuffet.Data.Enums.Size.Large;
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
            this.AddItem(sender, "Vokun Salad");
            this.SwitchScreen(sender);
        }
    }
}
