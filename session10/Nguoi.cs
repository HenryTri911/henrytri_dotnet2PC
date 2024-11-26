class Nguoi 
{
    public string ten;
    public string ngaySinh;
    public string ID;
    public string gioiTinh;
    public string email;
    public Nguoi (string ten, string ID, string ngaySinh, string gioiTinh, string email)
    {
        this.ten = ten;
        this.ngaySinh = ngaySinh;
        this.ID = ID;
        this.gioiTinh = gioiTinh;
        this.email = email;
    }
    public virtual void inThongTin ()
    {
        Console.WriteLine($"ID:{ID} ");
        Console.WriteLine($"Tên: {ten}");
        Console.WriteLine($"Tuổi: {ngaySinh}");
        Console.WriteLine($"Giới tính:{gioiTinh} ");
        Console.WriteLine($"Email: {email}");
    }

    
}