using System;
using System.Collections.Generic;

public class MangPhanSo
{
    private List<PhanSo> danhSach;

    public MangPhanSo()
    {
        this.danhSach = new List<PhanSo>();
    }

    public void ThemPhanSo(PhanSo ps)
    {
        danhSach.Add(ps);
    }

    public bool XoaPhanSo(int index)
    {
        if (index >= 0 && index < danhSach.Count)
        {
            danhSach.RemoveAt(index);
            return true;
        }
        return false;
    }

    public PhanSo TongMang()
    {
        PhanSo tong = new PhanSo(0, 1);
        foreach (PhanSo ps in danhSach)
        {
            tong = tong.Cong(ps);
        }
        return tong;
    }

    public PhanSo TimMax()
    {
        if (danhSach.Count == 0) return null;

        PhanSo maxPS = danhSach[0];
        for (int i = 1; i < danhSach.Count; i++)
        {
            if (danhSach[i].GiaTriThuc() > maxPS.GiaTriThuc())
            {
                maxPS = danhSach[i];
            }
        }
        return maxPS;
    }

    public void SapXepTangDan()
    {
        danhSach.Sort((ps1, ps2) => ps1.GiaTriThuc().CompareTo(ps2.GiaTriThuc()));
    }

    public void HienThiMang()
    {
        Console.Write("Danh sach phan so: ");
        for (int i = 0; i < danhSach.Count; i++)
        {
            Console.Write("[" + i + "]" + danhSach[i].ToString() + "  ");
        }
        Console.WriteLine();
    }

    public bool SuaPhanSo(int index, PhanSo psMoi)
    {
        if (index >= 0 && index < danhSach.Count)
        {
            danhSach[index] = psMoi;
            return true;
        }
        return false;
    }

    public PhanSo LayPhanSo(int index)
    {
        if (index >= 0 && index < danhSach.Count)
        {
            return danhSach[index];
        }
        return null;
    }
}
