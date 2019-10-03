using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KiemTraKetThucMon
{
    class DongVat
    {
        private String Loai;
        private string MauLong;
        public string LoaiDongVat
        {
            get { return Loai; }
            set { Loai = value; }
        }
        public DongVat(string loaiDV)
        {
            Loai = loaiDV;
        }
        public DongVat()
        {

        }
        public string maulong
        {
            get { return MauLong; }
            set { MauLong = value; }
        }
        public virtual void Keu()
        {
            
        }

    }
}
