﻿/*
 * Author: Nick Ruffini
 * Class name: DoubleDraugrComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Entree Double Draugr
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for DoubleDraugrComponent.xaml
    /// </summary>
    public partial class DoubleDraugrComponent : UserControl
    {
        DoubleDraugr dd;

        public DoubleDraugrComponent()
        {
            InitializeComponent();
            dd = new DoubleDraugr();
            this.DataContext = dd;
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
            this.AddItem(sender, "Double Draugr");
            this.SwitchScreen(sender);
        }
    }
}
