public class Main {
    public static void main(String[] args) {
        MangPhanSo mps = new MangPhanSo();

        mps.themPhanSo(new PhanSo(1, 2));
        mps.themPhanSo(new PhanSo(2, 4));
        mps.themPhanSo(new PhanSo(3, 4));
        mps.themPhanSo(new PhanSo(-1, -3));
        mps.themPhanSo(new PhanSo(5, 2));
        
        mps.hienThiMang();

        PhanSo tong = mps.tongMang();
        System.out.println("Tong = " + tong);

        PhanSo max = mps.timMax();
        System.out.println("Max = " + max);

        mps.sapXepTangDan();
        mps.hienThiMang();
        
        PhanSo p1 = new PhanSo(1, 2);
        PhanSo p2 = new PhanSo(3, 4);
        System.out.println(p1 + " + " + p2 + " = " + p1.cong(p2));
    }
}