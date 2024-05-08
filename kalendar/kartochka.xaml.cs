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
    /// Логика взаимодействия для kartochka.xaml
    /// </summary>
    public partial class kartochka : UserControl
    {
        public int дата {  get; set; }
        public Image имэдж {  get; set; }
        public kartochka(int d, Image im)
        {
            InitializeComponent();
            DataContext = this;

            дата = d;
            имэдж = im;
        }
    }
}
