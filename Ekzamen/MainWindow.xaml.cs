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

namespace Ekzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate (new ListView());
        }

        private void ButtonVxod_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListView());
        }

        private void ButtonToday_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListView());
        }

        private void ButtonFuture_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListView());
        }
    }
}
