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
using UP_011.Classes;

namespace UP_011.Pages
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        Classes.Contexts.PartnersContext _partnersContext;
        public Add(Classes.Contexts.PartnersContext partnersContext = null)
        {
            InitializeComponent();
            
            if (partnersContext != null)
            {
                _partnersContext = partnersContext;
                tb_type.Text = partnersContext.Type_partner;
                tb_name.Text = partnersContext.Name_partner;
                tb_director.Text = partnersContext.Director;
                tb_phone.Text = Convert.ToString(partnersContext.Phone);
                tb_legaladress.Text = partnersContext.Legal_adress;
                tb_INN.Text = Convert.ToString(partnersContext.INN);
                tb_raiting.Text = Convert.ToString(partnersContext.Raiting);
                add.Content = "Изменить";
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new Pages.Main());
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (_partnersContext == null)
            {
                Classes.Contexts.PartnersContext newpartner = new Classes.Contexts.PartnersContext(
                    0,
                    tb_type.Text,
                    tb_name.Text,
                    tb_director.Text,
                    tb_email.Text,
                    Convert.ToInt64(tb_phone.Text),
                    tb_legaladress.Text,
                    Convert.ToInt64(tb_INN.Text),
                    Convert.ToInt32(tb_raiting.Text)
                    );
                newpartner.Add();
                MessageBox.Show("Запись успешно добавлена");
                MainWindow.init.frame.Navigate(new Pages.Main());
            }
            else
            {
                
                _partnersContext = new Classes.Contexts.PartnersContext(
                    _partnersContext.Id,
                    tb_type.Text,
                    tb_name.Text,
                    tb_director.Text,
                    tb_email.Text,
                    Convert.ToInt64(tb_phone.Text),
                    tb_legaladress.Text,
                    Convert.ToInt64(tb_INN.Text),
                    Convert.ToInt32(tb_raiting.Text)
                    );
                _partnersContext.Edit();
                MessageBox.Show("запись успешно изменена");
                MainWindow.init.frame.Navigate(new Pages.Main());
            }
        }
    }
}
