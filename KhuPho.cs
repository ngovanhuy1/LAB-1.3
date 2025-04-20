using System;
using System.Collections.Generic;

namespace Lab1._3
{
    // Lớp Nguoi - Quản lý thông tin cá nhân
    public class Nguoi
    {
        public string SoChungMinh { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public void Nhap()
        {
            Console.Write("So chung minh nhan dan: ");
            SoChungMinh = Console.ReadLine();
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine($"Số CMND: {SoChungMinh}, Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
        }
    }

    // Lớp KhuPho - Quản lý thông tin các hộ gia đình (mỗi hộ là một đối tượng KhuPho)
    public class KhuPho
    {
        public int SoNha { get; set; }
        public int SoThanhVien { get; set; }
        public List<Nguoi> ThanhVien { get; set; }

        public KhuPho()
        {
            ThanhVien = new List<Nguoi>();
        }

        public void Nhap()
        {
            Console.Write("So nha: ");
            SoNha = int.Parse(Console.ReadLine());
            Console.Write("So thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin thanh vien thu {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                ThanhVien.Add(nguoi);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"Số nhà: {SoNha}, Số thành viên: {SoThanhVien}");
            foreach (var nguoi in ThanhVien)
            {
                nguoi.HienThi();
                Console.WriteLine("------------------------");
            }
        }
    }

    // Lớp QuanLyKhuPho - Quản lý danh sách các hộ gia đình
    public class QuanLyKhuPho
    {
        private List<KhuPho> khuPhos;

        public QuanLyKhuPho()
        {
            khuPhos = new List<KhuPho>();
        }

        public void NhapKhuPho()
        {
            Console.Write("Nhap so luong ho dan (n): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho ho gia dinh thu {i + 1}:");
                KhuPho khuPho = new KhuPho();
                khuPho.Nhap();
                khuPhos.Add(khuPho);
            }
        }

        public void TimKiemTheoHoTen(string hoTen)
        {
            bool timThay = false;
            foreach (var khuPho in khuPhos)
            {
                foreach (var nguoi in khuPho.ThanhVien)
                {
                    if (nguoi.HoTen.ToLower().Contains(hoTen.ToLower()))
                    {
                        Console.WriteLine("Ho gia dinh: ");
                        khuPho.HienThi();
                        timThay = true;
                        break;
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Khong tim thay ho gia dinh nao.");
            }
        }

        public void TimKiemTheoSoNha(int soNha)
        {
            bool timThay = false;
            foreach (var khuPho in khuPhos)
            {
                if (khuPho.SoNha == soNha)
                {
                    Console.WriteLine("Ho gia dinh: ");
                    khuPho.HienThi();
                    timThay = true;
                    break;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Khong tim thay ho gia dinh nao.");
            }
        }

        public void HienThiToanBoKhuPho()
        {
            Console.WriteLine("\nDanh sach cac ho gia dinh trong khu pho:");
            foreach (var khuPho in khuPhos)
            {
                khuPho.HienThi();
                Console.WriteLine("=====================================");
            }
        }
    }
}
