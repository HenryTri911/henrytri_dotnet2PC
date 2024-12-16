public class Fashion : Product
{
    private double sale;
    public double Sale
    {
        get {return sale;}
        set 
        {
            if (value<0)
            {
                throw new ArgumentException ("% giảm giá không hợp lệ");
            }
            sale = value;
        }
    }

    public Fashion(int productId, string productName, double price, double sale)
    :base (productId,productName,price)
    {
        Sale = sale;
    }

    public override double TinhGiaBan()
    {
        return Price - (Price * sale / 100);
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Giá bán đã giảm {sale}% là: {TinhGiaBan()}");
    }
}