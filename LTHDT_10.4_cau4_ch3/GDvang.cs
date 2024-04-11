using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_10._4_cau4_ch3
{
    internal class GDvang : GDich
    {
        private string loaiVang;

        public string LoaiVang { get => loaiVang; set => loaiVang = value; }

        public GDvang() { }
        public GDvang( string maGD, DateTime ngayGD, double donGia, int soLuong, string loaiVang) : base( maGD, ngayGD,  donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }
        public void ThanhTien()
        {
            Console.WriteLine($"thanh tien = {SoLuong} * {DonGia} = " +SoLuong*DonGia);
        }
        public new string ToString()
        {
            return $"{base.ToString()}, loai vàng = {loaiVang}";
        }

    }
}
