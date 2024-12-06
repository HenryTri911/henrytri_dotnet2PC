using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
class Student
{
    public string studentId;
    public string studentName;
    public double diemToan;
    public double diemVan;
    public double diemAnh;
    public double diemTB
    => (diemToan+diemAnh+diemVan)/3;
    public string XepLoai
    {
        get
        {
            if (diemTB < 5) return "Yếu";
            if (diemTB < 6.5) return "Trung Bình";
            if (diemTB < 8) return "Khá";
            return "Giỏi"; 
        }
    }

    public void displayInfo()
    {
        Console.WriteLine($"Mã học sinh: {studentId}");
        Console.WriteLine($"Tên học sinh: {studentName}");
        Console.WriteLine($"Điểm toán: {diemToan}");
        Console.WriteLine($"Điểm Văn: {diemVan}");
        Console.WriteLine($"Điểm Anh: {diemAnh}");
        Console.WriteLine($"Điểm trung bình: {diemTB}");
        Console.WriteLine($"Xếp loại: {XepLoai}");
    }

    public string FirstName
    {
    get
    {
        var nameParts = studentName.Split(' ');
        return nameParts.Length > 0 ? nameParts.Last() : string.Empty;
    }
    }
}
