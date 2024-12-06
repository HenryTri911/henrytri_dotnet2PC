using Newtonsoft.Json;
class ProductManager
{
    private List<Product> products;
    public string filePath = "product.json";

    private void LoadData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }
        else
        {
            products = new List<Product>();
        }
    }

    public ProductManager()
    {
        LoadData();
    }

    private void SaveData()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath,json);
    }

    public void addProduct (Product product)
    {
        products.Add(product);
        SaveData();
        Console.WriteLine("Sản phẩm đã được thêm vào!");
    }

    public void addProductInfo()
    {
        Console.WriteLine("Nhập mã sản phẩm: ");
        string productId = Console.ReadLine ();
        Console.WriteLine("Nhập tên sản phẩm: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Nhập giá bán: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số lượng tồn kho: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        var product = new Product(productId, productName, price, quantity);
        addProduct(product);
    }

    public void displayAllProduct()
    {
        foreach (var product in products)
        {
            product.displayProduct();
            Console.WriteLine("-------------------");
        }
    }

    public void searchProductByName()
    {
        Console.WriteLine("Nhập tên sản phẩm cần tìm");
        string searchProduct = Console.ReadLine()?.ToLower();
        var foundProduct = products.Where(s=>s.productName.ToLower().Contains(searchProduct)).ToList();
        if (foundProduct.Count==0)
        {
            Console.WriteLine("Không tìm thấy sản phẩm với tên đã nhập");
        }
        else
        {
            Console.WriteLine($"Tìm thấy {foundProduct.Count} sản phẩm:");
            foreach (var product in foundProduct)
            {
                product.displayProduct();
                Console.WriteLine("-------------------");
            }
        }
    }

    public void updateProduct()
    {
        Console.WriteLine("Nhập tên sản phẩm cần cập nhật:");
        string productName = Console.ReadLine ();
        var product = products.Find(s=> s.productName == productName);
        if (product == null)
        {
            Console.WriteLine("Sản phẩm không tồn tại!");
            return;
        }
        Console.WriteLine ("Nhập giá bán mới: ");
        product.price = Convert.ToDouble(Console.ReadLine);
        Console.WriteLine ("Nhập số lượng tồn kho mới: ");
        product.quantity = Convert.ToInt32(Console.ReadLine);
        SaveData();
        Console.WriteLine("Giá bán và số lượng tồn của sản phẩm đã được cập nhật!");
    }

    public void deleteProduct()
    {
        Console.WriteLine ("Nhập mã sản phẩm cần xóa: ");
        string productId = Console.ReadLine();
        var product = products.Find(s => s.productId == productId);
        if (product == null)
        {
            Console.WriteLine("Sản phẩm không tồn tại!");
            return;
        }
        products.Remove(product);
        SaveData();
        Console.WriteLine("Sản phẩm đã được xóa!");
    }

    public void displayProductSortByPrice()
    {
        var sortByprice = products.OrderBy(s => s.price).ToList();
        foreach (var product in sortByprice)
        {
            product.displayProduct();
            Console.WriteLine("----------------------");
        }
    }

    public void displayProductByName()
    {
        var sortedByName=products.OrderBy(s => s.productName).ThenBy(s=>s.productName).ToList();
        Console.WriteLine("\nDanh sách sản phẩm sắp xếp theo tên (chữ cuối cùng):");
        foreach (var product in sortedByName)
        {
            product.displayProduct();
            Console.WriteLine("---------------------");
        }
    }

    public void displayProductWithInventionValue()
    {
        double totalPrice = 0;
        Console.WriteLine("\nDanh sách sản phẩm và giá trị từng sản phẩm:");
        Console.WriteLine("Mã SP\tTên SP\t\tGiá bán\t\tSố lượng\tGiá trị");
        Console.WriteLine("-----------------------------------------------------------");
        foreach (var product in products)
        {
            double productValue= product.price * product.quantity;
            totalPrice += productValue;
            Console.WriteLine($"{product.productId}\t{product.productName}\t\t{product.price:C2}\t\t{product.quantity}\t\t{productValue:C2}");
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"Tổng giá trị kho hàng: {totalPrice:C2}");
    }
}