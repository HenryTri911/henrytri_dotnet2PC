internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    #region Bài tập 1
    
    // List<int> lst = new List<int> {2,9,6,3,12,45,32,64,38,98};
    // Console.WriteLine("Mời bạn nhập số tổng:");
    // int target= Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Cách 1: Dùng for");
    // if(TwoSum.twoSum(lst,target)==null)
    //     {
    //         Console.WriteLine($"Không có 2 số nào tổng bằng {target}");
    //     }
    // else
    //     {
    //         List<int>indexes =TwoSum.twoSum (lst,target);
    //         Console.WriteLine($"vị trí 2 số có tổng bằng {target} là: {string.Join(',',indexes)}");
    //     }
    // Console.WriteLine("Cách 2: Dùng dictionary");
    // if(TwoSum.twoSumDictionary(lst,target)==null)
    //     {
    //         Console.WriteLine($"Không có 2 số nào tổng bằng {target}");
    //     }
    // else
    //     {
    //         List<int>indexes =TwoSum.twoSum (lst,target);
    //         Console.WriteLine($"vị trí 2 số có tổng bằng {target} là: {string.Join(',',indexes)}");
    //     }
    #endregion

    #region Bài tập 2 
    // // "apple","melon","mango","apple","pineapple","lychee","melon","banana","apple","orange","guava"
    // string[] words = { "apple", "melon", "mango", "apple", "pineapple", 
    //                    "lychee", "melon", "banana", "apple", "orange", "guava" };
    //     Dictionary<string, int> wordCount = TwoSum.solanxuanhien(words);
    //     Console.WriteLine("Số lần xuất hiện của từng từ:");
    //     foreach (var pair in wordCount)
    //     {
    //         Console.WriteLine($"{pair.Key}: {pair.Value}");
    //     }
    #endregion

    #region Khái niệm về cách lưu trữ biến trên RAM
    int number1 = 10;
    int number2 = number1;
    number1 = 30;
    Console.WriteLine($"number1 = {number1}, number2={number2}");

    #endregion
    }
}