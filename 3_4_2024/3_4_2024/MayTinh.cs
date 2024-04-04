using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_2024
{
    internal class MayTinh
    {

        //Fields
        private string loaiMay;
        private string noiSX;
        private int thoiGianBaoHanh;
        private static int demSL = 0;

        //constructors
        public MayTinh(string loaiMay, string noiSX, int thoiGianBaoHanh)
        {
            this.loaiMay = loaiMay;
            this.noiSX = noiSX;
            this.thoiGianBaoHanh = thoiGianBaoHanh;
            demSL++;
        }
        //properties
        public string LoaiMay { get => loaiMay; set => loaiMay = value; }
        public string NoiSX { get => noiSX; set => noiSX = value; }
        public int ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }
        public static int DemSL { get => demSL; private set => demSL = value; }

        //Methods
        public static int DemSoLuongMayTinh(List<MayTinh> arr)
        {
            return DemSL;
        }

        public override String ToString()
        {
            return $"Loaimay:{LoaiMay},noisx: {NoiSX},thoigianbaohanh{ThoiGianBaoHanh}";
        }

        //In danh sach may tinh
        public static void XuatDSThongTin(List<MayTinh> arr)
        {
            foreach (MayTinh maytinh in arr)

            {
                Console.WriteLine(maytinh.ToString());
            }
        }
        public static int DemSoMayTinhBH1Nam(List<MayTinh> arr)
        {
            int soluong = 0;
            foreach (MayTinh m in arr)
            {
                if (m.thoiGianBaoHanh == 1)
                    soluong++;

            }
            return soluong;
        }
        public static List<MayTinh> DanhSachMayTinhTuMy(List<MayTinh> arr, String xuatXu)
        {
            List<MayTinh> arrXX = new List<MayTinh>(0);
            foreach (MayTinh item in arr)
            {
                if (item.NoiSX.ToLower() == xuatXu.ToLower())
                {
                    //Them item vao danh  sach may có xuat xu
                    arrXX.Add(item);
                }
            }
            return arrXX;
        }
        public static void InSoLuongMayTinh(List<MayTinh> arr)
        {
            Console.WriteLine($"so luong may tinh co trong he thong la: {MayTinh.DemSoLuongMayTinh(arr)}");
        }
    }
}
