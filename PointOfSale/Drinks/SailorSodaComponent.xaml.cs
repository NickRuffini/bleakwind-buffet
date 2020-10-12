/*
 * Author: Nick Ruffini
 * Class name: SailorSodaComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Drink Sailor's Soda
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
using BleakwindBuffet.Data.Generic;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for SailorSodaComponent.xaml
    /// </summary>
    public partial class SailorSodaComponent : UserControl
    {
        public SailorSodaComponent(SailorSoda ss)
        {
            InitializeComponent();
            this.DataContext = ss;
        }

        /// <summary>
        /// Event handler for changing the combo box's size value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSSizeComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            /*if (DataContext is SailorSoda)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Small") ss.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (s == "Medium") ss.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (s == "Large") ss.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }*/
        }

        /// <summary>
        /// Event handler for changing the combo box's flavor value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSFlavorComboBox_Changed(object sender, SelectionChangedEventArgs e)
        {
            /*if (DataContext is SailorSoda)
            {
                foreach (string s in e.AddedItems)
                {
                    if (s == "Blackberry") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                    if (s == "Cherry") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                    if (s == "Grapefruit") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                    if (s == "Lemon") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                    if (s == "Peach") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                    if (s == "Watermelon") ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
                }
            }*/
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
            this.AddItem(sender, this.DataContext as IOrderItem);
            this.SwitchScreen(sender);
        }
    }
}
