// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// //khai báo biến

// #region Phép toán cơ bản
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng hai số 5 và 10 là: {add}");
// int minus = 1212121212 - 34343434;
// Console.WriteLine($"kết quả trừ hai số 1212121212 và 34343434 là: {minus}");
// double chia = 999 / 25;
// Console.WriteLine ($"Kết quả chia 999 và 25 lấy phần nguyên là: {chia}");
// double chiadu = 999 % 25;
// Console.WriteLine ($"kết quả chia 999 và 25 lấy phần dư là: {chiadu}");
// #endregion

// #region Numberic toán tử
// int cong = 0; // định nghĩa biến cộng có giá trị mặc định bằng 0
// cong += 10;
// Console.WriteLine($"Numberic toán tử cộng: {cong}");
// int nhan = 300;
// nhan *= 300;
// Console.WriteLine($"Numberic toán tử nhân: {nhan}");

// #endregion

// #region Ép kiểu dữ liệu
// //Convert
// //nhập dữ liệu từ bàn phím => Console.Readline (string)
// Console.WriteLine ("Mời bạn nhập số:");
// string? number = Console.ReadLine ();
// int convertNumber = Convert.ToInt32(number);
// int sum = convertNumber + 8;
// Console.WriteLine($"Value number: {sum}");

// #endregion

// #region Tính chỉ số BMI

// //INPUT
// //chiều cao và cân nặng nhập từ bàn phím
// Console.WriteLine($"mời bạn nhập chiều cao m:");
// string? chieuCao = Console.ReadLine();
// //convert string => double
// double formatChieuCao = Convert.ToDouble(chieuCao);
// Console.WriteLine($"mời bạn nhập cân nặng kg:");
// string? canNang = Console.ReadLine();
// double formatCanNang = Convert.ToDouble(canNang);
// //PROCESS
// //BMI = cân nặng / chiều cao * chiều cao
// //OUTPUT
// // IN RA CHỈ SỐ BMI
// // tạo biến bmi để lưu giá trị của BMI
// double bmi = 0.0;
// bmi = formatCanNang/(formatChieuCao*formatChieuCao);
// Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");

// #endregion

// #region Tính diện tích và chu vi hình tròn
// Console.WriteLine($"mời bạn nhập bán kính hình tròn");
// string? banKinh = Console.ReadLine();
// double formatBankinh = Convert.ToDouble(banKinh);
// double chuVi = 0.0;
// double dienTich = 0.0;
// double PI = Math.PI; //dùng hằng số PI có sẵn trong thư viện Math trong C#
// chuVi = 2 * PI * formatBankinh;
// dienTich = PI * formatBankinh * formatBankinh;
// Console.WriteLine($"chu vi hình tròn là: {chuVi}");
// Console.WriteLine($"diện tích hình tròn là: {dienTich}");
//
// #endregion
