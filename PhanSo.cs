using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    internal class PhanSo
    {
        public double TuSo { get; set; }
        public double MauSo { get; set; }
        public PhanSo()
        {
            TuSo = 1;
            MauSo = 1;
        }
        public PhanSo(double TuSo, double MauSo)
        {
            this.TuSo = TuSo;
            this.MauSo = MauSo;
        }
        public void Nhap()
        {
            Console.Write("-Nhap tu so: ");
            TuSo = double.Parse(Console.ReadLine());
            Console.Write("-Nhap mau so: ");
            MauSo = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Phan so: " + TuSo + "/" + MauSo);
        }
        public bool KiemTra()
        {
            if (MauSo == 1)
            {
                return true;
            }
            for (int i = 2; i <= MauSo; i++)
            {
                if (TuSo % i == 0 && MauSo % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void ToiGian()
        {
            for (int i = (int)MauSo; i > 1; i--)
            {
                if (TuSo % i == 0 && MauSo % i == 0)
                {
                    TuSo = TuSo / i;
                    MauSo = MauSo / i;
                }
            }
        }
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tong = new PhanSo();
            tong.TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo;
            tong.MauSo = ps1.MauSo * ps2.MauSo;
            tong.ToiGian();
            return tong;
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo hieu = new PhanSo();
            hieu.TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo;
            hieu.MauSo = ps1.MauSo * ps2.MauSo;
            hieu.ToiGian();
            return hieu;
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tich = new PhanSo();
            tich.TuSo = ps1.TuSo * ps2.TuSo;
            tich.MauSo = ps2.MauSo * ps1.MauSo;
            tich.ToiGian();
            return tich;

        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo thuong = new PhanSo();
            thuong.TuSo = ps1.TuSo * ps2.MauSo;
            thuong.MauSo = ps1.MauSo * ps2.TuSo;
            thuong.ToiGian();
            return thuong;
        }
    }
}
