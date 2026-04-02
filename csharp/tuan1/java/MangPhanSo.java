import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class MangPhanSo {
    private List<PhanSo> danhSach;

    public MangPhanSo() {
        this.danhSach = new ArrayList<>();
    }

    public void themPhanSo(PhanSo ps) {
        danhSach.add(ps);
    }

    public boolean xoaPhanSo(int index) {
        if (index >= 0 && index < danhSach.size()) {
            danhSach.remove(index);
            return true;
        }
        return false;
    }

    public PhanSo tongMang() {
        PhanSo tong = new PhanSo(0, 1);
        for (PhanSo ps : danhSach) {
            tong = tong.cong(ps);
        }
        return tong;
    }

    public PhanSo timMax() {
        if (danhSach.isEmpty()) return null;
        
        PhanSo maxPS = danhSach.get(0);
        for (int i = 1; i < danhSach.size(); i++) {
            if (danhSach.get(i).giaTriThuc() > maxPS.giaTriThuc()) {
                maxPS = danhSach.get(i);
            }
        }
        return maxPS;
    }

    public void sapXepTangDan() {
        Collections.sort(danhSach, (ps1, ps2) -> Double.compare(ps1.giaTriThuc(), ps2.giaTriThuc()));
    }

    public void hienThiMang() {
        System.out.print("Danh sach phan so: ");
        for (PhanSo ps : danhSach) {
            System.out.print(ps.toString() + "  ");
        }
        System.out.println();
    }
}