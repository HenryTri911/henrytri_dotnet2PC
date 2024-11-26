class SinhVien: Nguoi
{
    public string lop;
    public double diemTB;
    public SinhVien 
    (
        string ten,
        string ID,
        string gioiTinh,
        string email,
        string ngaySinh,
        string lop,
        double diemTB
    ): base(ID,ten,ngaySinh,gioiTinh,email)
    {
        this.lop = lop;
        this.diemTB = diemTB;
    }
    public override void inThongTin()
    {
        base.inThongTin();
        Console.WriteLine ($"Lớp: {lop}");
        Console.WriteLine ($"Điểm trung bình: {diemTB}");
    }
}