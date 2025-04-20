using System;

namespace Lab1._3
{
    class Program
    {
        public static void NhapPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            Console.WriteLine("Phan so 1: ");
            phanSo1.Nhap();
            Console.WriteLine("Phan so 2: ");
            phanSo2.Nhap();
        }

        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            int x;

            Console.WriteLine("Cac phep toan cua phan so:");
            Console.WriteLine("\t1. Nhap 1 neu muon cong");
            Console.WriteLine("\t2. Nhap 2 neu muon tru");
            Console.WriteLine("\t3. Nhap 3 neu muon nhan");
            Console.WriteLine("\t4. Nhap 4 neu muon chia");
            Console.WriteLine("\t5. Nhap 5 neu toi gian");
            Console.Write("- Moi ban nhap lua chon: ");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 + ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} + {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                        break;
                    }
                case 2:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 - ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} - {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                        break;
                    }
                case 3:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 * ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} * {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                        break;
                    }
                case 4:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 / ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} / {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Nhap phan so muon toi gian: ");
                        ps1.Nhap();
                        if (ps1.KiemTra())
                        {
                            Console.WriteLine("Phan so da toi gian.");
                        }
                        else
                        {
                            ps1.ToiGian();
                            Console.WriteLine("Sau khi toi gian: " + ps1.TuSo + "/" + ps1.MauSo);
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Nhap sai !!!");
                    break;
            }
        }
    }
}
