using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo; 
        public PhanSo(int tu, int mau)
        {
            tuSo = tu;
            mauSo = mau;
        }   
        public void Print()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
        public void NghichDao()
        {
            int temp = tuSo;
            tuSo = mauSo;
            mauSo=temp;
        }
        private int UCLN ()
        {
            int Tong;
            int newTu =Math.Abs(tuSo);
            int newMau = Math.Abs(mauSo);
            while (newTu != 0 && newMau != 0)
            {
                if (newTu > newMau)
                {
                    newTu = newTu % newMau;
                }
                else
                {
                    newMau = newMau % newTu;
                }
            }
            return Tong = newTu + newMau;
        }
        public void RutGon()
        {
            int uocChung = UCLN();
            tuSo = tuSo / uocChung;
            mauSo = mauSo/ uocChung;
        }
        public PhanSo TinhTong(PhanSo y)
        {
            int newTu,newMau;
            newTu = tuSo * y.mauSo + y.tuSo * mauSo;
            newMau = mauSo * y.mauSo;
            PhanSo z = new PhanSo(newTu, newMau);
            return z;
        }
        public PhanSo TinhTru(PhanSo y)
        {
            int newTu, newMau;
            newTu = tuSo * y.mauSo - y.tuSo * mauSo;
            newMau = mauSo * y.mauSo;
            PhanSo z = new PhanSo(newTu, newMau);
            return z;
        }
        public PhanSo TinhNhan(PhanSo y)
        {
            int newTu, newMau;
            newTu = tuSo * y.tuSo;
            newMau = mauSo * y.mauSo;
            PhanSo z = new PhanSo(newTu, newMau);
            return z;
        }
        public PhanSo TinhChia(PhanSo y)
        {
            int newTu, newMau;
            newTu = tuSo * y.mauSo ;
            newMau = mauSo * y.tuSo;
            PhanSo z = new PhanSo(newTu, newMau);
            return z;
        }
    }
}
