class SanPham 
{
    public string maSanPham;
    public string tenSanPham;
    public double giaSanPham;
    public int soLuong;
    public void nhapSanPham()
    {
        Console.WriteLine("Nhập mã sản phẩm:");
        maSanPham = Console.ReadLine();
        Console.WriteLine("Nhập tên sản phẩm:");
        tenSanPham = Console.ReadLine();
        Console.WriteLine("Nhập giá sản phẩm:");
        giaSanPham = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số lượng sản phẩm:");
        soLuong = Convert.ToInt32(Console.ReadLine());
    }
    public void xuatSanPham()
    {
        Console.WriteLine("Thông tin sản phẩm:");
        Console.WriteLine($"Mã sản phẩm: {maSanPham}");
        Console.WriteLine($"Tên sản phẩm: {tenSanPham}");
        Console.WriteLine($"Giá: {giaSanPham}");
        Console.WriteLine($"Số lượng: {soLuong}");
    }
}