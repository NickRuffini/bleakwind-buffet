/*
 * Author: Nick Ruffini
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to represent the GUI of the Order Component. Oversees the overall Order (2nd level)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Generic;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.ExtensionMethod;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        Order o;

        /// <summary>
        /// Initializes our XAML and starts us off on the Menu Screen
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            containerBorder.Child = new MenuSelectionComponent();
            o = new Order();
            this.DataContext = o;
        }

        /// <summary>
        /// Changes what screen we are displaying in our border
        /// </summary>
        /// <param name="obj">Menu Screen/Item Screen we are changing to</param>
        public void SwapScreen(UIElement obj)
        {
            containerBorder.Child = obj;
        }

        /// <summary>
        /// Cancel button event handler that clears out the list of items in the "cart"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.orderList.Items.Clear();
            o = new Order();
            this.DataContext = o;
        }

        /// <summary>
        /// Complete button event handler that brings us to the Payment Options Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeButton_Click(object sender, RoutedEventArgs e)
        {
            SwapScreen(new PaymentOptionsScreenComponent());
        }

        /// <summary>
        /// Method that handles editing an existing item in the order
        /// </summary>
        /// <param name="sender"> ListBoxItem we are clicking on </param>
        /// <param name="e"></param>
        void EditItem(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem lbi = (sender as ListBox).SelectedItem as IOrderItem;
            //IOrderItem item = lbi.DataContext as IOrderItem;
            // index of the item in the order we are interacting with
            int index = ((sender as ListBox).SelectedIndex);

            if (index > -1 && lbi is AretinoAppleJuice)
            {
                AretinoAppleJuice test = lbi as AretinoAppleJuice;
                AretinoAppleJuiceComponent ajc = new AretinoAppleJuiceComponent(test);
                containerBorder.Child = ajc;
            }
            if (index > -1 && lbi is CandlehearthCoffee)
            {
                CandlehearthCoffee cc = lbi as CandlehearthCoffee;
                CandlehearthCoffeeComponent ccc = new CandlehearthCoffeeComponent(cc);
                containerBorder.Child = ccc;
            }
            if (index > -1 && lbi is MarkarthMilk)
            {
                MarkarthMilk mm = lbi as MarkarthMilk;
                MarkarthMilkComponent mmc = new MarkarthMilkComponent(mm);
                containerBorder.Child = mmc;
            }
            if (index > -1 && lbi is SailorSoda)
            {
                SailorSoda test = lbi as SailorSoda;
                SailorSodaComponent ssc = new SailorSodaComponent(test);
                containerBorder.Child = ssc;
            }
            if (index > -1 && lbi is WarriorWater)
            {
                WarriorWater test = lbi as WarriorWater;
                WarriorWaterComponent wwc = new WarriorWaterComponent(test);
                containerBorder.Child = wwc;
            }
            if (index > -1 && lbi is BriarheartBurger)
            {
                BriarheartBurger test = lbi as BriarheartBurger;
                BriarheartBurgerComponent bbc = new BriarheartBurgerComponent(test);
                containerBorder.Child = bbc;
            }
            if (index > -1 && lbi is DoubleDraugr)
            {
                DoubleDraugr test = lbi as DoubleDraugr;
                DoubleDraugrComponent ddc = new DoubleDraugrComponent(test);
                containerBorder.Child = ddc;
            }
            if (index > -1 && lbi is GardenOrcOmelette)
            {
                GardenOrcOmelette test = lbi as GardenOrcOmelette;
                GardenOrcOmeletteComponent gooc = new GardenOrcOmeletteComponent(test);
                containerBorder.Child = gooc;
            }
            if (index > -1 && lbi is PhillyPoacher)
            {
                PhillyPoacher test = lbi as PhillyPoacher;
                PhillyPoacherComponent ppc = new PhillyPoacherComponent(test);
                containerBorder.Child = ppc;
            }
            if (index > -1 && lbi is SmokehouseSkeleton)
            {
                SmokehouseSkeleton test = lbi as SmokehouseSkeleton;
                SmokehouseSkeletonComponent ssc = new SmokehouseSkeletonComponent(test);
                containerBorder.Child = ssc;
            }
            if (index > -1 && lbi is ThalmorTriple)
            {
                ThalmorTriple test = lbi as ThalmorTriple;
                ThalmorTripleComponent ttc = new ThalmorTripleComponent(test);
                containerBorder.Child = ttc;
            }
            if (index > -1 && lbi is ThugsTBone)
            {
                ThugsTBone test = lbi as ThugsTBone;
                ThugsTBoneComponent ttc = new ThugsTBoneComponent(test);
                containerBorder.Child = ttc;
            }
            if (index > -1 && lbi is DragonbornWaffleFries)
            {
                DragonbornWaffleFries test = lbi as DragonbornWaffleFries;
                DragonbornWaffleFriesComponent dwfc = new DragonbornWaffleFriesComponent(test);
                containerBorder.Child = dwfc;
            }
            if (index > -1 && lbi is FriedMiraak)
            {
                FriedMiraak test = lbi as FriedMiraak;
                FriedMiraakComponent fmc = new FriedMiraakComponent(test);
                containerBorder.Child = fmc;
            }
            if (index > -1 && lbi is MadOtarGrits)
            {
                MadOtarGrits test = lbi as MadOtarGrits;
                MadOtarGritsComponent mogc = new MadOtarGritsComponent(test);
                containerBorder.Child = mogc;
            }
            if (index > -1 && lbi is VokunSalad)
            {
                VokunSalad test = lbi as VokunSalad;
                VokunSaladComponent vsc = new VokunSaladComponent(test);
                containerBorder.Child = vsc;
            }
            if (index > -1 && lbi is Combo)
            {
                Combo test = lbi as Combo;
                ComboComponent cc = new ComboComponent(test);
                containerBorder.Child = cc;
            }
        }

        /// <summary>
        /// Handler that handles clicking the remove button on a order item (to remove it)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button removeButton = sender as Button;

                var test = VisualTreeHelper.GetParent(removeButton);
                var test2 = VisualTreeHelper.GetParent(test);
                var test3 = VisualTreeHelper.GetParent(test2);
                var listBoxItem = VisualTreeHelper.GetParent(test3);
                var test4 = VisualTreeHelper.GetParent(listBoxItem);
                var test5 = VisualTreeHelper.GetParent(test4);
                var test6 = VisualTreeHelper.GetParent(test5);
                var test7 = VisualTreeHelper.GetParent(test6);
                var test8 = VisualTreeHelper.GetParent(test7);
                var test9 = VisualTreeHelper.GetParent(test8);
                var listBox = VisualTreeHelper.GetParent(test9);

                if (listBox is ListBox list)
                {
               
                    if (listBoxItem is ListBoxItem listItem)
                    {

                        object listBoxContent = listItem.Content;

                        int index = list.Items.IndexOf(listBoxContent);

                        list.Items.RemoveAt(index);

                        o.RemoveAt(index);
                    }
                }
            }
        }

        /// <summary>
        /// Prints the receipt for the order, which is the data context of this!
        /// </summary>
        /// <param name="paymentMethod"> Can be "Cash" or "Card"</param>
        public void printReceipt(string paymentMethod)
        {
            if (paymentMethod == "Card")
            {
                if (this.DataContext is Order o)
                {
                    //Prints the order number
                    int orderNumber = o.Number;
                    string orderNumberString = orderNumber.ToString();
                    printWithLineBreaks(orderNumberString, 40);

                    //Prints time Orde was finalized (now)
                    DateTime now = DateTime.Now;
                    string timeString = now.ToString();
                    printWithLineBreaks(timeString, 40);

                    //Prints each item in the listbox
                    foreach(IOrderItem item in o)
                    {
                        printWithLineBreaks(item.ToString(), 40);
                        printWithLineBreaks(item.Price.ToString(), 40);
                        foreach(string s in item.SpecialInstructions)
                        {
                            printWithLineBreaks(s, 40);
                        }
                    }

                    //Prints the subtotal of the order
                    double subtotal = o.Subtotal;
                    string subtotalString = "$" + subtotal.ToString();
                    printWithLineBreaks(subtotalString, 40);

                    //Prints the tax of the order
                    double tax = o.Tax;
                    string taxString = "$" + tax.ToString();
                    printWithLineBreaks(taxString, 40);

                    //Prints the total of the order
                    double total = o.Total;
                    string totalString = "$" + total.ToString();
                    printWithLineBreaks(totalString, 40);

                    //Prints the payment method of the order
                    printWithLineBreaks(paymentMethod, 40);
                }
            }
            if (paymentMethod == "Cash")
            {
                if (this.DataContext is Order o)
                {
                    //Prints the order number
                    int orderNumber = o.Number;
                    string orderNumberString = orderNumber.ToString();
                    printWithLineBreaks(orderNumberString, 40);

                    //Prints time Order was finalized (now)
                    DateTime now = DateTime.Now;
                    string timeString = now.ToString();
                    printWithLineBreaks(timeString, 40);

                    //Prints each item in the listbox
                    foreach (IOrderItem item in o)
                    {
                        printWithLineBreaks(item.ToString(), 40);
                        printWithLineBreaks(item.Price.ToString(), 40);
                        foreach (string s in item.SpecialInstructions)
                        {
                            printWithLineBreaks(s, 40);
                        }
                    }

                    //Prints the subtotal of the order
                    double subtotal = o.Subtotal;
                    string subtotalString = "$" + subtotal.ToString();
                    printWithLineBreaks(subtotalString, 40);

                    //Prints the tax of the order
                    double tax = o.Tax;
                    string taxString = "$" + tax.ToString();
                    printWithLineBreaks(taxString, 40);

                    //Prints the total of the order
                    double total = o.Total;
                    string totalString = "$" + total.ToString();
                    printWithLineBreaks(totalString, 40);

                    //Prints the payment method of the order
                    printWithLineBreaks(paymentMethod, 40);

                    //Needs to print change owed as well!!!!





                }
            }
        }

        /// <summary>
        /// Adds line breaks to a string for a designated interval
        /// </summary>
        /// <param name="input"> String we are breaking up (potentially) </param>
        /// <param name="maxLineLength"> Lenght we are breaking at (this case 40) </param>
        /// <returns></returns>
        public void printWithLineBreaks(string input, int maxLineLength)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            for (var i = 0; i < input.Length; i += maxLineLength)
            {
                string test = input.Substring(i, Math.Min(maxLineLength, input.Length - i));
                RoundRegister.RecieptPrinter.PrintLine(input.Substring(i, Math.Min(maxLineLength, input.Length - i)));
            }


        }
    }
}
