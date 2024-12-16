public abstract class Product
{
    private int productId;
    public int ProductId
    {
        get{return productId;}
        set
        {
            if (value<0)
            {
                throw new ArgumentException ("Mã sản phẩm không hợp lệ");
            }
            productId = value;
        }
    }

    private string productName;
    public string ProductName
    {
        get{return productName;}
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tên sản phẩm không được để trống");
            }
            productName = value;
        }
    }

    private double price;
    public double Price
    {
        get{return price;}
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Giá sản phẩm phẩm không hợp lệ");
            }
            price = value;
        }
    }

    public Product (int productId, string productName, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }

    public abstract double TinhGiaBan();

    public virtual void displayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
    }
}