using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ten: ");
            string tenGoi = Console.ReadLine();

            //1
            int demKyTuHoa = DemKyTuHoa(tenGoi);
            Console.WriteLine(demKyTuHoa);

            //2
            int demKyTuSo = DemKyTuSo(tenGoi);
            Console.WriteLine(demKyTuSo);


            //3
            int khongPhaiKyTuSo = KhongPhaiKyTuSo(tenGoi);
            Console.WriteLine(khongPhaiKyTuSo);


            //4
            char kyTu = 'x';
            bool kiemTraKyTu = KiemTraKyTu(tenGoi, kyTu);
            Console.WriteLine($"Chuoi co chua ky tu '{kyTu}' khong? {kiemTraKyTu}");

            //5
            string daoChuoi = DaoChuoi(tenGoi);
            Console.WriteLine($"Chuoi dao nguoc: {daoChuoi}");

            //6
            int demTu = TongTu(tenGoi);
            Console.WriteLine($"So tu trong chuoi: {demTu}");

            //Tao gmail tu chuoi ky tu nhap vao
            string email = Gmail(tenGoi);
            Console.WriteLine($"Dia chi email Gmail: {email}");
        }

        //Cau 1
        public static int DemKyTuHoa(string tenGoi)
        {
            int count = 0;
            foreach(char c in tenGoi)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        //Cau 2
        public static int DemKyTuSo(string tenGoi)
        {
            int count = 0;
            foreach (char c in tenGoi)
            {
                if (char.IsNumber(c))
                {
                    count++;
                }
            }
            return count;
        }

        //Cau 3
        public static int KhongPhaiKyTuSo(string tenGoi)
        {
            int count = 0;
            foreach (char c in tenGoi)
            {
                if (!char.IsNumber(c))
                {
                    count++;
                }
            }
            return count;
        }

        //Cau 4
        public static bool KiemTraKyTu(string tenGoi, char kyTu)
        {
            return tenGoi.IndexOf(kyTu) != -1;
        }

        //Cau 5
        public static string DaoChuoi(string tenGoi)
        {
            char[] chars = tenGoi.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        //Cau 6
        public static int TongTu(string tenGoi)
        {
            string[] kyTu = tenGoi.Split(' ', '\t', '\n', '\r');
            return kyTu.Length;
        }

        //Cau 7
        public static string Gmail(string tenGoi)
        {
            string a = Regex.Replace(tenGoi, @"\s+", " ");
            string[] names = a.Split(' ');

            string firstName = names[names.Length - 1].Replace(" ", string.Empty).ToLower();

            for (int i = 0; i < names.Length-1; i++)
            {
                firstName += names[i][0];
            }
            /*string lastNameInitial1 = names[0].Substring(0, 1).ToLower();
            string lastNameInitial2 = names[1].Substring(0, 1).ToLower();
            string lastNameInitial3 = names[2].Substring(0, 1).ToLower();*/
            return $"{firstName.ToLower()}@gmail.com";/*$"{firstName}{lastNameInitial1}{lastNameInitial2}{lastNameInitial3}@gmail.com";*/
        }
    }
}
