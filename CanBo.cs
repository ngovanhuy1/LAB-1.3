using System;
using System.Collections.Generic;

namespace Lab1._3
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
        }
    }

    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Bac (vd: 3/7): ");
            Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loai: Cong nhan, Bac: {Bac}");
        }
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nganh dao tao: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loai: Ky su, Nganh dao tao: {NganhDaoTao}");
        }
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Cong viec: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Loai: Nhan vien, Cong viec: {CongViec}");
        }
    }

    class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void ThemCanBo()
        {
            Console.WriteLine("Chon loai can bo muon them:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Lua chon: ");
            int loai = int.Parse(Console.ReadLine());
            CanBo cb = null;

            switch (loai)
            {
                case 1:
                    cb = new CongNhan();
                    break;
                case 2:
                    cb = new KySu();
                    break;
                case 3:
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            cb.Nhap();
            danhSachCanBo.Add(cb);
            Console.WriteLine("==> Da them can bo thanh cong!");
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhap ho ten can tim: ");
            string ten = Console.ReadLine();
            bool timThay = false;
            foreach (var cb in danhSachCanBo)
            {
                if (cb.HoTen.ToLower().Contains(ten.ToLower()))
                {
                    cb.HienThi();
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay can bo nao!");
            }
        }

        public void HienThiTatCa()
        {
            Console.WriteLine("Danh sach can bo:");
            foreach (var cb in danhSachCanBo)
            {
                cb.HienThi();
                Console.WriteLine("-------------------");
            }
        }
    }
}
