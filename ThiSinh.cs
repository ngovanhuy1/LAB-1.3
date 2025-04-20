using System;

namespace Lab1._3
{
    public class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public double UuTien { get; set; }

        public virtual double TinhTongDiem() => 0;

        public virtual void Nhap()
        {
            Console.Write("So bao danh: ");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Diem uu tien: ");
            UuTien = double.Parse(Console.ReadLine());
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"SBD: {SoBaoDanh}, Ho ten: {HoTen}, Dia chi: {DiaChi}, Uu tien: {UuTien}");
        }
    }
}
