/*
 * Author: Nick Ruffini
 * Class name: AretinoAppleJuiceComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Drink Aretino Apple Juice
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Generic;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceComponent.xaml
    /// </summary>
    public partial class AretinoAppleJuiceComponent : UserControl
    {
        public AretinoAppleJuiceComponent(AretinoAppleJuice aj)
        {
            InitializeComponent();
            /*foreach (string enumValue in Enum.GetNames(typeof(BleakwindBuffet.Data.Enums.Size)))
            {
                AAComboBox.Items.Add(enumValue);
                if (enumValue == "Small")
                {
                    AAComboBox.SelectedItem = enumValue;
                }
            }*/

            this.DataContext = aj;
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AAComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is AretinoAppleJuice aj)
            {
                /*
                foreach(string s in e.AddedItems)
                {
                    if (s == "Small") aj.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") aj.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") aj.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }*/
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
            // Issue starts here; not adding the data context, but another aj?
            this.AddItem(sender, this.DataContext as IOrderItem);
            this.SwitchScreen(sender);
        }
    }
}
