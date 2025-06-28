using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace _1_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Last Entry 2025-2-17");
            Console.WriteLine("-----------------------------");
            DeclareDatetime();
            Console.WriteLine("-----------------------------");
            DealingWithStrings();
            Console.WriteLine("-----------------------------");
            FormatingString();
            Console.WriteLine("-----------------------------");
            CultureAndCalendar();
            Console.WriteLine("-----------------------------");
            StoreDateAsTicks();
            Console.WriteLine("-----------------------------");
            Operations();
            Console.WriteLine("-----------------------------");
            Project();
            Console.WriteLine("-----------------------------");

            //---------------------------------------Code of Program-----------------------------------

            // Date and Time are Strct (Value type not refrance type)
            //1-Declare Datetime
            void DeclareDatetime()
            {
                DateTime dt1 = new DateTime(2023, 07, 25);
                DateTime dt2 = DateTime.Now;
                DateTime dt3 = new DateTime(2023, 07, 25, 10, 20, 5);
                Console.WriteLine(dt1);
                Console.WriteLine(dt2);
                Console.WriteLine(dt3);
                Console.WriteLine(DateTime.MinValue);
                Console.WriteLine(DateTime.MaxValue);
                Console.WriteLine(dt1.Day);
                Console.WriteLine(dt1.Month);
                Console.WriteLine(dt1.Year);
                Console.WriteLine(DateTime.Now.Day);
                Console.WriteLine(DateTime.Now.Ticks);

            }
            //2-Dealing With Strings
            void DealingWithStrings()
            {
                DateTime dtMyDate1, dtMyDate2, dtMyDate3;
                bool isConverted1 = DateTime.TryParse("20/01/2023", out dtMyDate1);
                Console.WriteLine(isConverted1);
                bool isConverted2 = DateTime.TryParseExact("20/10/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtMyDate2);
                Console.WriteLine(isConverted2);
                Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
                Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
                dtMyDate3 = new DateTime(2023, 10, 20);
                Console.WriteLine(dtMyDate3);
                Console.WriteLine(dtMyDate3.ToString("dd/MM/yyyy HH mm"));
            }
            //3-Datetime Format
            void FormatingString()
            {
                /* 
                Understanding formats:
                    d means day: 
                        d number of day 1, 2
                        dd Zero Number of day 01, 02
                    M capita means month:
                        M month number from 0 to 12
                        MM Zero month number 01, 02
                        MMM the abbrevated name of month
                        MMMM the full name of month
                    y means year:
                        y years from 0 to 99 => [2009 = 9],[1900 = 0],[1920 = 20]
                        yy years from 00 to 99
                        yyy years with minimum 3 numbers
                        yyyy years with minimum 4 numbers
                    h means hours:
                        h hours from 0 to 12 in 12 hour system
                        hh hours from 01 to 12 in 12 hour system
                        H hours from 0 to 12 in 24 hour system
                        HH hours from 01 to 12 in 24 hour system
                    m means minutes:
                        m mintes form 0 to 59
                        mm mintes form 00 to 59
                    s means second:
                        s second form 0 to 59
                        ss second form 00 to 59
                    t means am or pm:
                    T the first char of AM and PM
                    Tt the full word of AM and PM
                */
                DateTime dtMyDate = DateTime.Now;
                Console.WriteLine(dtMyDate.ToString("d"));
                Console.WriteLine(dtMyDate.ToString("dd"));
            }
            //4-Culture And Calender
            void CultureAndCalendar()
            {
                //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("");
                //Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
                Calendar MyCalendar = new HijriCalendar();

                DateTime dtMyDate = new DateTime(1445, 2, 10, MyCalendar);
                Console.WriteLine(dtMyDate);
                Console.WriteLine(dtMyDate.Month);
                Console.WriteLine(dtMyDate.Year);
                Console.WriteLine(MyCalendar.GetDayOfMonth(dtMyDate));
                Console.WriteLine(MyCalendar.GetMonth(dtMyDate));
                Console.WriteLine(MyCalendar.GetYear(dtMyDate));

            }
            //5-Store Datetime In Systems
            void StoreDateAsTicks()
            {
                DateTime dtMyDate = DateTime.Now;
                long date = dtMyDate.ToUniversalTime().Ticks;
                Console.WriteLine(date.ToString());
                DateTime dtMyDate2 = new DateTime(date).ToLocalTime();
                dtMyDate2.AddMonths(1);
                Console.WriteLine(dtMyDate2);
            }
            //6-Datetime Operations
            void Operations()
            {
                DateTime dtMyDate = DateTime.Now;
                Console.WriteLine(dtMyDate.ToString());
                DateTime dtMyDate2 = dtMyDate.AddMonths(1);
                Console.WriteLine(dtMyDate2.ToString());
                DateTime dtMyDate3 = dtMyDate.AddYears(3);
                Console.WriteLine(dtMyDate3.ToString());

                TimeSpan dtMyDate4 = dtMyDate3 - dtMyDate2;
                Console.WriteLine(dtMyDate4.ToString());
                TimeSpan dtMyDate5 = dtMyDate3.Subtract(dtMyDate2);
                Console.WriteLine(dtMyDate5.ToString());
                DateTime dtMyDate6 = dtMyDate2.Add(dtMyDate4);
                Console.WriteLine(dtMyDate6.ToString());

                bool isCheck = dtMyDate3 >= dtMyDate2;
                Console.WriteLine(isCheck);

                if (dtMyDate3.Month == dtMyDate2.Month)
                {
                    Console.WriteLine("Same Month");
                }
                else
                {
                    Console.WriteLine("Different Month");
                }


                int x = dtMyDate3.CompareTo(dtMyDate2);
                if (x == 0)
                {
                    Console.WriteLine("Same Month");
                }
                else
                {
                    Console.WriteLine("Different Month");
                }
            }
            //7-Project
            void Project()
            {
                Console.WriteLine("please enter date 1 dd/MM/yyyy");
                DateTime dtDate1;
                string sDate1 = ReadLines();
                bool isConverted1 = DateTime.TryParseExact(sDate1, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtDate1);
                if (!isConverted1)
                {
                    Console.WriteLine("Enter a valid date");
                    return;
                }

                Console.WriteLine("please enter date 2 dd/MM/yyyy");
                DateTime dtDate2;
                string sDate2 = ReadLines();
                bool isConverted2 = DateTime.TryParseExact(sDate2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtDate2);
                if (!isConverted2)
                {
                    Console.WriteLine("Enter a valid date");
                    return;
                }

                DateTime dtResult;
                if (dtDate1 > dtDate2)
                {
                    TimeSpan time = new TimeSpan(dtDate1.Hour, dtDate1.Minute, dtDate1.Second);
                    dtResult = dtDate1.Add(time);
                    dtResult = dtDate1.AddMonths(dtDate2.Month);
                    Console.WriteLine(dtResult.ToString("MMMM-dd-yyyy"));
                }
                else
                {
                    TimeSpan time = dtDate2.Subtract(dtDate1);
                    Console.WriteLine($"The time interval is {time.years} years, {time.months} months," +
                    $"{time.days} days");
                }
            }
            //-------------------------------------Helping Functions-----------------------------------

            //Helping Functions
            // Read Line from user
            string ReadLines()
            {
                string? RL = Console.ReadLine();
                if (string.IsNullOrEmpty(RL))
                {
                    Console.WriteLine("Enter a valid string");
                    return " ";
                }
                else
                {
                    return RL;
                }
            }
            //-------------------------------------------------------------------------------------------
        }
    }
}
