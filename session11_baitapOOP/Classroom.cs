class Classroom
{
    // thuộc tính
    public string classID;
    public string className;
    public List<Student> students;

    //constructor

    public Classroom (string classID, string className)
    {
        this.classID=classID;
        this.className=className;
        this.students = new List<Student>();
    }
    // phương thức thêm sinh viên vào lớp
    public void addStudent (Student student) 
    {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }
    // phương thức hiển thị danh sách sinh viên
    public void showStudent ()
    {
        Console.WriteLine($"\n -----Students in class {className}-----");
        foreach (Student student in students)
        {
            student.displayInfo();
        }
    }
    // phương thức tìm kím sinh viên theo mã sinh viên
    public void findStudent (string studentID)
    {
        // dùng vòng lặp
        foreach (Student student in students)
        {
            if(student.studentID==studentID)
            {
                student.displayInfo();
                return;
            }
        }
        // Trường hợp duyệt hết list mà ko có sv nào
        Console.WriteLine($"Student with ID {studentID} not found in class {className}");
    }

    
}