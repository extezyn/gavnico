using kalendar.View;
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

namespace kalendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void load(object sender, RoutedEventArgs e)
        {
            DateTime currendata = DateTime.Now; 
            List<kartochka> kartochkas = new List<kartochka>();
            for (int i = 0; i < 32; i++)
            {
                kartochkas.Add(new kartochka(i,));
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mesyac mesyac = new Mesyac();
            mesyac.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mesyac mesyac = new Mesyac();
            mesyac.Show();
            this.Close();
        }
    }
}
