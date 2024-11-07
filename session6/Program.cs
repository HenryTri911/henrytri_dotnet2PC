internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Kiểm tra số nguyên tố
        // Console.WriteLine("Mời bạn nhập số:");
        // string? number = Console.ReadLine();
        // int formatnumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime (formatnumber);
        // if (isPrime == true)
        // {
        //     Console.WriteLine ($"Số {number} là số nguyên tố");
        // } else
        // {
        //     Console.WriteLine ($"Số {number} không là số nguyên tố");
        // }    
        #endregion

        #region In ra tam giác giác vuông
        // Console.WriteLine ("Mời bạn nhập chiều cao");
        // string? height = Console.ReadLine();
        // int formatheight = Convert.ToInt32 (height);
        // Method.printTriangle (formatheight);
        #endregion 

        #region Collection trong C#
        // data structure
        // List
        // List<int> number = new List<int>();

        // // define giá trị ban đầu 
        // List<string> names = new List<string> {"Phuong","Duc","Tri","Hung","Linh"};
        // // index                                   0      1     2     3       4
        // // reverseIndex                            ^5     ^4    ^3    ^2      ^1
        // Console.WriteLine($"Phần tử thứ 2 là: {names[2]}");
        // Console.WriteLine($"Phần tử nghịch đảo là: {names[^4]}");
        // //Lưu ý: WriteLine chỉ in được giá trị cho những kiểu dữ liệu nguyên thủy: int, float, double, string,... ( Còn kiểu dữ liệu Collection thì chỉ in ra địa chỉ vùng nhớ của biến đó)
        // Console.Write(String.Join(", ",names));

        //bài tập: nhập n từ bàn phím. Sau đó nhập n phần tử và xuất ra n phần từ
        Console.WriteLine("Mời bạn nhập số lượng phần tử:");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        //tạo biến chứa danh sách phần từ
        List<int> listNumbers = new List<int>();
        for (int i =0; i < formatNumber; i++){
            //C1: dùng insert
            Console.WriteLine($"Nhập phần tử thứ {i+1}");
            string item = Console.ReadLine();
            int formatItem = Convert.ToInt32 (item);
            // listNumbers.Insert(i, formatItem);
            //C2: dùng Add ( thêm phần tử vào cuối danh sách )
            listNumbers.Add(formatItem);
        } 
            // in list phần tử ra ngoài màn hình
            // sẽ có 2 các duyệt phần tử: for hoặc foreach
            // C1: for
            Console.WriteLine("Danh sách phần tử dùng for: ");
        for(int i =0; i<listNumbers.Count;i++){
            Console.WriteLine(listNumbers[i]);
        }
            // C2: foreach
        Console.WriteLine("Danh sách phần tử dùng foreach: ");
        foreach(int item in listNumbers) {
            Console.WriteLine(item);
        }
        #endregion
    }
}





























    


