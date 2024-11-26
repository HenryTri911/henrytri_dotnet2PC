internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*-----Tính KẾ THỪA trong OOP-----*");
        // 4 tính chất trong OOP
        // - Tính kế thừa: class con sẽ kế thừa các thuộc tính ( biến) và phương thức(hàm) của class cha
        // - Tính đóng gói:
        // - Tính trừu tượng:
        // - Tính đa hình:

        // BT mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý.
        // lập trình quản lý nhân sự trong công ty
        // Nhân viên: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương
        // Trưởng nhóm: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm
        // Quản lý: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm, thư ký
        // TruongNhom truongNhom = new TruongNhom();
        // Console.WriteLine(truongNhom.tinhLuong());
        // truongNhom.hoTen = "Nguyễn Văn Tèo";
        // truongNhom.maNV = "NV001";
        // Console.WriteLine($"Tên trưởng nhóm: {truongNhom.hoTen}");
        // Console.WriteLine($"Mã nhân viên: {truongNhom.maNV}");
        // QuanLy quanLy = new QuanLy ();
        // Console.WriteLine (quanLy.tinhLuong());
        // quanLy.luong = 10000;
        // Console.WriteLine($"Lương của quản lý:{quanLy.luong}");
        // C# sẽ check class QuanLy để tìm thuộc tính luong, nếu ko có thì check class cha (TruongNhom), nếu ko có thì check class cha của (TruongNhom) là class (NhanVien)
        // lưu ý overide: nếu class con không muốn dùng logic của class cha thì có thể viết lại phương thức đó trong class con.
        //                nếu class con muốn dùng lại logic của class cha thì dùng từ khóa base.tenPhuongThuc() để gọi phương thức của class cha

        // phạm vi truy cập của thuộc tính và phương thức 
        // public: có thể truy cập từ bất kì đâu: class con, bên ngoài class
        // private: class con và bên ngoài class không thể truy cập. Chỉ có thể truy cập từ chính class đó.
        // protected: class con có thể truy cập các thuộc tính của class cha, nhưng bên ngoài class ko thể truy cập.

        // Bài tập:
        // Sinh viên, Giảng Viên, cán bộ trong trường học
        // viết chương trinh quản lý những đối tượng trên
        // class Nguoi : ID , tên, giới tính, ngày sinh, email
        // sinh viên:  ID , tên, giới tính, ngày sinh, email, lớp, điểm trung bình
        // giảng viên: ID , tên, giới tính, ngày sinh, email, chuyên ngành, học vị
        // cán bộ: ID , tên, giới tính, ngày sinh, email, chức vụ, phòng ban 
        SinhVien sinhVien = new SinhVien ("Nguyễn Văn A","SV001","Nam","vanA@gmail.com","12/09/1991","IT001",8.5);
        sinhVien.inThongTin();


    }
}