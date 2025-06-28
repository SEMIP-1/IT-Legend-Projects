using System;

public class Enrollment
{
    #region Properties
    public Student NewStudent { get; set; }
    public Course NewCourse { get; set; }
    DateTime _EnrolmentDate;
    //validating the date
    public DateTime EnrolmentDate
    {
        set
        {
            if (value >= DateTime.Now)
            {
                _EnrolmentDate = value;
            }
        }
        get
        {
            return _EnrolmentDate;
        }
    }
    double _StudentGrade;
    //validating the grade
    public double StudentGrade
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                _StudentGrade = value;
            }
        }
        get
        {
            return _StudentGrade;
        }
    }
    #endregion

    #region Constructors
    // Default Constructor
    public Enrollment()
    {
        EnrolmentDate = DateTime.Now;
        StudentGrade = 0;
        NewStudent = new Student();
        NewCourse = new Course(0, "Course Name Is Not Registered", 0);
    }
    // Copy Constructor
    public Enrollment(Enrollment MyEnrollment)
    {
        EnrolmentDate = MyEnrollment.EnrolmentDate;
        StudentGrade = MyEnrollment.StudentGrade;
        this.NewStudent = new Student(MyEnrollment.NewStudent);
        this.NewCourse = new Course(MyEnrollment.NewCourse);
    }
    #endregion

    #region Methods

    #endregion
}
