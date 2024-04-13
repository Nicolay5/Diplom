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
    /// Логика взаимодействия для Главная_страница.xaml
    /// </summary>
    public partial class Главная_страница : Window
    {
        Дипломный_проект_Зайцев_20_КИС_1Entities cont = new Дипломный_проект_Зайцев_20_КИС_1Entities();
        public Главная_страница()
        {
            InitializeComponent();
            dtgClients.ItemsSource = cont.Контрагенты.ToList();
            dtgProducts.ItemsSource = cont.Товары.ToList();
            dtgOrders.ItemsSource = cont.Заказы.ToList();
        }

        private void dtgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtgClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtgProducts_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgProducts.ItemsSource = cont.Товары.Where(l => l.Категория_товара.Наименование.ToString().Contains(Poisk.Text)).ToList();
            if (Poisk.Text == "")
            {
                dtgProducts.ItemsSource = cont.Товары.ToList();
            }
        }

        private void PoiskOrder_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void PoiskClient_TextChanged(object sender, TextChangedEventArgs e)
        {
            dtgClients.ItemsSource = cont.Контрагенты.Where(l => l.Наименование.ToString().Contains(PoiskClient.Text)).ToList();
            if (PoiskClient.Text == "")
            {
                dtgClients.ItemsSource = cont.Контрагенты.ToList();
            }
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            var addClient = new Контрагенты();
            cont.Контрагенты.Add(addClient);
            var w = new Добавить_контрагента(cont, addClient);
            w.ShowDialog();
            dtgClients.ItemsSource = cont.Контрагенты.ToList();
        }

        private void DeleteClientButton_Click(object sender, RoutedEventArgs e)
        {
            var rowclient = dtgClients.SelectedItem as Контрагенты;
            if (rowclient == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult res = MessageBox.Show("Вы действительно хотите удалить строку", "Удалить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                cont.Контрагенты.Remove(rowclient);
                cont.SaveChanges();
                dtgClients.ItemsSource = cont.Контрагенты.ToList();
            }
        }

        private void DeleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var roworder = dtgOrders.SelectedItem as Заказы;
            if (roworder == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult res = MessageBox.Show("Вы действительно хотите удалить строку", "Удалить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                cont.Заказы.Remove(roworder);
                cont.SaveChanges();
                dtgOrders.ItemsSource = cont.Заказы.ToList();
            }
        }

        private void AddOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var addOrder = new Заказы();
            cont.Заказы.Add(addOrder);
            var w = new Оформление_заказа(cont, addOrder);
            w.ShowDialog();
            dtgOrders.ItemsSource = cont.Заказы.ToList();
        }

        private void AddProductButton_Click_1(object sender, RoutedEventArgs e)
        {
            var addProduct = new Товары();
            cont.Товары.Add(addProduct);
            var m = new Добавление_товара(cont, addProduct);
            m.ShowDialog();
            dtgProducts.ItemsSource = cont.Товары.ToList();
        }

        private void DeleteProductButton_Click_1(object sender, RoutedEventArgs e)
        {
            var rowproduct = dtgProducts.SelectedItem as Товары;
            if (rowproduct == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult res = MessageBox.Show("Вы действительно хотите удалить строку", "Удалить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                cont.Товары.Remove(rowproduct);
                cont.SaveChanges();
                dtgProducts.ItemsSource = cont.Товары.ToList();
            }
        }
    }
}
