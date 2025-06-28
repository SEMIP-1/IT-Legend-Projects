using System;

public class Student
{
    #region Properties
    public int StudentID { get; set; }
    string _Name;
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name is required");
            }
            else if (value.Length < 300)
            {
                _Name = value;
            }
        }
        get
        {
            return _Name;
        }
    }
    public Major Major { get; set; }
    int _Age;
    public int Age
    {
        set
        {
            if (value > 18)
                _Age = value;
        }
        get
        {
            return _Age;
        }
    }
    public List<Enrollment> Enrollments { get; }
    #endregion

    #region Constructors
    //Default Constructor
    public Student()
    {
        StudentID = 0;
        _Name = "Name Is Not Registered";
        Major = new Major("Major Name Is Not Registered", "Doctor Name Is Not Registered");
        _Age = 18;
        Enrollments = new List<Enrollment>();
    }
    //Parameterized Constructor
    public Student(int ID, string Name, string major, int Age)
    {
        StudentID = ID;
        _Name = Name;
        Major = new Major(major, "Doctor Name Is Not Registered");
        _Age = Age;
        Enrollments = new List<Enrollment>();
    }
    //Copy Constructor
    public Student(Student student)
    {
        StudentID = student.StudentID;
        _Name = student._Name;
        Major = new Major(student.Major);
        _Age = student._Age;
        Enrollments = new List<Enrollment>(student.Enrollments);
    }
    #endregion

    #region Methods

    public void Print()
    {
        Console.WriteLine($@"""
            ID: {this.StudentID}
            Name:  {this._Name}
            Major: {this.Major}
            Age: {this._Age}""
            ");
    }
    public void AddCourse(string CourseName, double grade)
    {
        Enrollment myEnrollment = new Enrollment();
        myEnrollment.NewStudent = this;
        myEnrollment.NewCourse = new Course(0, CourseName, 0);
        myEnrollment.EnrolmentDate = DateTime.Now;
        myEnrollment.StudentGrade = grade;
        this.Enrollments.Add(myEnrollment);
    }

    public void AddCourse(Enrollment myEnrollment)
    {
        this.Enrollments.Add(myEnrollment);
    }
    public void PrintCourse()
    {
        int index = 1;
        foreach (Enrollment MyEnrollment in this.Enrollments)
        {
            Console.WriteLine(index + ". " + MyEnrollment.NewCourse.CourseName);
        }
    }
    #endregion
}
