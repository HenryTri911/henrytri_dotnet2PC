public class ThanhToanTienMat:IThanhToan
{
    public void ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toán {soTien} bằng tiền mặt thành công!");
    }
}