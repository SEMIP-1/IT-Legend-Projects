using System;

public class Course
{
    #region Properties
    public int CourseID { get; set; }
    public string? CourseName { get; set; }
    public int CreditHours
    {
        set
        {
            if (value < 01 || value > 3)
            {
                Console.WriteLine("Credit Hours must be greater than 0 and not more than 3");
            }
            else
            {
                CreditHours = value;
            }
        }
        get
        {
            return CreditHours;
        }
    }

    #endregion

    #region Constructors
    // Default Constructor
    public Course(int ID, string Name, int Credit)
    {
        this.CourseID = ID;
        this.CourseName = Name;
        this.CreditHours = Credit;

    }
    // Copy Constructor
    public Course(Course course)
    {
        this.CourseID = course.CourseID;
        this.CourseName = course.CourseName;
        this.CreditHours = course.CreditHours;
    }
    #endregion

    #region Methods
    public void AddCourse(string CourseName, int CreditHours, int CourseID)
    {
        this.CourseID = CourseID;
        this.CourseName = CourseName;
        this.CreditHours = CreditHours;
    }
    #endregion
}
