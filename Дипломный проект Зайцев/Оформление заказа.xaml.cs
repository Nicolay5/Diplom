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
    /// Логика взаимодействия для Оформление_заказа.xaml
    /// </summary>
    public partial class Оформление_заказа : Window
    {
       private Дипломный_проект_Зайцев_20_КИС_1Entities _cont;
        public Оформление_заказа(Дипломный_проект_Зайцев_20_КИС_1Entities cont, Заказы заказы)
        {
            InitializeComponent();
            _cont = cont;
            this.DataContext = заказы;
            cmbClient.ItemsSource = cont.Контрагенты.ToList();
            cmbProduct.ItemsSource = cont.Товары.ToList();
            cmbOrderStatus.ItemsSource = cont.Статус_заказа.ToList();
            tbxDateOrder.SelectedDate = DateTime.Now;
        }

        private void tbxOrderStatus_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxDateOrder_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(tbxCount.Text, out int c);
            _cont.Заказы.Add(new Заказы()
            {
                ид_контрагента = _cont.Контрагенты.First(_ => _.Наименование.Equals(cmbClient.SelectedItem.ToString())).ид_контрагента,
                ид_товара = _cont.Товары.First(_ => _.Наименование.Equals(cmbProduct.SelectedItem.ToString())).ид_товара,
                Количество = c,
                ид_статуса = 1,
                Дата_заказа = (DateTime)tbxDateOrder.SelectedDate,
                Стоимость = double.Parse(tbxPrice.Text),
            }); ; 
            
            this.Close();
            MessageBox.Show("Запись сохранена");
        }

        private void tbxPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbxCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountSum();
        }
        private void CountSum()
        {
            var products = _cont.Товары.FirstOrDefault(_ => _.Наименование.Equals(cmbProduct.Text));
            if (products is null) return;
            int.TryParse(tbxCount.Text, out int res);
            tbxPrice.Text = (res * products.Стоимость).ToString();
        }
        private void tbxProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CountSum();
        }

        private void btnCancelAddOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmbOrderStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbxDateOrder_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
