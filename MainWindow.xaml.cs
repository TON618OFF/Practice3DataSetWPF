using Practice3DataSetWPF.DataSet1TableAdapters;
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

namespace Practice3DataSetWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksTableAdapter books = new BooksTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            dg_BD_books.ItemsSource = books.GetFullInfo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dg_BD_books.Columns[0].Visibility = Visibility.Collapsed;
            dg_BD_books.Columns[2].Visibility = Visibility.Collapsed;
            dg_BD_books.Columns[3].Visibility = Visibility.Collapsed;

            dg_BD_books.Columns[1].Header = "Название Книги";
            dg_BD_books.Columns[4].Header = "Жанр";
            dg_BD_books.Columns[5].Header = "Фамилия автора";
            dg_BD_books.Columns[6].Header = "Имя автора";
            dg_BD_books.Columns[7].Header = "Отчество автора";
        }
    }
}
