using Newtonsoft.Json;
class StudentManager
{
    private List<Student> students;
    public string filePath = "student.json";

    public StudentManager()
    {
        LoadData();
    }

    private void LoadData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            students = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
        }
        else
        {
            students = new List<Student>();
        }
    }

    private void SaveData()
    {
        string json = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
        SaveData();
        Console.WriteLine("Học sinh đã được thêm vào!");
    }

    public void AddStudentInfo()
    {
        Console.WriteLine("Nhập ID học sinh: ");
        string studentId = Console.ReadLine();
        Console.WriteLine("Nhập tên học sinh: ");
        string studentName = Console.ReadLine();
        Console.WriteLine("Nhập điểm Toán: ");
        double diemToan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập điểm Văn: ");
        double diemVan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập điểm Anh: ");
        double diemAnh = Convert.ToDouble(Console.ReadLine());

        var student = new Student
        {
            studentId = studentId,
            studentName = studentName,
            diemToan = diemToan,
            diemVan = diemVan,
            diemAnh = diemAnh
        };
        AddStudent(student);
    }

    // Display all students
    public void DisplayAllStudents()
    {
        foreach (var student in students)
        {
            student.displayInfo();
            Console.WriteLine("-------------------");
        }
    }
    public void UpdateStudent()
    {
        Console.WriteLine("Nhập ID học sinh cần cập nhật: ");
        string studentId = Console.ReadLine();

        var student = students.Find(s => s.studentId == studentId);
        if (student == null)
        {
            Console.WriteLine("Học sinh không tồn tại!");
            return;
        }

        Console.WriteLine("Nhập điểm Toán mới: ");
        student.diemToan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập điểm Văn mới: ");
        student.diemVan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập điểm Anh mới: ");
        student.diemAnh = Convert.ToDouble(Console.ReadLine());

        SaveData();
        Console.WriteLine("Điểm số đã được cập nhật!");
    }

    public void DeleteStudent()
    {
        Console.WriteLine("Nhập ID học sinh cần xóa: ");
        string studentId = Console.ReadLine();

        var student = students.Find(s => s.studentId == studentId);
        if (student == null)
        {
            Console.WriteLine("Học sinh không tồn tại!");
            return;
        }

        students.Remove(student);
        SaveData();
        Console.WriteLine("Học sinh đã được xóa!");
    }

    public void DisplayStudentsSortedByDiemTB()
    {
        var sortedStudents = students.OrderBy(s => s.diemTB).ToList();
        foreach (var student in sortedStudents)
        {
            student.displayInfo();
            Console.WriteLine("-------------------");
        }
    }

    public void SearchStudentByName()
    {
        Console.WriteLine("Nhập tên học sinh cần tìm: ");
        string searchName = Console.ReadLine()?.ToLower();

        var foundStudents = students.Where(s => s.studentName.ToLower().Contains(searchName)).ToList();

        if (foundStudents.Count == 0)
        {
            Console.WriteLine("Không tìm thấy học sinh nào với tên đã nhập!");
        }
        else
        {
            Console.WriteLine($"Tìm thấy {foundStudents.Count} học sinh:");
            foreach (var student in foundStudents)
            {
                student.displayInfo();
                Console.WriteLine("-------------------");
            }
        }
    }
    public void DisplayStudentsSortedByName()
    {
        var sortedByName = students.OrderBy(s => s.FirstName).ThenBy(s => s.studentName).ToList();

        Console.WriteLine("\nDanh sách học sinh sắp xếp theo tên (tên riêng):");
        foreach (var student in sortedByName)
        {
            student.displayInfo();
            Console.WriteLine("-------------------");
        }
    }
}

   