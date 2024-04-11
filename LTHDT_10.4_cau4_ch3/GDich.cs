using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_10._4_cau4_ch3
{
    internal class GDich
    {
        private string maGD;
        private double donGia;
        private int soLuong;
        private DateTime ngayGD;
        public GDich() { }
        public GDich(string maGD, DateTime ngayGD, double donGia, int soLuong)
        {
            MaGD = maGD;
            NgayGD = ngayGD;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public string MaGD { get => maGD; set => maGD = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayGD { get => ngayGD; set => ngayGD = value; }

        public string ToString()
        {
            return $"maGD = {maGD}, ngayGD = {NgayGD.Day}, don gia = {donGia}, so luong = {soLuong}";
        }
        

    }
}
