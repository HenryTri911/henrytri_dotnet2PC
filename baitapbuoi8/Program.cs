#region Bài 1
//  IstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
//  Bài Toán: Tính tổng các số trong mảng
//  Mô Tả: Bạn được cung cấp 1 mảng số nguyên IstNumber, nhiêm vụ của bạn là tính tổng các số ở trong mảng này
//  Input: IstNumber: Môt danh sách(Mảng) các số nguyên, đây là mảng bạn cần tính tổng
//  Output: Trả về tổng của tất cả các số trong mảng IstNumber
    {
        int[] IstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        int sum = 0;

        for (int i = 0; i < IstNumber.Length; i++)
        {
            sum += IstNumber[i];
        }

        Console.WriteLine("Tổng của các số trong mảng là: " + sum);
    }

#endregion