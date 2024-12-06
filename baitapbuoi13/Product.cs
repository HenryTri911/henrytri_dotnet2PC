class Product
{
    public string productId;
    public string productName;
    public double price;
    public int quantity;

    public Product(string productId, string productName, double price, int quantity) {
        this.productId = productId;
        this.productName = productName;
        this.price=price;
        this.quantity=quantity;
    }

    public void displayProduct()
    {
        Console.WriteLine($"Mã sản phẩm: {productId}");
        Console.WriteLine($"Tên sản phẩm: {productName}");
        Console.WriteLine($"Giá bán: {price}");
        Console.WriteLine($"Số lượng tồn kho: {quantity}");
    }

}