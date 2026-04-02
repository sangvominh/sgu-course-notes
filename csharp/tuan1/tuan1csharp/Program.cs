using System;

class Program
{
    static MangPhanSo mps = new MangPhanSo();

    static void Main(string[] args)
    {
        int luaChon;
        do
        {
            HienThiMenu();
            Console.Write("Nhap lua chon: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    ThemPhanSo();
                    break;
                case 2:
                    SuaPhanSo();
                    break;
                case 3:
                    XoaPhanSo();
                    break;
                case 4:
                    mps.HienThiMang();
                    break;
                case 5:
                    TinhTong();
                    break;
                case 6:
                    TimMax();
                    break;
                case 7:
                    mps.SapXepTangDan();
                    Console.WriteLine("Da sap xep tang dan!");
                    mps.HienThiMang();
                    break;
                case 8:
                    ThucHienPhepTinh();
                    break;
                case 0:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
            Console.WriteLine();
        } while (luaChon != 0);
    }

    static void HienThiMenu()
    {
        Console.WriteLine("========== QUAN LY PHAN SO ==========");
        Console.WriteLine("1. Them phan so");
        Console.WriteLine("2. Sua phan so");
        Console.WriteLine("3. Xoa phan so");
        Console.WriteLine("4. Hien thi danh sach");
        Console.WriteLine("5. Tinh tong mang");
        Console.WriteLine("6. Tim phan so lon nhat");
        Console.WriteLine("7. Sap xep tang dan");
        Console.WriteLine("8. Thuc hien phep tinh 2 phan so");
        Console.WriteLine("0. Thoat");
        Console.WriteLine("=====================================");
    }

    static void ThemPhanSo()
    {
        Console.Write("Nhap tu so: ");
        int tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        int mau = int.Parse(Console.ReadLine());
        try
        {
            mps.ThemPhanSo(new PhanSo(tu, mau));
            Console.WriteLine("Da them phan so thanh cong!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }

    static void SuaPhanSo()
    {
        mps.HienThiMang();
        Console.Write("Nhap vi tri can sua (bat dau tu 0): ");
        int index = int.Parse(Console.ReadLine());
        
        PhanSo psCu = mps.LayPhanSo(index);
        if (psCu == null)
        {
            Console.WriteLine("Vi tri khong hop le!");
            return;
        }
        
        Console.WriteLine("Phan so hien tai: " + psCu);
        Console.Write("Nhap tu so moi: ");
        int tu = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so moi: ");
        int mau = int.Parse(Console.ReadLine());
        
        try
        {
            PhanSo psMoi = new PhanSo(tu, mau);
            mps.SuaPhanSo(index, psMoi);
            Console.WriteLine("Da sua thanh cong!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }

    static void XoaPhanSo()
    {
        mps.HienThiMang();
        Console.Write("Nhap vi tri can xoa (bat dau tu 0): ");
        int index = int.Parse(Console.ReadLine());
        if (mps.XoaPhanSo(index))
            Console.WriteLine("Da xoa thanh cong!");
        else
            Console.WriteLine("Vi tri khong hop le!");
    }

    static void TinhTong()
    {
        PhanSo tong = mps.TongMang();
        Console.WriteLine("Tong cac phan so = " + tong);
    }

    static void TimMax()
    {
        PhanSo max = mps.TimMax();
        if (max != null)
            Console.WriteLine("Phan so lon nhat = " + max);
        else
            Console.WriteLine("Danh sach rong!");
    }

    static void ThucHienPhepTinh()
    {
        Console.WriteLine("Nhap phan so thu nhat:");
        Console.Write("  Tu so: ");
        int tu1 = int.Parse(Console.ReadLine());
        Console.Write("  Mau so: ");
        int mau1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap phan so thu hai:");
        Console.Write("  Tu so: ");
        int tu2 = int.Parse(Console.ReadLine());
        Console.Write("  Mau so: ");
        int mau2 = int.Parse(Console.ReadLine());

        try
        {
            PhanSo p1 = new PhanSo(tu1, mau1);
            PhanSo p2 = new PhanSo(tu2, mau2);

            Console.WriteLine("\nChon phep tinh:");
            Console.WriteLine("1. Cong (+)");
            Console.WriteLine("2. Tru (-)");
            Console.WriteLine("3. Nhan (*)");
            Console.WriteLine("4. Chia (/)");
            Console.Write("Lua chon: ");
            int phep = int.Parse(Console.ReadLine());

            PhanSo ketQua = null;
            string dau = "";
            switch (phep)
            {
                case 1:
                    ketQua = p1.Cong(p2);
                    dau = "+";
                    break;
                case 2:
                    ketQua = p1.Tru(p2);
                    dau = "-";
                    break;
                case 3:
                    ketQua = p1.Nhan(p2);
                    dau = "*";
                    break;
                case 4:
                    ketQua = p1.Chia(p2);
                    dau = "/";
                    break;
                default:
                    Console.WriteLine("Phep tinh khong hop le!");
                    return;
            }
            Console.WriteLine($"{p1} {dau} {p2} = {ketQua}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }
}
