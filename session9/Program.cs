internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // // bản chất của OOP là gom nhóm các biến với nhau
        // // các biến được gọi là các thuộc tính
        // // chữ cái đầu tiên của class phải in hoa
        // BaiViet baiviet1 = new BaiViet();
        // baiviet1.tieuDe = "Nhiệm vụ 100 ngày";
        // baiviet1.hinhAnh = "hinh1.png";
        // baiviet1.noiDung = "cuộc gọi giao nhiệm vụ";
        // // Console.WriteLine($"Bài viết 1: {baiviet1.hinhAnh}, {baiviet1.noiDung}, {baiviet1.tieuDe}");
        // baiviet1.xuatThongtin();

        // BaiViet baiviet2 = new BaiViet();
        // baiviet2.tieuDe = "Chủ tịch nước gặp lãnh đạo Trung Quốc";
        // baiviet2.hinhAnh = "hinh2.png";
        // baiviet2.noiDung = "tổng thống mỹ cùng lãnh đạo";
        // baiviet2.xuatThongtin();

       
        #region Bài tập 1
        //tạo đối tượng ( họ tên, tuổi, giới tính, email)
        //xuất thông tin đối tượng
        // HocSinh thongtin = new HocSinh();
        // thongtin.nhapThongTin();
        // Console.WriteLine("---------------------------------------");
        // thongtin.xuatThongtin();
        
        #endregion

        #region Bài tập 2:
        // // tạo đối tượng sản phẩm ( mã sản phẩm, tên sản phẩm, giá, số lượng)
        // //nhập và xuất thông tin sản phẩm
        // SanPham sanPham1 = new SanPham ();
        // sanPham1.nhapSanPham();
        // Console.WriteLine("********************");
        // sanPham1.xuatSanPham();
        #endregion

        #region Bài tập 3:
        // tạo hình chữ nhật với các thuộc tính length, width
        // nhập thông tin, và tính diện tích, chu vi
        Rectangle hinhChuNhat = new Rectangle ();
        hinhChuNhat.nhapThongSo();
        Console.WriteLine("********************");
        hinhChuNhat.tinhThongSo();

        #endregion



    }
}