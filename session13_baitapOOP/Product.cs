using System.ComponentModel;

class Product
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

    private string description;
    public string Description
    {
        get {return description;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Mô tả sản phẩm không được để trống");
            }
            description = value;
        }
    }

    public Product (int productId,string productName,double price,string description)
    {
        ProductId=productId;
        ProductName=productName;
        Price=price;
        Description=description;
    }

    public virtual void displayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }

}