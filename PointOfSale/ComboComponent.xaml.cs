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
using PointOfSale.Drinks;

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

        /// <summary>
        /// Add Drink handler to bring up the options of drinks you can change to
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            drinkStackPanel.Visibility = Visibility.Visible;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
        }

        
        private void editDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            drinkContainerBorder.Visibility = Visibility.Visible;
            if((this.DataContext as Combo).Drink is AretinoAppleJuice aj)
            {
                //AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(this);
                AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(aj);
                ajc.addButton.Visibility = Visibility.Collapsed;
                ajc.returnButton.Visibility = Visibility.Collapsed;

                drinkContainerBorder.Child = ajc;
            }
            if ((this.DataContext as Combo).Drink is CandlehearthCoffee cc)
            {
                //AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(this);
                CandlehearthCoffeeComponent ccc = new CandlehearthCoffeeComponent(cc);
                ccc.addButton.Visibility = Visibility.Collapsed;
                ccc.returnButton.Visibility = Visibility.Collapsed;

                drinkContainerBorder.Child = ccc;
            }
            if ((this.DataContext as Combo).Drink is MarkarthMilk mm)
            {
                //AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(this);
                MarkarthMilkComponent mmc = new MarkarthMilkComponent(mm);
                mmc.addButton.Visibility = Visibility.Collapsed;
                mmc.returnButton.Visibility = Visibility.Collapsed;

                drinkContainerBorder.Child = mmc;
            }
            if ((this.DataContext as Combo).Drink is SailorSoda ss)
            {
                //AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(this);
                SailorSodaComponent ssc = new SailorSodaComponent(ss);
                ssc.addButton.Visibility = Visibility.Collapsed;
                ssc.returnButton.Visibility = Visibility.Collapsed;

                drinkContainerBorder.Child = ssc;
            }
            if ((this.DataContext as Combo).Drink is WarriorWater ww)
            {
                //AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(this);
                WarriorWaterComponent wwc = new WarriorWaterComponent(ww);
                wwc.addButton.Visibility = Visibility.Collapsed;
                wwc.returnButton.Visibility = Visibility.Collapsed;

                drinkContainerBorder.Child = wwc;
            }
        }

        private void addEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            entreeStackPanel.Visibility = Visibility.Visible;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
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

        private void ddComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bbComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gooComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ppComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void smComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ttComboButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ttbComboButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
