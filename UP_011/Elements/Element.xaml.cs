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
using UP_011.Pages;

namespace UP_011.Elements
{
    /// <summary>
    /// Логика взаимодействия для Element.xaml
    /// </summary>
    public partial class Element : UserControl
    {
        Classes.Contexts.PartnersContext _partners;
        Main main;
        public Element(Classes.Contexts.PartnersContext partners)
        {
            InitializeComponent();
            _partners = partners;
            lb_type.Content += partners.Type_partner;
            lb_director.Content += partners.Director; 
            lb_phone.Content += Convert.ToString(partners.Phone);
            lb_raiting.Content += Convert.ToString(partners.Raiting);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new Pages.Add(_partners));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _partners.Delete();
            MainWindow.init.frame.Navigate(new Pages.Main());
        }
    }
}
