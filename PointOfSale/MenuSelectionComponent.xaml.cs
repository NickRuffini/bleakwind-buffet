/*
 * Author: Nick Ruffini
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Menu Selection Component
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for any button press on the Menu Screen. Switches to the User Control correlating to the button pressed!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void menuButtonClickEvent(object sender, RoutedEventArgs e)
        {
            this.SwitchScreen(sender);
        }
    }
}
