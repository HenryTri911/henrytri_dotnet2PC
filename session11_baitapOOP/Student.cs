class Student
{
    public string studentID;
    public string studentName;
    public int age;

    public Student ( string studentID, string studentName, int age)
    {
        this.studentID = studentID;
        this.studentName=studentName;
        this.age=age;
    }
    // phương thức để hiển thị thông tin sinh viên

    public void displayInfo ()
    {
        Console.WriteLine($"ID: {studentID}");
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Tuổi: {age}");
    }

}