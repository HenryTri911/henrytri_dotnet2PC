internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region function trong List của Collection
        // Console.WriteLine("Mời bạn nhập số lượng trong danh sách:");
        //khởi tạo danh sách 
        // List<int> numbers = new List<int>();
        // // nhập n từ bàn phím với n là số lượng phần tử của mảng
        // string? n = Console.ReadLine();
        // int format = Convert.ToInt32(n);
        // for(int i =0; i < format; i++){
        //     Console.WriteLine($"Mời bạn nhập số thứ {i+1}");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        
        // Console.WriteLine("Danh sách phần tử đã nhập là:");
        // }
        // foreach(int number in numbers){
        //     Console.WriteLine(number);
        // }   
        //     // dùng Join
        //     Console.Write (String.Join(",",numbers));

        //     // dùng function Sort để sắp xếp phần tử của mảng
        //     numbers.Sort();
        //     Console.WriteLine();
        //     Console.WriteLine ("Danh sách phần tử đã sắp xếp từ bé đến lớn: ");
        //     Console.Write(String.Join(",",numbers));

        //     //dùng function Reverse()
        //     numbers.Reverse();
        //     Console.WriteLine();
        //     Console.WriteLine ("Danh sách phần tử đã sắp xếp từ lớn đến bé: ");
        //     Console.Write(String.Join(",",numbers));
        
        #endregion

        #region Bài 1: tính tổng các số lớn hơn 50 trong list phần tử
        // //khai báo list phần tử
        // List<int> numbers = new List<int> {20, 64, 65, 32, 98, 105, 95};
        // int sum = Bai1.tinhTongSoLon50(numbers);
        // Console.WriteLine($"Tổng các số lớn hơn 50 của mảng là {sum}");

        #endregion

        #region Bài 2: tìm số lớn nhất của mảng
        //giải thuật: 
        //B1: tìm 1 số bất kì trong mảng làm số lớn nhất (số đầu tiên của mảng)
        //B2: duyệt mảng từ phần tử thứ 2 và so sánh với số đại diện
        //B3: nêý số đại diện nhỏ hơn phần tử đang xét => gán lại
        //B4: nếu số đại diện nhỏ hơn phần tử đang xét => duyệt tiếp
        // int max = Bai2.timSoLonNhat(numbers);
        // Console.WriteLine($"Số lớn nhất của mảng là: {max}");
        #endregion

        #region Bài 3: tìm tất cả những chuỗi bắt đầu bằng chữ m
        // List<string> listString = new List<string> {"banana", "mango", };
        // List<string> results = Bai3.findStartM (listString);
        #endregion

        #region Bài 4: liệt kê những phần tử ko trùng nhau
        // List<int> lstNumbers = new List<int> {1, 1, 1, 2, 3, 3, 3, 3, 4, 4, 5,6};
        // List<int> lstResults = Bai4.uniqueNumbers(lstNumbers);
        // Console.WriteLine($"Danh sách các số không trùng nhau là: ");
        // foreach (int result in lstResults) {
        //     Console.Write (result);
        // }

        #endregion

        #region Dictionary trong Collection
        Dictionary<string, string> dic = new Dictionary<string, string>();
        // them key-value vào dic
        dic.Add("Alice","test");
        dic ["Do"] = "Nam Trung";
        // duyệt dic
        foreach(KeyValuePair<string,string> pointer in dic) {
            // pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }
            // chỉ duyệt mỗi key hoặc value => giống như bên List
            // chỉ duyệt Key
            Console.WriteLine("danh sách các key là: ");
        foreach(string str in dic.Keys) {
            Console.WriteLine(str);
            // C2:
            for(int i =0; i < dic.Keys.Count; i++) {
                Console.WriteLine(dic.Keys.ElementAt(i));
            }
            //update value cho dic
            dic["Alice"] = "Johnson";
            Console.WriteLine ("Dic sau khi update: ");
            foreach (KeyValuePair<string,string> pointer in dic) {
                Console.WriteLine($" Họ: {pointer.Key}, Tên: {pointer.Value}");
            }

            //xóa key-value trong dic
            dic.Remove ("Alice");
            Console.WriteLine ("Dic sau khi remove: ");
            foreach (KeyValuePair<string,string> pointer in dic) {
                Console.WriteLine($" Họ: {pointer.Key}, Tên: {pointer.Value}");
            }
        

        #endregion




        }
    }
}