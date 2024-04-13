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
using System.Windows.Shapes;

namespace Дипломный_проект_Зайцев
{
    /// <summary>
    /// Логика взаимодействия для Добавление_товара.xaml
    /// </summary>
    public partial class Добавление_товара : Window
    {
        Дипломный_проект_Зайцев_20_КИС_1Entities cont = new Дипломный_проект_Зайцев_20_КИС_1Entities();
        public Добавление_товара(Дипломный_проект_Зайцев_20_КИС_1Entities cont, Товары товары)
        {
            InitializeComponent();
            this.cont = cont;
            this.DataContext = товары;

            cmbCategory.ItemsSource = cont.Категория_товара.ToList();
        }

        private void tbxNameProduct_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxCol_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbxProductPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaveProductData_Click(object sender, RoutedEventArgs e)
        {
            cont.SaveChanges();
            this.Close();
            MessageBox.Show("Запись сохранена");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
