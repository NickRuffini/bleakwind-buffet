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
using BleakwindBuffet.Data.Entrees;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;
using BleakwindBuffet.Data.Sides;

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
            entreeStackPanel.Visibility = Visibility.Collapsed;
            sideStackPanel.Visibility = Visibility.Collapsed;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
            sideContainerBorder.Visibility = Visibility.Collapsed;
        }

        
        private void editDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            drinkContainerBorder.Visibility = Visibility.Visible;

            drinkStackPanel.Visibility = Visibility.Collapsed;
            entreeStackPanel.Visibility = Visibility.Collapsed;
            sideStackPanel.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
            sideContainerBorder.Visibility = Visibility.Collapsed;

            if ((this.DataContext as Combo).Drink is AretinoAppleJuice aj)
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
            drinkStackPanel.Visibility = Visibility.Collapsed;
            entreeStackPanel.Visibility = Visibility.Visible;
            sideStackPanel.Visibility = Visibility.Collapsed;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
            sideContainerBorder.Visibility = Visibility.Collapsed;
        }

        private void editEntreeButton_Click(object sender, RoutedEventArgs e)
        {
            drinkStackPanel.Visibility = Visibility.Collapsed;
            entreeStackPanel.Visibility = Visibility.Collapsed;
            sideStackPanel.Visibility = Visibility.Collapsed;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Visible;
            sideContainerBorder.Visibility = Visibility.Collapsed;
            if ((this.DataContext as Combo).Entree is BriarheartBurger bb)
            {
                BriarheartBurgerComponent bbc = new BriarheartBurgerComponent(bb);
                bbc.addButton.Visibility = Visibility.Collapsed;
                bbc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = bbc;
            }
            if ((this.DataContext as Combo).Entree is DoubleDraugr dd)
            {
                DoubleDraugrComponent ddc = new DoubleDraugrComponent(dd);
                ddc.addButton.Visibility = Visibility.Collapsed;
                ddc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = ddc;
            }
            if ((this.DataContext as Combo).Entree is GardenOrcOmelette goo)
            {
                GardenOrcOmeletteComponent gooc = new GardenOrcOmeletteComponent(goo);
                gooc.addButton.Visibility = Visibility.Collapsed;
                gooc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = gooc;
            }
            if ((this.DataContext as Combo).Entree is PhillyPoacher pp)
            {
                PhillyPoacherComponent ppc = new PhillyPoacherComponent(pp);
                ppc.addButton.Visibility = Visibility.Collapsed;
                ppc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = ppc;
            }
            if ((this.DataContext as Combo).Entree is SmokehouseSkeleton ss)
            {
                SmokehouseSkeletonComponent ssc = new SmokehouseSkeletonComponent(ss);
                ssc.addButton.Visibility = Visibility.Collapsed;
                ssc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = ssc;
            }
            if ((this.DataContext as Combo).Entree is ThalmorTriple tt)
            {
                ThalmorTripleComponent ttc = new ThalmorTripleComponent(tt);
                ttc.addButton.Visibility = Visibility.Collapsed;
                ttc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = ttc;
            }
            if ((this.DataContext as Combo).Entree is ThugsTBone ttb)
            {
                ThugsTBoneComponent ttc = new ThugsTBoneComponent(ttb);
                ttc.addButton.Visibility = Visibility.Collapsed;
                ttc.returnButton.Visibility = Visibility.Collapsed;

                entreeContainerBorder.Child = ttc;
            }
        }

        private void addSideButton_Click(object sender, RoutedEventArgs e)
        {
            drinkStackPanel.Visibility = Visibility.Collapsed;
            entreeStackPanel.Visibility = Visibility.Collapsed;
            sideStackPanel.Visibility = Visibility.Visible;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
            sideContainerBorder.Visibility = Visibility.Collapsed;
        }

        private void editSideButton_Click(object sender, RoutedEventArgs e)
        {
            drinkStackPanel.Visibility = Visibility.Collapsed;
            entreeStackPanel.Visibility = Visibility.Collapsed;
            sideStackPanel.Visibility = Visibility.Collapsed;
            drinkContainerBorder.Visibility = Visibility.Collapsed;
            entreeContainerBorder.Visibility = Visibility.Collapsed;
            sideContainerBorder.Visibility = Visibility.Visible;
            if ((this.DataContext as Combo).Side is DragonbornWaffleFries dwf)
            {
                DragonbornWaffleFriesComponent dwfc = new DragonbornWaffleFriesComponent(dwf);
                dwfc.addButton.Visibility = Visibility.Collapsed;
                dwfc.returnButton.Visibility = Visibility.Collapsed;

                sideContainerBorder.Child = dwfc;
            }
            if ((this.DataContext as Combo).Side is FriedMiraak fm)
            {
                FriedMiraakComponent fmc = new FriedMiraakComponent(fm);
                fmc.addButton.Visibility = Visibility.Collapsed;
                fmc.returnButton.Visibility = Visibility.Collapsed;

                sideContainerBorder.Child = fmc;
            }
            if ((this.DataContext as Combo).Side is MadOtarGrits mog)
            {
                MadOtarGritsComponent mogc = new MadOtarGritsComponent(mog);
                mogc.addButton.Visibility = Visibility.Collapsed;
                mogc.returnButton.Visibility = Visibility.Collapsed;

                sideContainerBorder.Child = mogc;
            }
            if ((this.DataContext as Combo).Side is VokunSalad vs)
            {
                VokunSaladComponent vsc = new VokunSaladComponent(vs);
                vsc.addButton.Visibility = Visibility.Collapsed;
                vsc.returnButton.Visibility = Visibility.Collapsed;

                sideContainerBorder.Child = vsc;
            }
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
            (this.DataContext as Combo).Entree = new DoubleDraugr();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void bbComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new BriarheartBurger();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void gooComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new GardenOrcOmelette();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void ppComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new PhillyPoacher();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void smComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new SmokehouseSkeleton();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void ttComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new ThalmorTriple();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void ttbComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Entree = new ThugsTBone();
            entreeStackPanel.Visibility = Visibility.Collapsed;
        }

        private void dwfComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Side = new DragonbornWaffleFries();
            sideStackPanel.Visibility = Visibility.Collapsed;
        }

        private void fmComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Side = new FriedMiraak();
            sideStackPanel.Visibility = Visibility.Collapsed;
        }

        private void mogComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Side = new MadOtarGrits();
            sideStackPanel.Visibility = Visibility.Collapsed;
        }

        private void vsComboButton_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as Combo).Side = new VokunSalad();
            sideStackPanel.Visibility = Visibility.Collapsed;
        }
    }
}
