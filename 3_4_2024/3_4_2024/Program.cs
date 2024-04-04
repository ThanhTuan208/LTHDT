using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_2024
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Tạo danh sách
            List<MayTinh> dachSachMayTinh = new List<MayTinh>();
            {
                dachSachMayTinh.Add(new MayTinh("laptop", "my", 1));
                dachSachMayTinh.Add(new MayTinh("desktop", "Viet Nam", 2));
                dachSachMayTinh.Add(new MayTinh("tablet", "my", 3));
            }
            //In danh sách
            MayTinh.XuatDSThongTin(dachSachMayTinh);

            //1.Dem so máy tính có TG bảo hành 1 năm
            Console.WriteLine("So may tinh bao hanh 1 nam: " + MayTinh.DemSoMayTinhBH1Nam(dachSachMayTinh));



            //2.In danh sach may tinh My
            Console.WriteLine("Danh sach may tinh co xuat xy My: ");
            List<MayTinh> arrUSA = MayTinh.DanhSachMayTinhTuMy(dachSachMayTinh, "Viet Nam");
            if (arrUSA.Count != 0)
            {
                MayTinh.XuatDSThongTin(arrUSA);
            }

            //3.Dem so luong
            MayTinh.InSoLuongMayTinh(dachSachMayTinh);
        }
    }
}
