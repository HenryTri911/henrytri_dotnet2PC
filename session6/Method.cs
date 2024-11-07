class Method
{
#region Hàm kiểm tra số nguyên tố
    /// <summary>
    /// Hàm kiểm tra số nguyên tố
    /// </summary>
    /// <param name="number"></param>
    /// <returns>true là số nguyên tố, false là ko phải số nguyên tố</returns>
    public static bool checkPrime(int number)
    {
        if (number<2) 
        {
            return false;
        }
         for (int i = 2; i <= Math.Sqrt (number); i++)
        {
         if (number % i ==0) 
        {
            return false;
        }
    }
        return true; 
    }
#endregion 

#region Hàm in tam giác vuông khi nhập chiều cao
    /// <summary>
    /// Hàm in tam giác vuông khi nhập chiều cao
    /// </summary>
    /// <param name="height"></param>
    public static void printTriangle (int height)
    {   for(int i =1; i <= height; i++)
        {
            for(int j = 1; j<=i;j++)
            {
            Console.Write("*");
            }
        Console.WriteLine();
        }
    }
}    
#endregion
