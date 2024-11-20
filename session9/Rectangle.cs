using System.Formats.Asn1;

class Rectangle 
{
    public int length;
    public int width;
    public void nhapThongSo ()
    {
        Console.WriteLine("Nhập chiều dài (cm):");
        length = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Nhập chiều rộng (cm):");
        width = Convert.ToInt32 (Console.ReadLine());
    }
    public void tinhThongSo ()
    {
        Console.WriteLine
        ($"Diện tích hình chữ nhật với chiều dài {length}cm và chiều rộng {width}cm là: {length*width} cm\u00B2 ");
        Console.WriteLine
        ($"Chu vi hình chữ nhật với chiều dài {length}cm và chiều rộng {width}cm là: {(length+width)*2} cm ");
    }
}