using Newtonsoft.Json;
internal class Program
{
    static void Main(string[] args)
    {
    #region Bài 1: Quản lý học sinh
        // StudentManager manager = new StudentManager();
        // while (true)
        // {
        //     Console.Clear();
        //     Console.WriteLine("\n--- Quản lý học sinh ---");
        //     Console.WriteLine("1. Thêm học sinh");
        //     Console.WriteLine("2. Hiển thị danh sách học sinh");
        //     Console.WriteLine("3. Hiển thị danh sách theo điểm TB tăng dần");
        //     Console.WriteLine("4. Hiển thị danh sách theo tên (tên riêng)");
        //     Console.WriteLine("5. Tìm kiếm học sinh theo tên");
        //     Console.WriteLine("6. Cập nhật điểm số");
        //     Console.WriteLine("7. Xóa học sinh");
        //     Console.WriteLine("8. Thoát");
        //     Console.Write("Chọn một tùy chọn (1-8): ");
        //     string choice = Console.ReadLine();

        //     switch (choice)
        //     {
        //         case "1":
        //             manager.AddStudentInfo();
        //             break;
        //         case "2":
        //             manager.DisplayAllStudents();
        //             break;
        //         case "3":
        //             manager.DisplayStudentsSortedByDiemTB();
        //             break;
        //         case "4":
        //             manager.DisplayStudentsSortedByName();
        //             break;
        //         case "5":
        //             manager.SearchStudentByName();
        //             break;
        //         case "6":
        //             manager.UpdateStudent();
        //             break;
        //         case "7":
        //             manager.DeleteStudent();
        //             break;
        //         case "8":
        //             Console.WriteLine("Cảm ơn đã sử dụng chương trình!");
        //             return;
        //         default:
        //             Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
        //             break;
        //     }

        //     Console.WriteLine("\nNhấn Enter để tiếp tục...");
        //     Console.ReadLine();
        // }
    #endregion
    

    #region Bài 2: Quản lý sản phẩm
        ProductManager manager1 = new ProductManager();
        while(true)
        {
            Console.Clear();
            Console.WriteLine("\n--- Quản lý sản phẩm ---");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Tìm kiếm sản phẩm theo tên");
            Console.WriteLine("3. Cập nhật giá bán và số lượng tồn kho");
            Console.WriteLine("4. Hiển thị danh sách sản phẩm");
            Console.WriteLine("5. Hiển thị danh sách sản phẩm và tổng giá trị kho hàng");
            Console.WriteLine("6. Hiển thị danh sách sản phẩm theo giá");
            Console.WriteLine("7. Hiển thị danh sách sản phẩm theo tên");
            Console.WriteLine("8. Xóa sản phẩm khỏi danh sách");
            Console.WriteLine("9. Thoát");
            Console.WriteLine("Chọn một tùy chọn (1-9): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                manager1.addProductInfo();
                break;
                case "2":
                manager1.searchProductByName();
                break;
                case "3":
                manager1.updateProduct();
                break;
                case "4":
                manager1.displayAllProduct();
                break;
                case "5":
                manager1.displayProductWithInventionValue();
                break;
                case "6":
                manager1.displayProductSortByPrice();
                break;
                case "7":
                manager1.displayProductByName();
                break;
                case "8":
                manager1.deleteProduct();
                break;
                case "9":
                Console.WriteLine("Cám ơn bạn đã sử dụng chương trình !");
                break;
                default:
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                break;
            }
            Console.WriteLine("\n Nhấn Enter để tiếp tục...");
            Console.ReadLine();

        }

    #endregion

    }
}
