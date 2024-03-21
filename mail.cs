using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace Nam_Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string str = Console.ReadLine();
            //int inHoa = DemKyTuInHoa(str);
            //Console.WriteLine("So ky tu in hoa: " + inHoa);
            //int ktSo = DemKyTuChuSo(str);
            //Console.WriteLine("So ky tu so: " + ktSo);
            //int khacSo = DemKyTuKhacSo(str);
            //Console.WriteLine("So ky tu khac ki tu so: " + khacSo);
            //Console.Write("Nhap ky tu can kiem tra: ");
            //char x = char.Parse(Console.ReadLine());
            //HienThi(str, x);
            //string chuoiNguoc = DoaNguocChuoi(str);
            //Console.WriteLine("Chuoi sau dao nguoc: " + chuoiNguoc);
            //int soTu = DemSoTu(str);
            //Console.WriteLine("So tu trong chuoi: " + soTu);
            Console.WriteLine(TaoEmail(str));

        }
        public static int DemKyTuInHoa(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    count++;
                }
            }
            return count;

        }

        public static int DemKyTuChuSo(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static int DemKyTuKhacSo(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsNumber(str[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool KiemTra(string str, char x)
        {
            bool test = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (x == str[i])
                {
                    test = true;
                }
            }
            return test;
        }
        public static void HienThi(string str, char x)
        {
            if (KiemTra(str, x))
            {
                Console.WriteLine($"Ky tu '{x}' co trong chuoi");
            }
            else
            {
                Console.WriteLine($"Ky tu '{x}' khong co trong chuoi");

            }
        }

        public static string DoaNguocChuoi(string str)
        {
            string chuoiNguoc = System.String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                chuoiNguoc += str[i];
            }
            return chuoiNguoc;
        }

        public static int DemSoTu(string str)
        {
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || str[i] == '\t' || str[i] == '\n')
                {
                    count++;
                }
            }
            return count;
        }

        public static string TaoEmail(string chuoi)
        {
            string str = Regex.Replace(chuoi, /*@"\s+"*/, " ");
            str = str.Trim();
            string[] s = str.Split(' ');
            string kyTuDau = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                kyTuDau += s[i].Substring(0, 1);
            }
            string ten = s[s.Length - 1];
            ten = ten.ToLower();
            kyTuDau = kyTuDau.ToLower();
            return ten + kyTuDau + "@Gmail.Com";
        }
    }
}
