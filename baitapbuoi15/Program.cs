internal class Program
{
    private static void Main(string[] args)
    {

        PaymentManager paymentManager = new PaymentManager();
        IThanhToan paymentMethod = null;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n ----- Hệ Thống Thanh Toán Đa Phương Thức -----");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán Online:");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Chọn một tùy chọn (1-5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                paymentMethod = new ThanhToanTienMat();
                ProcessPayment (paymentMethod, paymentManager, "Tiền mặt");
                break;

                case "2":
                paymentMethod = new ThanhToanBangThe();
                ProcessPayment (paymentMethod, paymentManager, "Thẻ");
                break;

                case "3":
                paymentMethod = new ThanhToanOnline();
                ProcessPayment (paymentMethod, paymentManager, "Online");
                break;

                case "4":
                paymentManager.ViewTransactions();
                break;

                case "5":
                Console.WriteLine("Cám ơn bạn đã sử dụng chương trình");
                return;

                default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại từ 1-5");
                break;
            }
            Console.Write("\n Nhấn Enter để tiếp tục sử dụng");
            Console.ReadLine();
        }
    }
    static void ProcessPayment(IThanhToan paymentMethod, PaymentManager paymentManager, string methodName)
    {
        Console.Write("Nhập số tiền cần thanh toán: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            paymentMethod.ThanhToan(amount);
            paymentManager.AddTransaction(methodName, amount);
        }
        else
        {
            Console.WriteLine("Số tiền không hợp lệ!");
        }
    }
}