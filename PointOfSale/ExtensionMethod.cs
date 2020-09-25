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

namespace PointOfSale.ExtensionMethod
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// Finds the control passed to the function
        /// </summary>
        /// <typeparam name="T">Some control</typeparam>
        /// <param name="element"></param>
        /// <returns>The control we were looking for when found</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent == null)
            {
                return null;
            }
            if (parent is T)
            {
                return parent as T;
            }
            return parent.FindAncestor<T>();
        }
        public static void SwitchScreen(this DependencyObject elem, object sender)
        {
            if (sender is Button)
            {
                FrameworkElement switchToScreen;
                var orderControl = elem.FindAncestor<OrderComponent>();

                switch (((Button)sender).Name)
                {
                    case "briarheartBurgerButton":
                        switchToScreen = new BriarheartBurgerComponent();
                        break;
                    case "returnButton":
                        switchToScreen = new MenuSelectionComponent();
                        break;
                    default:
                        throw new NotImplementedException("Unknown category selected");
                }
                orderControl?.SwapScreen(switchToScreen);
            }
        }
    }
}
