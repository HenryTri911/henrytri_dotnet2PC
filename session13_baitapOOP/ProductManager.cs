using Newtonsoft.Json;
class ProductManager
{
    private List<Product> products;
    private string filePath = "product.json";
    private void loadData()
    {
        if(!File.Exists(filePath))
        {
            products = new List<Product>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
    
    public ProductManager()
    {
        loadData();
    }

    private void saveData()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath,json);
    }

    public void addProduct (Product product)
    {
        products.Add(product);
        saveData();
        Console.WriteLine("Product is added");
    }

    public void addElectronic ()
    {
        Console.WriteLine ("Enter product ID:");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine ("Enter price:");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Enter description:");
        string description = Console.ReadLine();
        Console.WriteLine ("Enter warranty:");
        int warranty = Convert.ToInt32(Console.ReadLine());
        Electronic electronic = new Electronic(productId,productName,price,description,warranty);
        addProduct(electronic);
    }

    public void addFashion()
    {
        Console.WriteLine ("Enter product ID:");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine ("Enter description:");
        string description = Console.ReadLine();
        Console.WriteLine ("Enter price:");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine ("Enter size S, M, L, XL, XXL:");
        string size = Console.ReadLine();
        Fashion fashion = new Fashion(productId,productName,price,description,size);
        addProduct(fashion);
    }

    public void displayAllProduct()
    //sắp xếp giảm dần theo giá 
    //(p1,p2) => p2.Price.CompareTo(p1.Price)
    // =>lamda expression
    //synxtax: (input)
    {
        products.Sort((p1,p2)=>p2.Price.CompareTo(p1.Price));
        foreach(Product product in products)
        {
            product.displayInfo();
            Console.WriteLine ("=================================");
        }
    }

    public void searchByName(string name)
    {
        //Tolower() => chuyển chuỗi về chữ thường
        //ToUpper() => chuyển chuỗi về chữ in hoa
        Product product = products.Find(p => p.ProductName.Contains(name));
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            product.displayInfo();
        }
    }
}