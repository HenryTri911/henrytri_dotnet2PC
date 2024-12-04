internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Bài tập: Quản lý sản phẩm trong cửa hàng
        // - product: class cha
        //        _productId  _productName    _price   _description
        // - ElectronicProduct
        //        _ warranty
        // - FashionProduct
        //        _size (S, M, L, XL, XXL)
        // - ProductManager
        //       _List       _filePath
        ProductManager productManager = new ProductManager();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n =====Product Management=====");
            Console.WriteLine("1. Add electronic");
            Console.WriteLine("2. Add fashion");
            Console.WriteLine("3. Display all products");
            Console.WriteLine("4. Seach by name");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: 
                    productManager.addElectronic();
                    break;
                case 2:
                    productManager.addFashion();
                    break;
                case 3:
                    productManager.displayAllProduct();
                    break;
                case 4:
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    productManager.searchByName(name);
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}