using kalendar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Runtime.CompilerServices;

namespace kalendar.ViewModel
{
    internal class podgruzka_huyni : INotifyPropertyChanged
    {

        DateTime currendata = DateTime.Now;
        Image image = new Image();
        public podgruzka_huyni() 
        {
            string path = "sources/shreks.jpg";
            image.Source = new BitmapImage(new Uri(path, UriKind.Relative));
            List<kartochka> kartochkas = new List<kartochka>();
            for (int i = 0; i < 32; i++)
            {
                kartochkas.Add(new kartochka(i, image));
            }
            foreach (var kartochka in kartochkas)
            {
                panel.Children.Add(kartochka);
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


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
