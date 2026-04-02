public class PhanSo {
    private int tuSo;
    private int mauSo;

    public PhanSo() {
        this.tuSo = 0;
        this.mauSo = 1;
    }

    public PhanSo(int tuSo, int mauSo) {
        if (mauSo == 0) {
            throw new IllegalArgumentException("Mau so khong the bang 0");
        }
        this.tuSo = tuSo;
        this.mauSo = mauSo;
        this.xuLyDau();
        this.rutGon();
    }

    public int getTuSo() { return tuSo; }
    public void setTuSo(int tuSo) { this.tuSo = tuSo; }

    public int getMauSo() { return mauSo; }
    public void setMauSo(int mauSo) {
        if (mauSo == 0) throw new IllegalArgumentException("Mau so khong the bang 0");
        this.mauSo = mauSo;
    }

    private int timUCLN(int a, int b) {
        a = Math.abs(a);
        b = Math.abs(b);
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private void xuLyDau() {
        if (this.mauSo < 0) {
            this.tuSo = -this.tuSo;
            this.mauSo = -this.mauSo;
        }
    }

    public void rutGon() {
        int ucln = timUCLN(this.tuSo, this.mauSo);
        this.tuSo /= ucln;
        this.mauSo /= ucln;
        xuLyDau();
    }

    public PhanSo cong(PhanSo ps) {
        int tuMoi = this.tuSo * ps.mauSo + ps.tuSo * this.mauSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo tru(PhanSo ps) {
        int tuMoi = this.tuSo * ps.mauSo - ps.tuSo * this.mauSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo nhan(PhanSo ps) {
        int tuMoi = this.tuSo * ps.tuSo;
        int mauMoi = this.mauSo * ps.mauSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public PhanSo chia(PhanSo ps) {
        if (ps.tuSo == 0) throw new ArithmeticException("Khong the chia cho 0");
        int tuMoi = this.tuSo * ps.mauSo;
        int mauMoi = this.mauSo * ps.tuSo;
        return new PhanSo(tuMoi, mauMoi);
    }

    public double giaTriThuc() {
        return (double) tuSo / mauSo;
    }

    @Override
    public String toString() {
        if (mauSo == 1) return String.valueOf(tuSo);
        return tuSo + "/" + mauSo;
    }
}