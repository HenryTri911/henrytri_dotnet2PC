using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
#region Bài 1: QUản lý lớp học
        // B1: Quản lý lớp học
        // 1. Lớp học
        //   tạo class Classroom để quản lý lớp học
        //   classID : mã lớp học
        //   className: tên lớp học
        //   danh sách sinh viên trong lớp
        // 2. Sinh viên
        //   studentID: mã sinh viên
        //   studentName: tên sinh viên
        //   age : tuổi
        // 3. yêu cầu chức năng
        //  - Thêm sinh viên vào lớp
        //  - Hiển thị danh sách sinh viên trong lớp
        //  - Tìm sinh viên theo mã sinh viên

        //  Tạo lớp học
        Classroom classroom = new Classroom("C02", "Dotnet02");
        //  Tạo menu:   1.Thêm sinh viên
        //              2.Hiển thị danh sách sinh viên
        //              3.Tìm kím sinh viên theo mã sinh viên
        //              4.Thoát
        // while(true)
        {
            Console.WriteLine("\n -----Classroom Management-----");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Find student by ID");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please enter your choice (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: // Thêm sinh viên
                Console.WriteLine("Enter student ID: ");
                string studentID = Console.ReadLine();
                Console.WriteLine("Enter student name:");
                string studentName = Console.ReadLine();
                Console.WriteLine("Enter student age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(studentID, studentName, age);
                // thêm sinh viên vào lớp
                classroom.addStudent(student);
                // lưu danh sách sinh viên vào file json
                // chuyển danh sách sinh viên vào json 
                var json = JsonConvert.SerializeObject(classroom.students,Formatting.Indented);
                // lưu json vào file
                File.WriteAllText("students.json",json);
                Console.WriteLine("Add student successfully");
                break;

               
                case 2: // Hiển thị danh sách sinh viên
                classroom.showStudent();
                break;

                case 3: //Tìm kím sinh viên theo mã sinh viên
                Console.WriteLine("Enter student ID to find:");
                string ID = Console.ReadLine();
                if ( ID == null)
                {
                    Console.WriteLine ("Student ID is required");
                    break;
                }
                classroom.findStudent(ID);
                break;

                case 4: // thoát
                return;

                default: 
                Console.WriteLine ("Invalid choice. Please enter 1-4");
                break;
            
            }
        }
#endregion

#region Bài 2: Quản lý thư viện
        // 1. Tạo class book để quản lý sách
        //  -bookID: mã sách
        //  -bookName: tên sách
        //  -author: tác giả
        //  -price: giá
        // 2. Tạo class Library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện
        // - Hiển thị danh sách sách trong thư viện
        // - Tìm sách theo mã sách
        // - Thoát
        // Library library = new Library("001", "Room1");

        // while(true)
        // {
        //     Console.WriteLine("\n -----Book Management-----");
        //     Console.WriteLine("1. Add book");
        //     Console.WriteLine("2. Show books");
        //     Console.WriteLine("3. Find book by ID");
        //     Console.WriteLine("4. Exit");
        //     Console.WriteLine("Please enter your choice (1-4)");
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //     switch(choice)
        //     {
        //         case 1: 
        //         Console.WriteLine("Enter book ID: ");
        //         string bookID = Console.ReadLine();
        //         Console.WriteLine("Enter book name:");
        //         string bookName = Console.ReadLine();
        //         Console.WriteLine("Enter author:");
        //         string author = Console.ReadLine();
        //         Console.WriteLine("Enter price:");
        //         double price = Convert.ToDouble(Console.ReadLine());
        //         Book book = new Book(bookID, bookName, author, price);
              
        //         library.addBook(book);
        //         break;
                
        //         case 2: 
        //         library.showBook();
        //         break;

        //         case 3: 
        //         Console.WriteLine("Enter book ID to find:");
        //         string ID = Console.ReadLine();
        //         if ( ID == null)
        //         {
        //             Console.WriteLine ("book ID is required");
        //             break;
        //         }
        //         library.findBook(ID);
        //         break;

        //         case 4:
        //         return;

        //         default: 
        //         Console.WriteLine ("Invalid choice. Please enter 1-4");
        //         break;
        //     }
        // }    

#endregion
    }
}
