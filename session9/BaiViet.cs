class BaiViet 
{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;
//default khi khởi tại đối tượng thì C# sẽ gọi hàm khởi tạo (constructor) mặc định
//hàm khởi tạo này sẽ tạo giá trị mặc định cho các thuộc tính
//cú pháp: public <tên class>(){}
public BaiViet()
{
    Console.WriteLine("đây là hàm khởi tạo");
} 
public BaiViet (string tieuDe, string noiDung, string hinhAnh)
{
    this.tieuDe = tieuDe;
    this.noiDung = noiDung;
    this.hinhAnh = hinhAnh;
}
// khởi tạo hàm constructor
// có 2 loại hàm constructor: có tham số và ko có tham số
//lưu ý: trong class chỉ có thể có nhiều hàm constructor xuất hiện

    public void xuatThongtin ()
    {
        Console.WriteLine("Thông tin bài viết là:");
        Console.WriteLine($"Tiêu đề: {tieuDe}");
        Console.WriteLine($"Nội dung: {noiDung}");
        Console.WriteLine($"Hình ảnh: {hinhAnh}");
    }
}