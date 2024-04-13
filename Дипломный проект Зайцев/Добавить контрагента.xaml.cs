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
    /// Логика взаимодействия для Добавить_контрагента.xaml
    /// </summary>
    public partial class Добавить_контрагента : Window
    {
        Дипломный_проект_Зайцев_20_КИС_1Entities cont = new Дипломный_проект_Зайцев_20_КИС_1Entities();
        public Добавить_контрагента(Дипломный_проект_Зайцев_20_КИС_1Entities cont, Контрагенты контрагенты)
        {
            InitializeComponent();
            this.cont = cont;
            this.DataContext = контрагенты;
        }

        private void tbxNameClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxPhone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxAddress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxHome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCancelAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveClientData_Click(object sender, RoutedEventArgs e)
        {
            cont.SaveChanges();
            this.Close();
            MessageBox.Show("Запись сохранена");
        }
    }
}
