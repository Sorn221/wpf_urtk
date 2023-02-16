using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace lr4
{
    
    public partial class MainWindow : Window
    {
        List<telephone> phones;
        public MainWindow()
        {
            InitializeComponent();
            phones = new List<telephone>
            {
                new telephone { Company = "Apple ", Title = "iPhone 10", Price = 58000},
                new telephone { Company = "Xiaomi", Title = "Redmi Note 10S", Price = 28000},
                new telephone { Company = "Apple ", Title = "iPhone 12 Pro Max Super Idol", Price = 158000},
                new telephone { Company = "Nokia ", Title = "3310", Price = 800},
            };
            mainListBox.ItemsSource = phones;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            phones.Add(new telephone
            {
                Company = companyView.Text,
                Title = titleView.Text,
                Price = Convert.ToDecimal(priceView.Text)
            });
            mainListBox.ItemsSource = null;
            mainListBox.ItemsSource = phones;
            companyView.Text = "";
            titleView.Text = "";
            priceView.Text = "";
        }

        private void RemButton_Click(object sender, RoutedEventArgs e)
        {
            phones.Remove(mainListBox.SelectedItem as telephone);

            mainListBox.ItemsSource = null;
            mainListBox.ItemsSource = phones;
        }
    }
}
