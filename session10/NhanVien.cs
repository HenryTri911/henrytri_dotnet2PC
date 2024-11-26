class NhanVien
{
    public string maNV;
    private string hoTen {get;set;}
    // Mục đích dùng getter và setter để truy cập vào các thuộc tính private
    public string ngaySinh;
    public int tuoi;
    public string gioiTinh;
    public double luong;
    //overload: nạp chồng phương thức
    //overide: ghi đè phương thức của class cha
    public virtual double tinhLuong ()
    {
        return 1000;
    }
}