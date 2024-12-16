internal class Program
{
    private static ProductManager productManager = new ProductManager();

    private static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG ===");
            Console.WriteLine("1. Thêm sản phẩm vào danh sách");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu");
            Console.WriteLine("4. Xóa sản phẩm khỏi danh sách theo mã");
            Console.WriteLine("5. Thoát chương trình");
            Console.Write("Chọn một tùy chọn (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ThemSanPham();
                    break;
                case "2":
                    productManager.HienThiDanhSachSanPham();
                    break;
                case "3":
                    productManager.TinhTongGiaTriSanPham();
                    break;
                case "4":
                    XoaSanPham();
                    break;
                case "5":
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }

            Console.WriteLine("\nNhấn Enter để tiếp tục...");
            Console.ReadLine();
        }
    }

    static void ThemSanPham()
    {
        Console.WriteLine("\nChọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        Console.Write("Chọn loại (1-3): ");
        string loai = Console.ReadLine();

        switch (loai)
        {
            case "1":
                productManager.addElectronic();
                break;
            case "2":
                productManager.addFashion();
                break;
            case "3":
                productManager.addFood();
                break;
            default:
                Console.WriteLine("Loại sản phẩm không hợp lệ!");
                break;
        }
    }

    static void XoaSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            productManager.XoaSanPhamTheoMa(productId);
        }
        else
        {
            Console.WriteLine("Mã sản phẩm không hợp lệ!");
        }
    }
}
