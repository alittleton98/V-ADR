using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VADR.Dialogs;
using VADR.Source.UI

namespace VADR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuRibbonButton[] menuRibbonButtons = new MenuRibbonButton[2];

        public MainWindow()
        {
            int i;
            InitializeComponent();
            for (i = 0; i < menuRibbonButtons.Length; i++) 
            {
                MenuRibbonButton mb = new MenuRibbonButton();
                menuRibbonButtons[i] = mb;
            }

        }

        void OnFileButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "fileButton");
        }
        void OnEditButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "editButton");
        }
        void OnViewButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "viewButton");
        }
        void OnProjectButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "projectButton");
        }
        void OnToolsButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "toolsButton");
        }
        void OnWindowButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "windowButton");
        }
        void OnHelpButtonClick(object sender, RoutedEventArgs e)
        {
            menuRibbonButtons[0].Button_Click(sender, e, this, "helpButton");
        }

        void DialogButtonTest(object sender, RoutedEventArgs e) 
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }
    }
}
