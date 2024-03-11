using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hướng_đối_tượng
{
    internal class SinhVien
    {
        private int maSV;
        private string tenSV;
        private double diemThiDH;

        #region khai báo mặc định
        //1. khai bao constructor (gán giá trị mặc định cho đối tượng) 
        public SinhVien()
        {
            this.maSV = 208;
            this.tenSV = "Thanh Tuan";
            this.diemThiDH = 0;

        }
        #endregion
        #region khai báo người dùng nhập
        //2. khai báo constructor(gán giá trị do người dùng nhập vào)
        public SinhVien(int maSV, string tenSV, double diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH =diemThiDH;
        }
        #endregion
        #region thay đổi dữ liệu
        // nhap properties để thay đổi dữ liệu
        public int MaSV
        {
            get { return maSV; } // get để đọc giá trị
            set { maSV = value; } //set để thay đổi giá trị
        }          
        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        public double DiemThiDH
        {
            get { return diemThiDH; }
            set {  diemThiDH = value; }
        }

        #endregion
        #region phương thức Tostring 
        // phương thức Tostring
        public override string ToString()
        {
            return this.maSV +"\t"+ this.tenSV;
        }
        #endregion

        //support method (kiểm tra điều kiện cho sv xét điểm)
        private bool ktraDiemThi()
        {
            return (this.diemThiDH -21 > 0);
        }

        // service method (xuất thông tin)
       public void danhSachDH()
        {
            if (ktraDiemThi() == false)
            {
                Console.WriteLine("ktra lai danh sach");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        #region parameter list method
        // parameter list method(phương pháp liệt kê tham số)
        public double diemTB(params double[] arr)
        {
            double s = 0;
            foreach (double t in arr)
            {
               s += t; 
            }
            return s/arr.Count();
        }
        #endregion
    }
}
