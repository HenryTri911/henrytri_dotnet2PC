public class ThanhToanOnline:IThanhToan
{
    public void ThanhToan(double soTien)
    {
        Console.WriteLine("Mời bạn nhập mã OTP để xác nhận: ");
        string otp = Console.ReadLine();
        Console.WriteLine($"Thanh toán {soTien} online thành công! Mã OTP: {otp}");
    }
}