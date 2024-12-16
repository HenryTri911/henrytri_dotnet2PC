public class Food: Product
{
    private double phiShip;
    public double PhiShip
    {
        get {return phiShip;}
        set 
        {
            if (value<0)
            {
                throw new ArgumentException ("Phí giao hàng không hợp lệ");
            }
            phiShip = value;
        }
    }

    public Food(int productId,string productName,double price,double phiShip)
    :base (productId,productName,price)
    {
        PhiShip = phiShip;
    }

    public override double TinhGiaBan()
    {
        return Price + phiShip;
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Giá bán đã bao gồm phí vận chuyển là: {TinhGiaBan()}");
    }
}