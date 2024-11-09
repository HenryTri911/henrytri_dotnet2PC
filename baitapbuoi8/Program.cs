
internal class Program
{
    private static void Main()
    {
#region Bài 1
//  IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
//  Bài Toán: Tính tổng các số trong mảng
//  Mô Tả: Bạn được cung cấp 1 mảng số nguyên IstNumber, nhiêm vụ của bạn là tính tổng các số ở trong mảng này
//  Input: IstNumber: Môt danh sách(Mảng) các số nguyên, đây là mảng bạn cần tính tổng
//  Output: Trả về tổng của tất cả các số trong mảng IstNumber
    // {
    //     int[] IstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
    //     int sum = 0;
    //     foreach (int numbers in IstNumber ) {
    //         sum += numbers;
    //     }
    //     Console.WriteLine("Tổng của các số trong mảng là: " + sum);
    // }

#endregion

#region Bài 2
 //Ist_number = [2, 7, 11, 15]
 //Mô Tả: Tìm hai số trong tổng danh sách số nguyên sao cho tổng của chúng bằng môt giá trị target cho trước
 //Ví dụ:
 //Input: Nums = [2, 7, 11, 15], target = 9
 //Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9) ngược lại nếu không có
    // {
    //     int[] nums = { 2, 7, 11, 15 };
    //     int target = 9;

    //     int[] result = Bai2.TwoSum(nums, target);

    //     if (result.Length > 0)
    //     {
    //         Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Không tìm thấy cặp số nào thỏa mãn.");
    //     }
    // }

#endregion

#region Bài 3
 //IstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]
 //Bài Toán: Remove duplicates from sorted Array(Easy)
 //Mô Tả: Loại bỏ các phần tử trùng lăp từ môt mảng đã sắp xếp và trả về chiều dài của mảng mới.
 //Ví dụ: 
 //Input: nums = [1, 1, 2, 2, 2, 3, 4, 4, 5]
 //Output: 5(Mảng mới là [1, 2, 3, 4, 5])
// {
//      int[] nums = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
//         int newLength = Bai3.RemoveDuplicates(nums);

//         Console.WriteLine($"Output: {newLength}");
//         Console.WriteLine("Mảng mới là: ");

//         for (int i = 0; i < newLength; i++)
//         {
//             Console.Write(nums[i] + " ");
//         }
// }

#endregion

#region Bài 4
//  IstNumber = [1, 1, 1, 2, 2, 3]
//  Bài Toán: Remove duplicates from sorted Array(Easy)
//  Mô Tả: Cho 1 mảng số nguyên, tìm phần tử k xuất hiên nhiều nhất trong mảng và trả chúng về dưới dạng danh sách. Nếu có nhiều phần tử cùng tần số xuất hiên trả về bất kì trong số chúng.
//  Ví dụ: 
//  Input: nums =[1, 1, 1, 2, 2, 3] k = 2
//  Output: [1, 2]
//  Giải Thích: trong mảng nums, số 1 xuất hiên 3 lần, số 2 xuất hiên 2 và số 3 xuất hiên 1 lần. Ta cần trả về 2 phần tử xuất hiên nhiều lần nhất chúng có thể là 1 và 2 hoăc ( 2 và 1 )
//  Lưu ý: Kết quả được trả về dưới bất kì thứ tự nào. Số lần xuất hiên của các phần tử không cần tuân theo thứ tự tăng dần
// {
//     int[] nums = { 1, 1, 1, 2, 2, 3 };
//         int k = 2;
//         var result = Bai4.PhanTuNhieuNhat(nums, k);
//         Console.WriteLine(string.Join(", ", result));
// }

#endregion

#region Bài 5
//  prices = [7, 1, 5, 3, 6 ,4]
//  Bài Toán: Best time to Buy and Sell Stock
//  Mô Tả: Cho 1 mảng prices, mỗi phần tử của nó đại diên cho giá của cổ phiếu trong môt ngày. Bạn chỉ được mua cổ phiếu 1 lần và bán cổ phiếu 1 lần. Hãy tìm giá trị lớn nhất từ viêc mua và bán
//  cổ phiếu
//  Ví dụ: 
// Input: nums =[7, 1, 5, 3, 6, 4]
//  Output: 5
//  Giải Thích: Bạn mua vào ngày thứ 2 với giá (1) và bán ra vào ngày thứ (5) với giá 6 lãi 6 - 1 = 5
// {
//         int[] prices = { 7, 1, 5, 3, 6, 4 };
//         int maxProfit = Bai5.MaxProfit(prices);
//         Console.WriteLine(maxProfit);
// }

#endregion
    }
}