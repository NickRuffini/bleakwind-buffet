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

        void briarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            this.SwitchScreen(sender);
            /*if(sender is Button)
            {
                FrameworkElement switchToScreen;
                var orderControl = this.FindAncestor<OrderComponent>();

                switch(((Button)sender).Name)
                {
                    case "briarheartBurgerButton":
                        switchToScreen = new BriarheartBurgerComponent();
                        break;
                    default:
                        throw new NotImplementedException("Unknown category selected");
                }
                orderControl?.SwapScreen(switchToScreen);
            }*/
        }
    }
}
