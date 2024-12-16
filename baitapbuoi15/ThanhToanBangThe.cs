public class ThanhToanBangThe: IThanhToan
{
    public void ThanhToan(double soTien)
    {
        Console.WriteLine("Mời bạn nhập mã PIN để xác nhận giao dịch:");
        string pin = Console.ReadLine();
        Console.WriteLine($"Thanh toán {soTien} bằng thẻ thành công! Mã pin {pin}");
    }
}