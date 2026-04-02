using System;
using System.Collections.Generic;
using System.Text;

namespace QLSinhVien
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }
        public double DiemTB { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string ma, string ten, DateTime ngaySinh, string gioiTinh, string lop, double diem)
        {
            MaSV = ma;
            HoTen = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Lop = lop;
            DiemTB = diem;
        }
    }
}
