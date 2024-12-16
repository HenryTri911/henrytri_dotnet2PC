public class Electric: Product
{
    private double phiBaoHanh;
    public double PhiBaoHanh
    {
        get {return phiBaoHanh;}
        set 
        {
            if (value <0)
            {
                throw new ArgumentException ("% Phí bảo hành không hợp lệ");
            }
            phiBaoHanh = value;
        }
    }

    public Electric(int productId, string productName, double price,double phiBaoHanh)
    :base (productId,productName,price)
    {
        PhiBaoHanh = phiBaoHanh;
    }

    public override double TinhGiaBan()
    {
        return Price + (Price * phiBaoHanh /100);
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Giá bán bao gồm phí bảo hành {phiBaoHanh}% là: {TinhGiaBan()} ");
    }
}