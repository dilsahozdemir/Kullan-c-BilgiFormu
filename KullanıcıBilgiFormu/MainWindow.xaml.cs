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

namespace KullanıcıBilgiFormu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, RoutedEventArgs e)
        {
            // Kullanıcıdan verileri al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string yas = txtYas.Text;

            // Bilgileri ListBox'a ekle
            string kullaniciBilgisi = $"Ad: {ad}, Soyad: {soyad}, Yaş: {yas}";
            lstKullaniciBilgileri.Items.Add(kullaniciBilgisi);

            // TextBox'ları temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
        }
    }
}
    

