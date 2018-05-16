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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> person = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            person.Add(new Person { FirstName = "Ferrad", LastName = "Makosso" });
            person.Add(new Person { FirstName = "Charles", LastName = "Makosso" });
            person.Add(new Person { FirstName = "Anaïs", LastName = "Makosso" });

            myComboBox.ItemsSource = person;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");
        }

        private void firstNameText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
