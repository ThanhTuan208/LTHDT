using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_10._4_cau4_ch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so gdich: ");
            int n = int.Parse(Console.ReadLine());
            GDtiente[] arr = new GDtiente[n];

            //NhapGDTienTe(arr);
            //XuatGDTienTe(arr);
            //int total = TongSL(arr);
            //Console.WriteLine(total);

            GDvang[] arr1 = new GDvang[n];
            TBTienTe(arr);
            

            GDvang aa = new GDvang();
          
            
        }
        static void TBTienTe(GDtiente[] arr)
        {
            GDtiente average;           
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new GDtiente();
                arr[i] = new GDtiente("m1", DateTime.Today, arr[i].DonGia = double.Parse(Console.ReadLine()), arr[i].SoLuong = int.Parse(Console.ReadLine()), arr[i].TiGia = int.Parse(Console.ReadLine()), "VietNam");
                Console.WriteLine(arr[i].ThanhTien()/ arr.Length);
            }

        }
        static int TongSL(GDtiente[] arr)
        {
            int VN = 0, USD = 0, Euro=0;
            for (int i = 0; i < arr.Length; i++)
            {               
                Console.WriteLine("nhap loai tien can tinh tong: ");
                arr[i].LoaiTien = Console.ReadLine();
                if (arr[i].LoaiTien == "VietNam")
                {
                    VN++;
                }
                else if (arr[i].LoaiTien == "USD")
                {
                    USD++;
                }
                else
                {
                    Euro++;
                }
            }
            return VN + USD + Euro;
        }
        static void NhapGDTienTe(GDtiente[] arr)
        {
            for(int i =0; i< arr.Length; i++)
            {
                arr[i] = new GDtiente();
                Console.Write("maGD: ");
                arr[i].MaGD = Console.ReadLine();
                Console.Write("ngayGD: ");
                arr[i].NgayGD = DateTime.Parse(Console.ReadLine());
                Console.Write("don gia: ");
                arr[i].DonGia = double.Parse(Console.ReadLine());
                Console.Write("so luong: ");
                arr[i].SoLuong = int.Parse(Console.ReadLine());
                Console.Write("ti gia: ");
                arr[i].TiGia = int.Parse(Console.ReadLine());
                Console.Write("loai tien: ");
                arr[i].LoaiTien = Console.ReadLine();

            }
        }
        static void XuatGDTienTe(GDtiente[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].MaGD,-5} {arr[i].NgayGD,-5} {arr[i].DonGia,-5} {arr[i].SoLuong} {arr[i].TiGia} {arr[i].LoaiTien}");
            }
        }
    }
}
