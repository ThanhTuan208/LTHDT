using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_10._4_cau4_ch3
{
    internal class GDtiente: GDich
    {
        private int tiGia;
        private string loaiTien;
        public GDtiente() { }

        public GDtiente( string maGD, DateTime ngayGD, double donGia, int soLuong, int tiGia, string loaiTien) : base(maGD, ngayGD, donGia, soLuong)
        {
            LoaiTien = loaiTien;
            TiGia = tiGia;
        }
        public int TiGia { get => tiGia; set => tiGia = value; }
        public string LoaiTien { get => loaiTien; set => loaiTien = value; }

        public double ThanhTien()
        {
            if (LoaiTien == "VietNam")
            {
                return SoLuong * DonGia;
            }
            else
            {
                return SoLuong * DonGia * tiGia;
            }
        }
        //public void USD_EURO()
        //{
        //    Console.WriteLine($"thanh tien = {SoLuong} * {DonGia} * {tiGia} = "+SoLuong * DonGia * tiGia);
        //}
        //public void VN()
        //{
        //    Console.WriteLine($"thanh tien = {SoLuong} * {DonGia} = "+ SoLuong * DonGia);
        //}
        public new string ToString()
        {
            return$"{base.ToString()}, ti gia = {tiGia}";
        }
    }
}
