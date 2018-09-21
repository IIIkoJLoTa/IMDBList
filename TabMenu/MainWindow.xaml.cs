using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace TabMenu
{
    public partial class MainWindow : Window
    {
        FilmsPage _films = new FilmsPage();
        SearchPage _search = new SearchPage();
        Home _home;
        public MainWindow()
        {
            InitializeComponent();
            PrintButton.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);
            switch (index)
            {
                case 0:
                    _home = new Home();
                    Frame.NavigationService.Navigate(_home);
                    PrintButton.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    PrintButton.Visibility = Visibility.Visible;
                    Frame.NavigationService.Navigate(_films);
                    _films.Complete();
                    break;
                case 2:
                    PrintButton.Visibility = Visibility.Visible;
                    Frame.NavigationService.Navigate(_search);
                    break;
                case 3:
                    _films.SaveToFile();
                    System.Diagnostics.Process.Start(@"Spravka.chm");
                    break;
                case 4:
                    _films.SaveToFile();
                    break;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                if (e.Key == Key.F1)
                {
                    System.Diagnostics.Process.Start(@"Spravka.chm");
                }
            }
        }

        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            _home = new Home();
            Frame.NavigationService.Navigate(_home);
        }
    }
}
