namespace _3_ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("Hello, World!");
            Student student = new Student();
            Read UserInput = new Read();

            Console.WriteLine("Please Enter Student ID");
            student.StudentID = UserInput.IntNumber();

            Console.WriteLine("Please Enter Student Name");
            student.Name = UserInput.StringLines();

            Console.WriteLine("Please Enter Student Major");
            student.Major.MajorName = UserInput.StringLines();

            Console.WriteLine("Please Enter Student Age");
            student.Age = UserInput.IntNumber();

            bool IsEnded = true;
            while (IsEnded)
            {
                Console.WriteLine("Please Enter Course Name");
                string CourseName = UserInput.StringLines();
                Console.WriteLine("Please Enter Course Grade");
                double Grade = UserInput.doubleNumber();
                student.AddCourse(CourseName, Grade);
                bool IsEnded2 = true;
                while (IsEnded2)
                {
                    Console.WriteLine("Do you want to add another course? (Y/N)");
                    char choice = UserInput.CharLines();
                    if (choice == 'N' || choice == 'n')
                    {
                        IsEnded = false;
                        IsEnded2 = false;
                    }
                    else if (choice == 'Y' || choice == 'y')
                    {
                        IsEnded = true;
                        IsEnded2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                        IsEnded2 = true;
                    }
                }
            }
            Console.WriteLine("Student Information");
            student.Print();
            Console.WriteLine("Courses:");
            student.PrintCourse();
        }
    }
}
