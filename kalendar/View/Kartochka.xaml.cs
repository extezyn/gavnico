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
    /// Логика взаимодействия для Kartochka.xaml
    /// </summary>
    public partial class Kartochka : UserControl
    {
        public int Dota {  get; set; }
        public Image kartonka { get; set; }
        public Kartochka()
        {
            InitializeComponent();
            /*DataContext = this;*/
        }
    }
}
