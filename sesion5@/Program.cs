using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
 {
        Console.WriteLine("Hello, World!");
    
    //gọi hàm
Console.WriteLine("Mời bạn nhập một số: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (CheckReverse(number3))
        {
            Console.WriteLine($"Số {number3} là số đối xứng");
        }
        else
        {
            Console.WriteLine($"Số {number3} không là số đối xứng");
        }
    }


    // khai báo hàm kiểm tra số đối xứng
    private static bool CheckReverse (int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;
        while (number>0)
        {
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        return reverseNumber == originalNumber;

    }

 #region khai báo hàm kiểm tra số nguyên tố
    private static bool checkPrime (int number)
 {
    if (number<2) return false ;
    for (int count =2; count <= Math.Sqrt(number); count++)
    {
        if (number%count==0) return false;
    }
    return true;
 }
#endregion 

    //khai báo hàm
    private static int tinhTong(int number1, int number2)
    {
        return number1+number2;
    }
}

