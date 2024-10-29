
// // // while : dùng khi không biết rõ số lần lặp
// // // quan trọng nhất là phải xác định điều kiện dừng
// // // for : dùng khi biết rõ số lần lặp
// // // do ... while : làm 1 lần trước khi vào vòng lặp  
// // #region While Statement
// //  //in ra các số từ 1 đến n với n là số được nhập từ bàn phím
// //  //B1: khởi tạo giá trị lặp
// //  //B2: xác định điều kiện lặp ( tính tới trường hợp dừng )
// //  //B3: thay đổi điều kiện lặp
// // //  Console.WriteLine("Mời bạn nhập số:");
// // //  string? number = Console.ReadLine();
// // //  int formatnumber = Convert.ToInt32(number);
// // //  int count = 1;
// // //  while (count <= formatnumber)
// // //  {
// // //      Console.WriteLine(count);
// // //      count++; // ++ là count = count +1
// // //  }

// //  //nhập số n từ bàn phím. In ra tổng các số từ 1-n
// //  //Sum = 1+2+3+...+n
// // //  Console.WriteLine($"Mời bạn nhập số:");
// // //  string? number = Console.ReadLine();
// // //  int formatnumber = Convert.ToInt32(number);
// // //  int count = 1;
// // //  int sum = 0;
// // //  while (count <= formatnumber)
// // //  {
// // //      sum += count; //sum = sum + count
// // //      count++; // count = count + 1 hoặc count +=1
// // //  }
// // //  Console.WriteLine($"Tổng các số từ 1 đến {number}  là:{sum}");

// // //tính giai thừa của 1 số
// //  Console.WriteLine($"Mời bạn nhập số");
// //  int number = Convert.ToInt32(Console.ReadLine());
// //  int count = 1;
// //  int factorial = 1;
// //  while (count <= number)
// //  {
// //      factorial *= count; // factorial = fatorial * count
// //      count++;
// //  }
// //  Console.WriteLine($"Giai thừa của số {number} là: {factorial}");

//  //tính bảng cửu chương
// //  Console.WriteLine($"Mời bạn nhập bảng cửu chương muốn in:");
// //  int number = Convert.ToInt32(Console.ReadLine());
// //  int count = 1;
// //  while (count <= 10)
// //  {
// //      Console.WriteLine($"  {number} * {count} = {count*number}");
// //      count++;
// //  }
  

//  //KIỂM TRA SỐ CÓ PHẢI SỐ NGUYÊN TỐ HAY KO
// //  Console.WriteLine($"Mời bạn nhập số muốn kiểm tra:");
// //  int number = Convert.ToInt32(Console.ReadLine());
// //  int count = 2; // 2 là số nguyên tố nhỏ nhất
// //  while (count < number) 
// //  {
// //      if (number % count == 0)
// //      {
// //          Console.WriteLine($"Số {number} không phải số nguyên tố");
// //          break;
// //      }
// //      count++;
// //  }
// //     if (count == number )
// //  {
// //      Console.WriteLine($"Số {number} là số nguyên tố");
// //  }
// // #endregion
// // #region for Statement
// // in bảng cửu chương
// // int number = Convert.ToInt32(Console.ReadLine());
// // for (int count = 1; count <= 10; count++)
// // {
// //     Console.WriteLine($"{count} * {number} = {count*number}");
// // }

// // in số nguyên tố
// //  Console.WriteLine($"Mời bạn nhập số:");
// //  int number = Convert.ToInt32(Console.ReadLine());
// //  int count;
// //  for (count = 2; count < number; count++)
// //  {
// //      if (number % count == 0)
// //      {
// //          Console.WriteLine($"Số {number} không phải số nguyên tố");
// //          break;
// //      }
// //  }
// //      if (count == number )
// //  {
// //          Console.WriteLine($"Số {number} là số nguyên tố");

// //  }

//******* Ma trận
//for lồng nhau => ma trận ( nhiều mảng kết hợp với nhau )
// Console.WriteLine("Mời bạn nhập chiều dài:");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(("Mời bạn nhập chiều rộng"));
// int column = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < column; i++)
// {
//     for (int j = 0; j < row; j++)
//     {
//         Console.Write("*");
//     }
//     Console.Write("\n"); //Console.WriteLine()
// }

// In ra tam giác cân tương ứng khi nhập số nguyên
// i = 0: ___*     => height - i- 1
// i = 1: __***    => height =2, in ra 2_ và 3*
// i = 2: _*****   => height =3, in ra 1_ và 5*
// i = 3: *******
// j = 2*i+1
Console.WriteLine("Mời bạn nhập số nguyên:");
int height = Convert.ToInt32(Console.ReadLine());
for(int i =0; i < height; i++)
//in khoảng trắng
{   for(int j = 0; j <height-i-1;j++)
    {
        Console.Write(" ");
    }
//in dấu *
    for(int k = 0;k<(2*i+1);k++)    
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


// // #endregion

