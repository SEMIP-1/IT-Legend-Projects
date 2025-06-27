namespace ProblemSolving_1
{

    internal class Program
    {
        public void MainProgram()
        {
            bool bIsWorking = true;
            while (bIsWorking)
            {
                WelcomeApp("Problem Solving Level 1");
                Console.WriteLine(
                    $"Avilable apllications\n" +
                    $"1-PrintYourName\n" +
                    $"2-PrintUserName\n" +
                    $"3-Sum2Numbers\n" +
                    $"4-Average3Numbers\n" +
                    $"5-AreaOfRectangle\n" +
                    $"6-AreaOfTriangle\n" +
                    $"7-AreaOfCircle\n" +
                    $"8-PrintFullName\n" +
                    $"9-HalfNumbers\n" +
                    $"10-Swap2Numbers\n" +
                    $"11-FailOrPass\n" +
                    $"12-CanEnterCollage\n" +
                    $"13-OddOfEven\n" +
                    $"14-CenturyOfTheYear\n" +
                    $"15-ValidatePercentage\n" +
                    $"16-WhichIsGreater\n" +
                    $"17-Compare3Numbers\n" +
                    $"18-SalaesSalary\n" +
                    $"20-PrintSumFrom1to99\n" +
                    $"21-PrintMultiplyFrom1toN\n" +
                    $"22-PrintSumFromNto1\n" +
                    $"23-PrintSubtractFromUserInputToN_Numbers\n" +
                    $"24-GetMaximumNumberOfUserChoiceNumbers\n" +
                    $"25-\n");

                int nApplication = 0;
                bool bUserChoise = ReadNumber1("Application Number", out nApplication);
                if (!bUserChoise)
                    return;
                if (nApplication > 25 || nApplication < 0)
                {
                    Console.WriteLine("Please Select From Existing Applications");
                    return;
                }

                SelectProgram(nApplication);

                Console.WriteLine("Do You Want to continue? Yes=y ,No=n");
                string sContinue = ReadLines();
                bIsWorking = (sContinue == "y");
            }
        }
        void SelectProgram(int nChoice)
        {
            switch (nChoice)
            {
                case 1:
                    PrintYourName();
                    break;
                case 2:
                    PrintUserName();
                    break;
                case 3:
                    Sum2Numbers();
                    break;
                case 4:
                    Average3Numbers();
                    break;
                case 5:
                    AreaOfRectangle();
                    break;
                case 6:
                    AreaOfTriangle();
                    break;
                case 7:
                    AreaOfCircle();
                    break;
                case 8:
                    PrintFullName();
                    break;
                case 9:
                    HalfNumbers();
                    break;
                case 10:
                    Swap2Numbers();
                    break;
                case 11:
                    FailOrPass();
                    break;
                case 12:
                    CanEnterCollage();
                    break;
                case 13:
                    OddOfEven();
                    break;
                case 14:
                    CenturyOfTheYear();
                    break;
                case 15:
                    ValidatePercentage();
                    break;
                case 16:
                    WhichIsGreater();
                    break;
                case 17:
                    Compare3Numbers();
                    break;
                case 18:
                    SalesSalary();
                    break;
                case 20:
                    PrintSumFrom1to99();
                    break;
                case 21:
                    PrintMultiplyFrom1toN();
                    break;
                case 22:
                    PrintSumFromNto1();
                    break;
                case 23:
                    PrintSubtractFromUserInputToN_Numbers();
                    break;
                case 24:
                    GetMaximumNumberOfUserChoiceNumbers();
                    break;
                case 25:
                    PrintMultiplyFrom1toN();
                    break;
            }
        }
        #region Helping Methods
        //Helping Method*****************************************************************************
        //Method Read Line
        string ReadLines()
        {
            string? RL = Console.ReadLine();
            return (string.IsNullOrEmpty(RL)) ? "No responece added" : RL;
        }
        //Method Read Number
        int ReadNumber()
        {
            int Number = 0;
            bool isconverted1 = int.TryParse(Console.ReadLine(), out Number);
            if (!isconverted1)
            {
                Console.WriteLine("Plesea, enter a valid number");
                return 0;
            }
            return Number;
        }
        bool ReadNumber1(string FiledName, out int number)
        {
            Console.WriteLine($"Please  enter {FiledName}");
            bool IsConverted = true;
            IsConverted = int.TryParse(Console.ReadLine(), out number);
            if (!IsConverted)
            {
                Console.WriteLine("Plesea, enter a valid number");
                return false;
            }
            return true;
        }
        //Welcome to Application
        void WelcomeApp(string AppName)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Welcome to " + AppName + " application");
            Console.WriteLine("-----------------------------------------");
        }
        #endregion
        #region Apps Methods
        //Apps Methods************************************************************************************
        //#1
        void PrintYourName()
        {
            WelcomeApp("Print Your Name");
            Console.WriteLine("My name is Salah Eldin Mohamed");
        }
        //#2
        void PrintUserName()
        {
            WelcomeApp("Print User Name");
            Console.WriteLine("Welcome to Print User Name");
            Console.WriteLine("Plesea, enter your name");
            string sName = ReadLines();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hello " + sName);
            Console.WriteLine("----------------------------------");
        }
        //#3
        void Sum2Numbers()
        {
            WelcomeApp("Sum 2 Numbers");
            Console.WriteLine("Plesea, enter you first number");
            int nFirstNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you second number");
            int nSecondNumber = ReadNumber();
            Console.WriteLine(nFirstNumber + nSecondNumber);
        }
        void Sum2Numbers1()
        {
            int nFirstNumber = 0;
            bool IsConverted1 = ReadNumber1("first number", out nFirstNumber);
            if (!IsConverted1)
            {
                Console.WriteLine("Plesea, enter a valid number");
                return;
            }
            int nSecondNumber = 0;
            bool IsConverted2 = ReadNumber1("second number", out nSecondNumber);
            if (!IsConverted2)
            {
                Console.WriteLine("Plesea, enter a valid number");
                return;
            }
            Console.WriteLine(nFirstNumber + nSecondNumber);
        }
        //#4
        void Average3Numbers()
        {
            WelcomeApp("Average 3 Numbers");
            Console.WriteLine("Plesea, enter you first number");
            int nFirstNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you second number");
            int nSecondNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you third number");
            int nThirdNumber = ReadNumber();
            Console.WriteLine((nFirstNumber + nSecondNumber + nThirdNumber) / 3);
        }
        //#5
        void AreaOfRectangle()
        {
            WelcomeApp("Area Of Rectangle");
            Console.WriteLine("Plesea, enter height of rectangle");
            int nHeight = ReadNumber();
            Console.WriteLine("Plesea, enter length of rectangle");
            int nLength = ReadNumber();
            Console.WriteLine("Area = " + nHeight + " * " + nLength + " = " + (nHeight * nLength));
        }
        //#6
        void AreaOfTriangle()
        {
            Console.WriteLine("Plesea, enter height of rectangle");
            int nHeight = ReadNumber();
            Console.WriteLine("Plesea, enter base length of rectangle");
            int nBaseLength = ReadNumber();
            Console.WriteLine("Area = 1/2 * " + nHeight + " * " + nBaseLength + " = " + (nHeight * nBaseLength / 2));
        }
        //#7
        void AreaOfCircle()
        {
            WelcomeApp("Area Of Circle");
            Console.WriteLine("Plesea, enter diameter of circle");
            int nDiameter = ReadNumber();
            Console.WriteLine
                (
                $"Area = (3.14/4) * {nDiameter}^2 = " +
                $"{((3.14 / 4) * nDiameter * nDiameter)}"
                );
        }
        //#8
        void PrintFullName()
        {
            WelcomeApp("PrintFullName");
            Console.WriteLine("Plesea, enter your first name");
            string sFirstName = ReadLines();
            Console.WriteLine("Plesea, enter your last name");
            string sLastName = ReadLines();
            Console.WriteLine($"{sFirstName} {sLastName}");
        }
        //#9
        void HalfNumbers()
        {
            Console.WriteLine("Plesea, enter you number");
            int nNumber = ReadNumber();
            Console.WriteLine(nNumber / 2);
        }
        //#10
        void Swap2Numbers()
        {
            Console.WriteLine("Plesea, enter you first number");
            int nFirstNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you second number");
            int nSecondNumber = ReadNumber();
            int nSwapNumber = nSecondNumber;
            nSecondNumber = nFirstNumber;
            nFirstNumber = nSwapNumber;
            Console.WriteLine(nFirstNumber + " " + nSecondNumber);
        }
        //#11
        void FailOrPass()
        {
            Console.WriteLine("Plesea, enter you grade");
            string sGrade = (ReadNumber() > 50) ? "Pass" : "Fail";
            Console.WriteLine(sGrade);
        }
        //#12
        void CanEnterCollage()
        {
            Console.WriteLine("Plesea, enter you grade");
            int nGrade = ReadNumber();
            Console.WriteLine("Can you pay for private collage? (yes/no)");
            string sCanPay = ReadLines();
            if (nGrade >= 90)
            {
                Console.WriteLine("Accepted");
                return;
            }
            else if (sCanPay == "yes")
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
        //#13
        void OddOfEven()
        {
            Console.WriteLine("Plesea, enter you number");
            string sOddOrEven = (ReadNumber() % 2 == 0) ? "The number is even" : "The Number is odd";
            Console.WriteLine(sOddOrEven);
        }
        //#14
        void CenturyOfTheYear()
        {
            Console.WriteLine("Plesea, enter year");
            int nYear = ReadNumber();
            if (nYear % 100 == 0)
            {
                Console.WriteLine("The Century of the year is " + nYear / 100);
            }
            else
            {
                Console.WriteLine("The Century of the year is " + (nYear / 100) + 1);
            }
        }
        //#15
        void ValidatePercentage()
        {
            WelcomeApp("Validate Presentage");
            Console.WriteLine("Plesea, enter presentage");
            int nPresentage = ReadNumber();
            string isPresentage = (nPresentage > 100 || nPresentage < 0) ? "In-Valid Percentage" : "Valid Percentage";
            Console.WriteLine(isPresentage + "%");
        }
        //#16
        void WhichIsGreater()
        {
            WelcomeApp("Which is Greater");
            Console.WriteLine("Plesea, enter you first number");
            int nFirstNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you second number");
            int nSecondNumber = ReadNumber();
            string IsGreater = (nFirstNumber > nSecondNumber) ? $"{nFirstNumber} is greater" :
                $"{nSecondNumber} is greater";
            Console.WriteLine(IsGreater);
        }
        //#17
        void Compare3Numbers()
        {
            WelcomeApp("Compare 3 Numbers");
            Console.WriteLine("Plesea, enter you first number");
            int nFirstNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you second number");
            int nSecondNumber = ReadNumber();
            Console.WriteLine("Plesea, enter you third number");
            int nThirdNumber = ReadNumber();
            if (nFirstNumber > nSecondNumber && nFirstNumber > nThirdNumber)
            {
                Console.WriteLine($"The number {nFirstNumber} is the Greatest");
            }
            else if (nSecondNumber > nFirstNumber && nSecondNumber > nThirdNumber)
            {
                Console.WriteLine($"The number {nSecondNumber} is the Greatest");
            }
            else if (nThirdNumber > nFirstNumber && nThirdNumber > nSecondNumber)
            {
                Console.WriteLine($"The number {nThirdNumber} is the Greatest");
            }
        }
        //#18
        void SalesSalary()
        {
            WelcomeApp("Sales Salary");
            Console.WriteLine("Plesea, enter you salary number");
            int nSalary = ReadNumber();
            Console.WriteLine("Plesea, enter you total sales number");
            int nTotalSales = ReadNumber();
            if (nTotalSales >= 500000 && nTotalSales <= 1000000)
            {
                Console.WriteLine($"Your Salary = {nSalary} + ({nTotalSales}*0.01) = {nSalary + nTotalSales * 0.01}");
            }
            else if (nTotalSales >= 100000 && nTotalSales < 500000)
            {
                Console.WriteLine($"Your Salary = {nSalary} + ({nTotalSales}*0.2) =  {nSalary + nTotalSales * 0.2}");
            }
            else if (nTotalSales >= 50000 && nTotalSales < 100000)
            {
                Console.WriteLine($"Your Salary = {nSalary} + ({nTotalSales}*0.3) = {nSalary + nTotalSales * 0.3}");
            }
            else if (nTotalSales >= 0 && nTotalSales < 50000)
            {
                Console.WriteLine($"Your Salary = {nSalary}");
            }
        }
        //#19
        //Keep App Working Option (DONE)
        //#20
        void PrintSumFrom1to99()
        {
            WelcomeApp("PrintSumFrom1to99");
            int nSum = 0;
            for (int i = 1; i <= 99; i++)
            {
                nSum += i;
            }
            Console.WriteLine(nSum);
        }
        //#21
        void PrintMultiplyFrom1toN()
        {
            WelcomeApp("PrintMultiplyFrom1toN");
            Console.WriteLine("Plesea, enter a number");
            int nNumber = ReadNumber();
            int nMultibly = 1;
            int nCount = 1;
            while (nCount <= nNumber)
            {
                nMultibly *= nCount;
                nCount++;
            }
            Console.WriteLine($"The Total Multibly = {nMultibly}");
        }
        //#22
        void PrintSumFromNto1()
        {
            WelcomeApp("PrintSumFromNto1");
            Console.WriteLine("Plesea, enter a number");
            int nNumber = ReadNumber();
            int nSum = 0;
            while (nNumber >= 0)
            {
                nSum += nNumber;
                nNumber--;
            }
            Console.WriteLine($"The Total Sum = {nSum}");
        }
        //#23
        void PrintSubtractFromUserInputToN_Numbers()
        {
            WelcomeApp("PrintSubtractFromUserInputToN_Numbers");
            Console.WriteLine("Please, enter number of Iterations");
            int nNumber1 = ReadNumber();
            int nSum = 0;
            for (int i = 1; i <= nNumber1; i++)
            {
                Console.WriteLine($"Please, enter number {i} Value");
                int nNumber2 = ReadNumber();
                nSum -= nNumber2;
            }
            Console.WriteLine($"The Total Value = {nSum}");
        }
        //#24
        void GetMaximumNumberOfUserChoiceNumbers()
        {
            WelcomeApp("GetMaximumNumberOfUserChoiceNumbers");
            Console.WriteLine("Please, enter number of Choices");
            int nNumber1 = ReadNumber();
            int nMax = 0;
            for (int i = 1; i <= nNumber1; i++)
            {
                Console.WriteLine($"Please, enter number {i} Value");
                int nNumber2 = ReadNumber();
                nMax = (nMax > nNumber2) ? nMax : nNumber2;
            }
            Console.WriteLine($"The Maximum Value = {nMax}");
        }
        //#25
        //#26
        //#27
        //#28
        //#29
        //#30
        //#31
        //#32 
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.MainProgram();

        }
        
    }
}
