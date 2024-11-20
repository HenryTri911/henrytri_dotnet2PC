using System.Reflection.Metadata;

class HocSinh 
{
    public string name;
    public int old;
    public string gender;
    public string email;

    public void nhapThongTin () 
    {
        Console.WriteLine("Nhập tên:");
        name = Console.ReadLine();
        Console.WriteLine("Nhập tuổi");
        old = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Nhập giới tính");
        gender = Console.ReadLine();
        Console.WriteLine("Nhập email");
        email = Console.ReadLine ();
    }
     public void xuatThongtin () 
    {
        Console.WriteLine("Thông tin học sinh:");
        Console.WriteLine($"Họ tên: {name}");
        Console.WriteLine($"Giới tính: {gender}");
        Console.WriteLine($"Tuổi: {old}");
        Console.WriteLine($"Email: {email}");

    }
}
