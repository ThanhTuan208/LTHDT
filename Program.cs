using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hướng_đối_tượng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien();

            // giá trị mặc định
            Console.WriteLine(sv1.MaSV);
            Console.WriteLine(sv1.TenSV);

            // gía trị do người dùng nhập 
            //SinhVien sv3 = new SinhVien(3, "Tang Thi Dieu Huong");
            //Console.WriteLine(sv3.TenSV);

            // sửa đổi dữ liệu 
            sv2.TenSV = "Dieu Huong";
            Console.WriteLine(sv2.TenSV);
            sv2.MaSV = 169;
            Console.WriteLine(sv2.MaSV);


            // phương thức tostring
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());

            SinhVien sv = new SinhVien(208, "Nguyen Thanh Tuan", 22);
            sv.danhSachDH();

            // parameter list method (phương pháp liệt kê tham số)
            Console.WriteLine(sv.diemTB(6, 7, 8));

            SVcaitien SvCt = new SVcaitien();
            SvCt.Name = "Huong";
            SvCt.Phone = "03433543xx";
            SvCt.Mail = "huongkhung@gmail.com";
            Console.WriteLine(SvCt.ToString());
            Console.ReadLine();
        }
    }
}
