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

namespace KiemTraKetThucMon
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

        private void BtnNhap_Click(object sender, RoutedEventArgs e)
        {
            Meo meo = new Meo();
            meo.LoaiDongVat = "Meo Meo";
            meo.maulong = "Trang";
            meo.Keu();
            //MessageBox.Show(" Meo Meo toi la Meo Long Mau " + txtMeo.Text);
        }

        private void Btnnhap_Click_1(object sender, RoutedEventArgs e)
        {
            Cho cho = new Cho();
            cho.LoaiDongVat = "Gau Gau";
            cho.maulong = " Do ";
            cho.Keu();
            //MessageBox.Show(" Gau Gau toi la Cho Long mau " + txtCho.Text);
        }
    }
}
