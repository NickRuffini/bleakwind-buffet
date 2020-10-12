using BleakwindBuffet.Data.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboComponent.xaml
    /// </summary>
    public partial class ComboComponent : UserControl
    {

        public ComboComponent(Combo c)
        {
            InitializeComponent();

            this.DataContext = c;
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

        private void addDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            drinkStackPanel.Visibility = Visibility.Visible;
        }

        
        private void editDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            /*if((this.DataContext as Combo).Drink is AretinoAppleJuice)
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aaStackPanel.Visibility = Visibility.Visible;
            }*/
        }

        private void addEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            // Issue starts here; not adding the data context, but another aj?
            this.AddItem(sender, this.DataContext as IOrderItem);
            this.SwitchScreen(sender);
        }

        private void editEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void addSideButton_Click(object sender, RoutedEventArgs e)
        {
            // Issue starts here; not adding the data context, but another aj?
            this.AddItem(sender, this.DataContext as IOrderItem);
            this.SwitchScreen(sender);
        }

        private void editSideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void aaComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Drink = new AretinoAppleJuice();
            drinkStackPanel.Visibility = Visibility.Collapsed;
        }

        private void ccComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Drink = new CandlehearthCoffee();
            drinkStackPanel.Visibility = Visibility.Collapsed;
        }

        private void mmComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Drink = new MarkarthMilk();
            drinkStackPanel.Visibility = Visibility.Collapsed;
        }

        private void ssComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Drink = new SailorSoda();
            drinkStackPanel.Visibility = Visibility.Collapsed;
        }

        private void wwComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Drink = new WarriorWater();
            drinkStackPanel.Visibility = Visibility.Collapsed;
        }

        
    }
}
