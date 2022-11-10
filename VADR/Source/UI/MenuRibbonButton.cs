using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

/*
 Defines functionality for the application ribbon menu buttons at the top of the Window
 */

namespace VADR.Source.UI
{
    internal class MenuRibbonButton : Button
    {
        public MenuRibbonButton()
        {
            // Initialize button
            Debug.WriteLine("MenuButton Created");
        }

        public void Button_Click(object sender, RoutedEventArgs e, Window w, string name)
        {
            ContextMenu cm = w.FindResource(name) as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
    }
}
