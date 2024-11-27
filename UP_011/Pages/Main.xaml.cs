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

namespace UP_011.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        List<Classes.Contexts.PartnersContext> AllPartners = Classes.Contexts.PartnersContext.AllParnters();
        public Main()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            foreach(var item in AllPartners)
            {
                Parent.Children.Add(new Elements.Element(item));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.init.frame.Navigate(new Pages.Add());
        }
    }
}
