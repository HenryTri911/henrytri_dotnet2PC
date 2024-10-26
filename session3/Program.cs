
// #region if - else statement
//nhập số nguyên từ bàn phím. In ra số đó là lẻ hay chẵn
// Console.WriteLine($"mời bạn nhập số nguyên");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// if (formatNumber % 2 == 0)
// {
//     Console.WriteLine($" số {formatNumber} là số chẵn");
// }
// else
// {
//     Console.WriteLine($"số {formatNumber} là số lẻ");
// }
// nhập điểm trung bình của học sinh, In ra học lực
// >= 9 xuất sắc
// 8 <= điểm < 9 : giỏi
// 6.5 <= điểm < 8: khá
// 5 <= điểm < 6.5: trung bình
// 3.5 <= điểm < 5: yếu
// < 3.5: kém
// Console.WriteLine($"Mời bạn nhập điểm trung bình của học sinh:");
// string? diemTrungBinh = Console.ReadLine();
// double formatDiem = Convert.ToDouble(diemTrungBinh);
// if (formatDiem >= 9)
// {
//     Console.WriteLine($"Xuất sắc");
// }else if (formatDiem >= 8 && formatDiem < 9) 
//     // kết hợp 2 hoặc nhiều điều kiện
//     // && = và
//     // || => hoặc
//     {   
//         Console.WriteLine($"Giỏi");
// } else if (formatDiem >= 6.5 && formatDiem < 8) 
//     {
//         Console.WriteLine($"Khá");
// } else if (formatDiem >= 5 && formatDiem < 6.5) 
//     {
//         Console.WriteLine($"Trung bình");
// } else if (formatDiem >= 3.5 && formatDiem < 5) 
//     {
//         Console.WriteLine($"Yếu");
// } else {Console.WriteLine($"Quá kém nha em");}

// nhập số có 3 chữ số, sau đó tính tổng 3 chữ số đó
//         Console.WriteLine($"Mời bạn nhập số có 3 chữ số:");
//         string? number = Console.ReadLine();
//         int formatNumber = Convert.ToInt32(number);
//         int hangTram = formatNumber / 100;
//         int hangChuc = formatNumber % 100 /10;
//         int hangDonvi = formatNumber % 10;
//         if (formatNumber >=100 && formatNumber<=999)
//         {
//             Console.WriteLine($"Tổng 3 chữ số là: {hangTram+hangDonvi+hangChuc}");
//     
//         } else {Console.WriteLine($"Số bạn nhập không đúng");}
// #endregion
// Switch case
//c1: dùng switch case
// nhập số trong khoảng từ 1 - 10. đọc ra số đó
Console.WriteLine($"Mời bạn nhập số từ 1 đến 10:");
string? number1 = Console.ReadLine();
int fnumber1 = Convert.ToInt32(number1);
switch (fnumber1)
{
    case 1:
        Console.WriteLine($"số 3");
        break;
    case 2:
        Console.WriteLine($"số hai");
        break;
    case 3:
        Console.WriteLine($"số ba");
        break;
    case 4:
        Console.WriteLine($"số bốn");
        break;
    case 5:
        Console.WriteLine($"số năm");
        break;
    case 6:
        Console.WriteLine($"số sáu");
        break;
    case 7:
        Console.WriteLine($"số bảy");
        break;
    case 8:
        Console.WriteLine($"số tám");
        break;
    case 9:
        Console.WriteLine($"số chín");
        break;
    default:
        Console.WriteLine($"số mười");
        break;
}