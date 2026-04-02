using System;

public class PhanSo
{
    private int tuSo;
    private int mauSo;

    public PhanSo()
    {
        this.tuSo = 0;
        this.mauSo = 1;
    }

    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
        {
            throw new ArgumentException("Mau so khong the bang 0");
        }
        this.tuSo = tuSo;
        this.mauSo = mauSo;
        this.XuLyDau();
        this.RutGon();
    }

    public int TuSo
    {
        get { return tuSo; }
        set { tuSo = value; }
    }

    public int MauSo
    {
        get { return mauSo; }
        set
        {
            if (value == 0) throw new ArgumentException("Mau so khong the bang 0");
            mauSo = value;
        }
    }

    private int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private void XuLyDau()
    {
        if (this.mauSo < 0)
        {
            this.tuSo = -this.tuSo;
            this.mauSo = -this.mauSo;
        }
    }

    public void RutGon()
    {
        int ucln = TimUCLN(this.tuSo, this.mauSo);
        this.tuSo /= ucln;
        this.mauSo /= ucln;
        XuLyDau();
    }

    public PhanSo Cong(PhanSo ps)
    {
        int tuMoi = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo Tru(PhanSo ps)
    {
        int tuMoi = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo Nhan(PhanSo ps)
    {
        int tuMoi = this.tuSo * ps.tuSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo Chia(PhanSo ps)
    {
        if (ps.tuSo == 0) throw new DivideByZeroException("Khong the chia cho 0");
        int tuMoi = this.tuSo * ps.mauSo;
        int mauMoi = this.mauSo * ps.tuSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public double GiaTriThuc()
    {
        return (double)tuSo / mauSo;
    }

    public override string ToString()
    {
        if (mauSo == 1) return tuSo.ToString();
        return tuSo + "/" + mauSo;
    }
}
