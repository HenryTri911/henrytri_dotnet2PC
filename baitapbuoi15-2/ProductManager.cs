public class ProductManager
{
    private List<Product> products;
    public ProductManager()
    {
        products = new List<Product>();
    }

    public void addProduct (Product product)
    {
        products.Add(product);
        Console.WriteLine("Sản phẩm đã được thêm");
    }

    public void addElectronic()
    {
        Console.WriteLine("Nhập mã sản phẩm điện tử:");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập tên sản phẩm điện tử:");
        string productName = Console.ReadLine();
        Console.WriteLine("Nhập giá gốc:");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập phí bảo hành (%):");
        double phiBaoHanh = Convert.ToDouble (Console.ReadLine());
        Electric electric = new Electric(productId,productName,price,phiBaoHanh);
        addProduct(electric);
    }

    public void addFashion()
    {
        Console.WriteLine("Nhập mã sản phẩm thời trang:");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập tên sản phẩm thời trang:");
        string productName = Console.ReadLine();
        Console.WriteLine("Nhập giá gốc:");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập phí giảm giá (%):");
        double sale = Convert.ToDouble (Console.ReadLine());
        Fashion fashion = new Fashion(productId,productName,price,sale);
        addProduct(fashion);
    }

    public void addFood()
    {
        Console.WriteLine("Nhập mã sản phẩm đồ ăn:");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập tên sản phẩm đồ ăn:");
        string productName = Console.ReadLine();
        Console.WriteLine("Nhập giá gốc:");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập phí giao hàng:");
        double phiShip = Convert.ToDouble (Console.ReadLine());
        Food food = new Food(productId,productName,price,phiShip);
        addProduct(food);
    }

    public void HienThiDanhSachSanPham()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm trống.");
            return;
        }

        Console.WriteLine("\nDanh sách sản phẩm:");
        foreach (var product in products)
        {
            product.displayInfo();
            Console.WriteLine("-----------------------------------");
        }
    }

    public void TinhTongGiaTriSanPham()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Danh sách sản phẩm trống. Không có giá trị để tính.");
            return;
        }

        double tongGiaTri = products.Sum(product => product.TinhGiaBan());
        Console.WriteLine($"Tổng giá trị tất cả sản phẩm là: {tongGiaTri:N0} VND");
    }

    public void XoaSanPhamTheoMa(int productId)
{
    var product = products.FirstOrDefault(p => p.ProductId == productId);
    if (product != null)
    {
        products.Remove(product);
        Console.WriteLine($"Đã xóa sản phẩm có mã {productId}.");
    }
    else
    {
        Console.WriteLine($"Không tìm thấy sản phẩm có mã {productId}.");
    }
}
}