using System.Text;

namespace ProblemSolving_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.MainProgram();
        }
        void MainProgram()
        {
            bool bIsWorking = true;
            while (bIsWorking)
            {
                WelcomeApp("Problem Solving Level 2");
                Console.WriteLine(
                    $"Avilable applications:\n" +
                    $"1-Work with Array\n" +
                    $"2-Work with 2D Araay\n" +
                    $"3-Work with Strings\n");
                Console.WriteLine("Please enter application Number");
                int nApplication = ReadNumber();
                SelectProgram(nApplication);

                Console.WriteLine("Do You Want to continue? Yes=y ,No=n");
                string sContinue = ReadLines();
                bIsWorking = (sContinue == "y");
            }
        }
        //...............................................helping functions.............................................
        #region helping functions
        //Select a Program
        void SelectProgram(int nApplication)
        {
            int nProgram;
            switch (nApplication)
            {
                case 1:
                    Console.WriteLine(
                    $"Avilable applications:\n" +
                    $"1-Store Sell Product\n" +
                    $"2-Weekend Customers\n" +
                    $"3-Buy One Get Half\n" +
                    $"4-Prime Number\n" +
                    $"5-Convert Binnary To Decimal\n" +
                    $"6-Fibonacci Series\n" +
                    $"7-(7,8,9,10,11,12)Operation Array\n" +
                    $"8-(11)Optimize Merge Code\n" +
                    $"9-(12)Copy From End\n" +
                    $"10-(13)Deference Between Two Arrays\n" +
                    $"11-(14)Union Of Two Arrays\n" +
                    $"12-(15)Intersection Between Two Arrays\n" +
                    $"13-(16)Check Array In Asending Order\n" +
                    $"14-(17)Remove Element From Array\n" +
                    $"15-(18)Insert Element To Array\n" +
                    $"16-(19)Rotate Array\n");
                    Console.WriteLine("Please enter application Number");
                    nProgram = ReadNumber();
                    switch (nProgram)
                    {
                        case 1:
                            StoreSellProduct();
                            break;
                        case 2:
                            WeekendCustomers();
                            break;
                        case 3:
                            BuyOneGetHalf();
                            break;
                        case 4:
                            PrimeNumber();
                            break;
                        case 5:
                            BinnaryToDecimal();
                            break;
                        case 6:
                            FibonacciSeries();
                            break;
                        case 7:
                            ArrayOperations();
                            break;
                        case 8:
                            MergeArrayStart2Start();
                            break;
                        case 9:
                            MergeArrayStart2End();
                            break;
                        case 10:
                            DeferenceBetweenTwoArrays();
                            break;
                        case 11:
                            UnionOfTwoArrays();
                            break;
                        case 12:
                            IntersectionBetweenTwoArrays();
                            break;
                        case 13:
                            CheckArrayInAscendingOrder();
                            break;
                        case 14:
                            RemoveElementFromArray();
                            break;
                        case 15:
                            InsertElementToArray();
                            break;
                        case 16:
                            RotateArrayApp();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine(
                    $"Avilable applications:\n" +
                    $"17-(20)Print 2D Array\n" +
                    $"18-(21)Search In 2D Array\n" +
                    $"19-(22)Convert 2D Array To 1D Array\n");
                    Console.WriteLine("Please enter application Number");
                    nProgram = ReadNumber();
                    switch (nProgram)
                    {
                        case 17:
                            Print2DArray();
                            break;
                        case 18:
                            SearchIn2DArray();
                            break;
                        case 19:
                            Convert2DArrayTo1DArray();
                            break;
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine(
                        $"Avilable applications:\n" +
                        $"20-(23)Reverse String\n" +
                        $"21-(24)Number Of Vowels In A String\n" +
                        $"22-(25)Replaces Character In A String\n" +
                        $"23-(26)Concatenates Two Strings\n" +
                        $"24-(27)Remove All Spaces\n" +
                        $"25-(28)Trim String\n" +
                        $"26-(29)Convert String To Words\n" +
                        $"27-(30)Get Longest Word From String\n" +
                        $"28-(31)Encrypts and Decrypts A String Using Caesar Cipher\n");
                        Console.WriteLine("Please enter application Number");
                        nProgram = ReadNumber();
                        switch (nProgram)
                        {
                            case 20:
                                ReverseText();
                                break;
                            case 21:
                                NumberOfVowelsInAString();
                                break;
                            case 22:
                                ReplacesCharacterInAString();
                                break;
                            case 23:
                                ConcatenatesTwoStrings();
                                break;
                            case 24:
                                RemoveAllSpaces();
                                break;
                            case 25:
                                TrimString();
                                break;
                            case 26:
                                ConvertStringToWords();
                                break;
                            case 27:
                                GetLongestWordFromString();
                                break;
                            case 28:
                                EncryptsAndDecryptsAStringUsingCaesarCipher();
                                break;
                        }
                    }
                    break;
            }
        }
        // Read Line from user
        string ReadLines()
        {
            string? RL = Console.ReadLine();
            if (RL == null)
            {
                Console.WriteLine("Enter a valid string");
                return " ";
            }
            return RL;
        }
        // Read char from user
        char ReadChar()
        {
            char cText;
            bool isConverted = char.TryParse(Console.ReadLine(), out cText);
            if (!isConverted)
            {
                Console.WriteLine("Enter a valid letter");
                return ' ';
            }
            return cText;
        }
        // Welcome to application name
        // Read Double from user
        double ReadDoubleNumber()
        {
            double dNumber = 0;
            bool isConverted = double.TryParse(Console.ReadLine(), out dNumber);
            if (!isConverted)
            {
                Console.WriteLine("Enter a valid number");
            }
            return dNumber;
        }
        // Read integer from user
        int ReadNumber()
        {
            int Number = 0;
            bool isConverted = int.TryParse(Console.ReadLine(), out Number);
            if (!isConverted)
            {
                Console.WriteLine("Enter a valid number");
                return 0;
            }
            return Number;
        }
        // Welcome to application name
        void WelcomeApp(string Massage)
        {
            Console.Clear();
            Console.WriteLine($"-------------------------------------------------\n" +
                              $"Welcome to {Massage}\n" +
                              $"-------------------------------------------------\n");
        }
        #endregion
        //.............................................................................................................
        #region Methods 1
        //1-Store Sell Product
        void StoreSellProduct()
        {
            WelcomeApp("store price calculation system");

            Console.WriteLine("Please enter Book Price");
            double dBookPrice = ReadDoubleNumber();
            Console.WriteLine("Please enter number of Books");
            int BookNumber = ReadNumber();

            Console.WriteLine("Please enter Electornics Price");
            double dElectornicPrice = ReadDoubleNumber();
            Console.WriteLine("Please enter number of Electornics");
            int ElectornicsNumber = ReadNumber();

            Console.WriteLine("Please enter Clothing Price");
            double dClothingPrice = ReadDoubleNumber();
            Console.WriteLine("Please enter number of Clothes");
            int ClothesNumber = ReadNumber();

            double dTotalPrice = (dBookPrice * BookNumber) + (dElectornicPrice * ElectornicsNumber) + (dClothingPrice * ClothesNumber);
            Console.WriteLine($"The Total Price is {dTotalPrice.ToString("0.00")}");
        }
        //.............................................................................................................
        //2-Weekend Customers
        void WeekendCustomers()
        {
            WelcomeApp("Weekend Customers calculator");

            Console.WriteLine("Please enter number of customers on weekday");
            int NumberOfCustomers = ReadNumber();
            Console.WriteLine("Please enter presentage of weekday increase");
            double dPresentageOfCustomers = ReadDoubleNumber();

            double dTotalnumber = NumberOfCustomers * (1 + (dPresentageOfCustomers / 100));
            Console.WriteLine($"The Total Number of Customers is {dTotalnumber.ToString("0.00")}");
        }
        //.............................................................................................................
        //3-Buy One Get Half
        void BuyOneGetHalf()
        {
            WelcomeApp("Buy One Get Half");

            Console.WriteLine("Please enter price of shirt");
            double dShirtPrice = ReadDoubleNumber();

            Console.WriteLine("Please enter number of shirt");
            int nNumberOfshirts = ReadNumber();

            Console.WriteLine("Please enter number of items in single bundle");
            int nItemsInBundle = ReadNumber();

            double dPriceOfBundle = dShirtPrice + (dShirtPrice * 0.5);
            int nBundleCount = nNumberOfshirts / nItemsInBundle;

            double dTotalPrice = (nNumberOfshirts % 2 == 0) ? dPriceOfBundle * nBundleCount : (dPriceOfBundle * nBundleCount) + dShirtPrice;
            Console.WriteLine($"The Total price is {dTotalPrice.ToString("0.00")}");
        }
        //.............................................................................................................
        //4-Prime Number
        void PrimeNumber()
        {
            WelcomeApp("Buy One Get Half");

            Console.WriteLine("Please enter a number");
            int nNumber = ReadNumber();
            int nCount = 0;
            if (nNumber > 1)
            {
                for (int i = 2; i * i <= nNumber; i++)
                {
                    if (nNumber % i == 0)
                    {
                        nCount++;
                    }
                }
                string IsPrime = (nCount > 0) ? "The Number is Not Prime" : "The Number is Prime";
                Console.WriteLine(IsPrime);
            }
            else
            {
                Console.WriteLine("The Number is Not Prime");
            }
        }
        //.............................................................................................................
        //5-Convert Binnary To Decimal
        void BinnaryToDecimal()
        {
            WelcomeApp("Convert Binnary To Decimal");
            Console.WriteLine("Please enter Binnary number");
            ToDecimal(ReadLines());
        }
        //helping functions
        double ToDecimal(string binnary)
        {
            double dDecimalValue = 0;
            int nBaseValue = 0;
            for (int i = binnary.Length - 1; i >= 0; i--)
            {
                if (binnary[i] == '0')
                {
                    nBaseValue++;
                    continue;
                }
                dDecimalValue += Power(2, nBaseValue);
                nBaseValue++;
            }
            return dDecimalValue;
        }
        double Power(double BaseValue, double PowerValue)
        {
            if (PowerValue == 0)
            {
                return 1;
            }
            else if (BaseValue == 0)
            {
                return 0;
            }
            double dResult = 1;
            for (int i = 1; i <= PowerValue; i++)
            {
                dResult *= BaseValue;
            }
            return dResult;
        }
        //.............................................................................................................
        //6-Fibonacci Series
        void FibonacciSeries()
        {
            WelcomeApp("Fibonacci Series");
            Console.WriteLine("Please enter number of terms");
            int nTerm = ReadNumber();
            int nFirstValue = 0;
            int nSecondValue = 1;

            Console.Write(nFirstValue + " " + nSecondValue + " ");

            for (int i = 2; i < nTerm; i++)
            {
                int nThirdValue = nFirstValue + nSecondValue;
                Console.Write(nThirdValue + " ");
                nFirstValue = nSecondValue;
                nSecondValue = nThirdValue;
            }
            Console.WriteLine("\n");
        }
        #endregion
        //.............................................................................................................
        //...............................................Array Operations..............................................
        #region Array Operations Methods
        void ArrayOperations()
        {
            WelcomeApp("Array Operations");
            Console.WriteLine($"Avilable Operations\n" +
                              $"1- Copy Array\n" +
                              $"2- Merge Array\n");
            Console.WriteLine("Please enter operation Number");
            int nOperation1 = ReadNumber();
            switch (nOperation1)
            {
                case 1:
                    CopyArray();
                    break;
                case 2:
                    MergeArray();
                    break;
            }
        }
        //7-Copy Array.......................................
        void CopyArray()
        {
            WelcomeApp("Copy Array");
            int[] nNewArray = ReadArray();
            Console.Clear();
            Console.WriteLine($"The array is {nNewArray}\n");
            int[] nResult = ProssesArrayOperations(nNewArray);
            PrintArray(nResult);
        }
        //10-Merge Two Arrays................................
        void MergeArray()
        {
            WelcomeApp("Merge 2 Array");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.WriteLine("Please enter 2nd array");
            int[] nArray2 = ReadArray();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("The Second array is");
            PrintArray(nArray2);
            int[] nResult1 = ProssesArrayOperations(nArray1);
            Console.WriteLine("The result of first array is");
            PrintArray(nResult1);
            int[] nResult2 = ProssesArrayOperations(nArray2);
            Console.WriteLine("The result of second array is");
            PrintArray(nResult2);
            int[] nResult3 = Merge2Array(nResult1, nResult2);
            Console.WriteLine("The final answer is");
            PrintArray(nResult3);
        }
        //.............................................................................................................
        //...............................................helping functions.............................................
        //To Print an Array int
        void PrintArray(int[] nArray)
        {
            foreach (int i in nArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        //To Print an Array String
        void PrintArrayString(string[] nArray)
        {
            foreach (string i in nArray)
            {
                Console.Write(i + "/");
            }
            Console.WriteLine("\n");
        }
        //To resize an Array String
        string[] ResizeArrayString(string[] nArray, int nSize)
        {
            string[] nResult = new string[nSize];
            for (int i = 0; i < nSize; i++)
            {
                nResult[i] = nArray[i];
            }
            return nResult;
        }
        //To Read an Array
        int[] ReadArray()
        {
            Console.WriteLine("Please enter size of array");
            int nSize = ReadNumber();
            int[] nNewArray = new int[nSize];
            for (int i = 0; i < nSize; i++)
            {
                Console.WriteLine($"Please enter item {i} of array");
                nNewArray[i] = ReadNumber();
            }
            return nNewArray;
        }
        //7-Copy Full Array
        int[] CopyFull(int[] nArray)
        {
            int[] nResult = new int[nArray.Length];
            for (int i = 0; i < nArray.Length; i++)
            {
                nResult[i] = nArray[i];
            }
            return nResult;
        }
        //8-Copy Half Of Array
        int[] Copy1stHalf(int[] nArray)
        {
            int[] nResult = new int[(nArray.Length) / 2];
            for (int i = 0; i < nArray.Length / 2; i++)
            {
                nResult[i] = nArray[i];
            }
            return nResult;
        }
        //9-Copy From Start And End
        int[] CopyStartEnd(int[] nArray, int Start, int End)
        {
            int[] nResult = new int[Start + End];
            for (int i = 0; i < Start; i++)
            {
                nResult[i] = nArray[i];
            }
            for (int i = (Start + End) - 1; i > Start - 1; i--)
            {
                nResult[i] = nArray[i + (nArray.Length - nResult.Length)];
            }
            return nResult;
        }
        //10-Merge 2 Array
        int[] Merge2Array(int[] nArray1, int[] nArray2)
        {
            int[] nResult = new int[nArray1.Length + nArray2.Length];
            for (int i = 0; i < nArray1.Length; i++)
            {
                nResult[i] = nArray1[i];
            }
            for (int i = 0; i < nArray2.Length; i++)
            {
                nResult[i + nArray1.Length] = nArray2[i];
            }
            return nResult;
        }
        //11-Copy From Start and n postion
        void CopyFromStart(int[] nArrayFrom, int[] nArrayTo, int lenght, int Start = 0)
        {
            for (int i = 0; i < lenght; i++)
            {
                nArrayTo[Start] = nArrayFrom[i];
                Start++;
            }
            Array.Resize(ref nArrayTo, lenght);
        }
        //12-Copy From End and n postion
        void CopyFromEnd(int[] nArrayFrom, int[] nArrayTo, int lenght, int Start = 0)
        {
            for (int i = nArrayFrom.Length - 1; i > nArrayFrom.Length - 1 - lenght; i--)
            {
                nArrayTo[Start] = nArrayFrom[i];
                Start++;
            }
            Array.Resize(ref nArrayTo, lenght);
        }
        //Prosses Array Operations
        int[] ProssesArrayOperations(int[] nArray)
        {
            Console.WriteLine($"Avilable Operations on first array\n" +
                              $"1- Copy full\n" +
                              $"2- Copy 1st Half\n" +
                              $"3- Copy Start End\n" +
                              $"4- Copy From Start\n" +
                              $"5- Copy From End\n");
            Console.WriteLine("Please enter operation Number");
            int nOperation = ReadNumber();
            int[] nResult = new int[nArray.Length];
            switch (nOperation)
            {
                case 1:
                    nResult = CopyFull(nArray);
                    break;
                case 2:
                    nResult = Copy1stHalf(nArray);
                    break;
                case 3:
                    Console.WriteLine("Enter Start number");
                    int nStart = ReadNumber();
                    Console.WriteLine("Enter End number");
                    int nEnd = ReadNumber();
                    nResult = CopyStartEnd(nArray, nStart, nEnd);
                    break;
                case 4:
                    Console.WriteLine("Enter lenght number");
                    int lenght = ReadNumber();
                    Console.WriteLine("Enter Start number");
                    int Start = ReadNumber();
                    CopyFromStart(nArray, nResult, lenght, Start);
                    break;
                case 5:
                    Console.WriteLine("Enter lenght number");
                    lenght = ReadNumber();
                    Console.WriteLine("Enter Start number");
                    Start = ReadNumber();
                    CopyFromEnd(nArray, nResult, lenght, Start);
                    break;
            }
            return nResult;
        }
        //.............................................................................................................
        //11-Optimize Merge Code
        void MergeArrayStart2Start()
        {
            WelcomeApp("Merge 2 Array");
            int[] nArray1 = new int[4] { 1, 2, 3, 4 };
            int[] nArray2 = new int[5] { 6, 7, 8, 20, 30 };
            int[] nResult = Merge2Array2(nArray1, 2, nArray2, 4);
            PrintArray(nArray1);
            PrintArray(nArray2);
            PrintArray(nResult);
        }
        int[] Merge2Array2(int[] nArray1, int FirstLenght, int[] nArray2, int SecandLenght)
        {
            int[] nResult = new int[FirstLenght + SecandLenght];
            CopyFromStart(nArray1, nResult, FirstLenght);
            CopyFromStart(nArray2, nResult, SecandLenght, FirstLenght);
            return nResult;
        }
        //.............................................................................................................
        //12-Copy From End
        void MergeArrayStart2End()
        {
            WelcomeApp("Merge 2 Array");
            int[] nArray1 = new int[4] { 1, 2, 3, 4 };
            int[] nArray2 = new int[5] { 6, 7, 8, 20, 30 };
            int[] nResult = Merge2Array3(nArray1, 2, nArray2, 4);
            PrintArray(nArray1);
            PrintArray(nArray2);
            PrintArray(nResult);
        }
        int[] Merge2Array3(int[] nArray1, int FirstLenght, int[] nArray2, int SecandLenght)
        {
            int[] nResult = new int[FirstLenght + SecandLenght];
            CopyFromStart(nArray1, nResult, FirstLenght);
            CopyFromEnd(nArray2, nResult, SecandLenght, FirstLenght);
            return nResult;
        }
        //.............................................................................................................
        //13-Deference Between Two Arrays
        void DeferenceBetweenTwoArrays()
        {
            WelcomeApp("Deference Between Two Arrays");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.WriteLine("Please enter 2nd array");
            int[] nArray2 = ReadArray();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("The Second array is");
            PrintArray(nArray2);
            int[] nArray3 = FindDifference(nArray1, nArray2);
            Console.WriteLine("The result is");
            PrintArray(nArray3);
        }
        int[] FindDifference(int[] nArray1, int[] nArray2)
        {
            int[] nResult = new int[nArray1.Length];
            int nCount = 0;
            foreach (int i in nArray1)
            {
                if (!IsItemFound(i, nArray2))
                {
                    nResult[nCount] = i;
                    nCount++;
                }
            }
            Array.Resize(ref nResult, nCount);
            return nResult;
        }
        bool IsItemFound(int nItem, int[] nArray)
        {
            foreach (int i in nArray)
            {
                if (nItem == i) return true;
            }
            return false;
        }
        //.............................................................................................................
        //14-Union Of Two Arrays
        void UnionOfTwoArrays()
        {
            WelcomeApp("Union Of Two Arrays");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.WriteLine("Please enter 2nd array");
            int[] nArray2 = ReadArray();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("The Second array is");
            PrintArray(nArray2);
            int[] nArray3 = Union(nArray1, nArray2);
            Console.WriteLine("The result is");
            PrintArray(nArray3);
        }
        int[] Union(int[] nArray1, int[] nArray2)
        {
            int[] nResult = new int[nArray1.Length + nArray2.Length];
            int nCount = 0;
            foreach (int i in nArray1)
            {
                nResult[nCount] = i;
                nCount++;
            }
            foreach (int i in nArray2)
            {
                if (IsItemFound(i, nResult))
                {
                    continue;
                }
                nResult[nCount] = i;
                nCount++;

            }
            return nResult;
        }
        //.............................................................................................................
        //15-Intersection Between Two Arrays
        void IntersectionBetweenTwoArrays()
        {
            WelcomeApp("Intersection Between Two Arrays");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.WriteLine("Please enter 2nd array");
            int[] nArray2 = ReadArray();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("The Second array is");
            PrintArray(nArray2);
            int[] nArray3 = Intersection(nArray1, nArray2);
            Console.WriteLine("The result is");
            PrintArray(nArray3);
        }
        int[] Intersection(int[] nArray1, int[] nArray2)
        {
            int[] nResult = new int[nArray1.Length + nArray2.Length];
            int nCount = 0;
            foreach (int i in nArray1)
            {
                if (IsItemFound(i, nArray2))
                {
                    nResult[nCount] = i;
                    nCount++;
                }
            }
            Array.Resize(ref nResult, nCount);
            return nResult;
        }
        //.............................................................................................................
        //16-Check Array In Asending Order
        void CheckArrayInAscendingOrder()
        {
            WelcomeApp("Check Array In Assending Order");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            bool IsAscending = IsInAscending(nArray1);
            Console.WriteLine($"The result is {IsAscending}");
        }
        bool IsInAscending(int[] nArray1)
        {
            for (int i = 1; i < nArray1.Length; i++)
            {
                if (nArray1[i] < nArray1[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        //.............................................................................................................
        //17-Remove Element From Array
        void RemoveElementFromArray()
        {
            WelcomeApp("Remove Element From Array");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("Please enter element postion to remove");
            int nPosition = ReadNumber();
            int[] nResult = RemoveElement(nPosition, nArray1);
            Console.WriteLine($"The result is");
            PrintArray(nResult);
        }
        int[] RemoveElement(int nPostion, int[] nArray1)
        {
            for (int i = nPostion; i < nArray1.Length - 1; i++)
            {
                nArray1[i] = nArray1[i + 1];
            }
            nArray1[nArray1.Length - 1] = 0;
            return nArray1;
        }
        //.............................................................................................................
        //18 - Insert Element To Array
        void InsertElementToArray()
        {
            WelcomeApp("Insert Element To Array");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("Please enter element postion to remove");
            int nElement = ReadNumber();
            Console.WriteLine("Please enter element postion to remove");
            int nPosition = ReadNumber();
            int[] nResult = InsertElement(nElement, nPosition, nArray1);
            Console.WriteLine($"The result is");
            PrintArray(nResult);
        }
        int[] InsertElement(int nElement, int nPostion, int[] nArray1)
        {
            int[] nArray2 = new int[nArray1.Length + 1];
            int nCount = 0;
            for (int i = 0; i < nArray2.Length; i++)
            {
                if (i == nPostion)
                {
                    nArray2[i] = nElement;
                }
                else
                {
                    nArray2[i] = nArray1[nCount];
                    nCount++;
                }
            }
            return nArray2;
        }
        //.............................................................................................................
        //19-Rotate Array
        void RotateArrayApp()
        {
            WelcomeApp("Rotate Array");
            Console.WriteLine("Please enter 1st array");
            int[] nArray1 = ReadArray();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray(nArray1);
            Console.WriteLine("Please enter element postion to rotate");
            int nPosition = ReadNumber();
            int[] nResult = RotateArray(nArray1, nPosition);
            Console.WriteLine($"The result is");
            PrintArray(nResult);
        }
        int[] RotateArray(int[] nArray, int nPostion)
        {
            int[] nResult = new int[nArray.Length];
            for (int i = 0; i < nArray.Length; i++)
            {
                if (i <= nPostion)
                {
                    nResult[i] = nArray[i + nPostion];
                }
                else
                {
                    nResult[i] = nArray[i - nPostion - 1];
                }
            }
            return nResult;
        }
        //.............................................................................................................
        //20-Print 2D Array
        void Print2DArray()
        {
            WelcomeApp("Print 2D Array");
            Console.WriteLine("Please enter 2D array");
            int[,] nArray = ReadArray2D();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The first array is");
            PrintArray2D(nArray);
        }
        int[,] ReadArray2D()
        {
            Console.WriteLine("Please enter number of rows");
            int nRow = ReadNumber();
            Console.WriteLine("Please enter number of columns");
            int nColumn = ReadNumber();
            int[,] nNewArray = new int[nRow, nColumn];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nColumn; j++)
                {
                    Console.WriteLine($"Please enter item {i},{j} of array");
                    nNewArray[i, j] = ReadNumber();
                }
            }
            return nNewArray;
        }
        void PrintArray2D(int[,] nArray)
        {
            for (int i = 0; i < nArray.GetLength(0); i++)
            {
                for (int j = 0; j < nArray.GetLength(1); j++)
                {
                    Console.Write(nArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //.............................................................................................................
        //21-Search In 2D Array
        void SearchIn2DArray()
        {
            WelcomeApp("Search In 2D Array");
            Console.WriteLine("Please enter 2D array");
            int[,] nArray = ReadArray2D();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The array is");
            PrintArray2D(nArray);
            Console.WriteLine("Please enter element to search");
            int nElement = ReadNumber();
            bool nResult = IsFound2D(nElement, nArray);
            Console.WriteLine($"The result is");
            Console.WriteLine(nResult);
        }
        bool IsFound2D(int nElement, int[,] nArray)
        {
            for (int i = 0; i < nArray.GetLength(0); i++)
            {
                for (int j = 0; j < nArray.GetLength(1); j++)
                {
                    if (nArray[i, j] == nElement)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //.............................................................................................................
        //22-Convert 2D Array To 1D Array
        void Convert2DArrayTo1DArray()
        {
            WelcomeApp("Search In 2D Array");
            Console.WriteLine("Please enter 2D array");
            int[,] nArray = ReadArray2D();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("The array is");
            PrintArray2D(nArray);
            int[] nResult = Convert2DTo1D(nArray);
            PrintArray(nResult);

        }
        int[] Convert2DTo1D(int[,] nArray)
        {
            int[] nResult = new int[nArray.GetLength(0) * nArray.GetLength(1)];
            int nCount = 0;
            for (int i = 0; i < nArray.GetLength(0); i++)
            {
                for (int j = 0; j < nArray.GetLength(1); j++)
                {
                    nResult[nCount] = nArray[i, j];
                    nCount++;
                }
            }
            return nResult;
        }
        //.............................................................................................................
        //23-Reverse String
        void ReverseText()
        {
            WelcomeApp("Reverse String");
            Console.WriteLine("Please enter text");
            string sText = ReverseString(ReadLines());
            Console.WriteLine(sText);
        }
        string ReverseString(string Text)
        {
            StringBuilder ReverseText = new StringBuilder();
            for (int i = Text.Length - 1; i >= 0; i--)
            {
                ReverseText.Append(Text[i]);
            }
            return ReverseText.ToString();
        }
        //.............................................................................................................
        //24-Number Of Vowels In A String
        void NumberOfVowelsInAString()
        {
            WelcomeApp("Number Of Vowels In A String");
            Console.WriteLine("Please enter text");
            string text = ReadLines();
            int nVowels = VowelsInString(text);
            Console.WriteLine($"the number of Vowels are {nVowels}");
        }
        int VowelsInString(string Text)
        {
            string sVowels = "aeiouAEIOU";
            int nCount = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                for (int j = 0; j < sVowels.Length; j++)
                {
                    if (Text[i] == sVowels[j])
                    {
                        nCount++;
                    }
                }
            }
            return nCount;
        }
        //.............................................................................................................
        //25-Replaces Character In A String
        void ReplacesCharacterInAString()
        {
            WelcomeApp("Replaces Character In A String");
            Console.WriteLine("Please enter text");
            string text = ReadLines();
            Console.WriteLine("Please enter letter to remove");
            char sText1 = ReadChar();
            Console.WriteLine("Please enter new letter");
            char sText2 = ReadChar();
            string NewText = RepalceChar(text, sText1, sText2);
            Console.WriteLine($"the text is {NewText}");
        }
        string RepalceChar(string Text, char toBeReplaced, char replace)
        {
            StringBuilder NewText = new StringBuilder();
            foreach (char c in Text)
            {
                if (c == toBeReplaced)
                {
                    NewText.Append(replace);
                }
                else
                {
                    NewText.Append(c);
                }
            }
            return NewText.ToString();
        }
        //.............................................................................................................
        //26-Concatenates Two Strings
        void ConcatenatesTwoStrings()
        {
            WelcomeApp("Concatenates Two Strings");
            Console.WriteLine("Please enter text 1");
            string text1 = ReadLines();
            Console.WriteLine("Please enter text 2");
            string text2 = ReadLines();
            Console.WriteLine("inclode Space?(y/n)");
            char YesNo = ReadChar();
            bool IsYes = (YesNo == 'y') ? true : false;
            string NewText = Concatenat(text1, text2, IsYes);
            Console.WriteLine($"the text is {NewText}");
        }
        string Concatenat(string Text1, string Text2, bool AddSpace)
        {
            StringBuilder NewText = new StringBuilder();
            foreach (char c in Text1)
            {
                NewText.Append(c);
            }
            if (AddSpace)
            {
                NewText.Append(' ');
            }
            foreach (char c in Text2)
            {
                NewText.Append(c);
            }
            return NewText.ToString();
        }
        //.............................................................................................................
        //27-Remove All Spaces
        void RemoveAllSpaces()
        {
            WelcomeApp("Remove All Spaces");
            Console.WriteLine("Please enter text");
            string text1 = ReadLines();
            string NewText = RemoveSpace(text1);
            Console.WriteLine($"the new text is {NewText}");
        }
        string RemoveSpace(string Text1)
        {
            StringBuilder NewText = new StringBuilder();
            foreach (char c in Text1)
            {
                if (c == ' ')
                {
                    continue;
                }
                NewText.Append(c);
            }
            return NewText.ToString();
        }
        //.............................................................................................................
        //28-Trim String
        void TrimString()
        {
            WelcomeApp("Trim String");
            Console.WriteLine("Please enter text");
            string text1 = ReadLines();
            string NewText = Trim(text1);
            Console.WriteLine($"the new text is {NewText}");
        }
        string Trim(string Text1)
        {
            StringBuilder NewText = new StringBuilder();
            int Start = 0;
            int End = 0;
            for (int i = 0; i < Text1.Length; i++)
            {
                if (Text1[i] != ' ')
                {
                    Start = i;
                    break;
                }
            }
            for (int i = Text1.Length - 1; i >= 0; i--)
            {
                if (Text1[i] != ' ')
                {
                    End = i;
                    break;
                }
            }
            for (int i = Start; i <= End; i++)
            {
                NewText.Append(Text1[i]);
            }
            return NewText.ToString();
        }
        //.............................................................................................................
        //29-Convert String To Words
        void ConvertStringToWords()
        {
            WelcomeApp("Convert String To Words");
            Console.WriteLine("Please enter text");
            string text1 = ReadLines();
            string[] NewText = ConvertToWords(text1);
            Console.WriteLine($"the new text is");
            PrintArrayString(NewText);
        }
        string[] ConvertToWords(string Text1)
        {
            Text1 = Trim(Text1);
            string[] NewText1 = new string[Text1.Length / 2];
            StringBuilder NewText2 = new StringBuilder();
            int nCount = 0;
            foreach (char i in Text1)
            {
                if (i == ' ')
                {
                    NewText1[nCount] = NewText2.ToString();
                    nCount++;
                    NewText2.Clear();
                    continue;
                }
                NewText2.Append(i);
            }
            NewText1[nCount] = NewText2.ToString();
            NewText2.Clear();
            string[] NewText3 = ResizeArrayString(NewText1, nCount + 1);
            return NewText1;
        }
        //.............................................................................................................
        //30-Get Longest Word From String
        void GetLongestWordFromString()
        {
            WelcomeApp("Get Longest Word From String");
            Console.WriteLine("Please enter text");
            string text1 = ReadLines();
            string NewText = GetLongestWord(text1);
            Console.WriteLine($"the new text is {NewText}");
        }
        string GetLongestWord(string Text1)
        {
            Text1 = Trim(Text1);
            string[] Text2 = ConvertToWords(Text1);
            int nMax = 0;
            int nIndex = 0;
            for (int i = 0; i < Text2.Length; i++)
            {
                if (Text2[i].Length > nMax)
                {
                    nMax = Text2[i].Length;
                    nIndex = i;
                }
            }
            return Text2[nIndex];
        }
        //.............................................................................................................
        //31-Encrypts A String Using Caesar Cipher
        //32-Decodes A String Encoded With A Caesar Cipher
        void EncryptsAndDecryptsAStringUsingCaesarCipher()
        {
            WelcomeApp("Encrypts A String Using Caesar Cipher");
            Console.WriteLine("Please enter text");
            string text1 = ReadLines();
            Console.WriteLine("Please enter shift number");
            int nShift = ReadNumber();
            string NewText1 = Encrypt(text1, nShift);
            Console.WriteLine($"the new text is: \n( {NewText1} )");
            string NewText2 = Decrypt(NewText1, nShift);
            Console.WriteLine($"the new text is: \n( {NewText2} )");
        }
        string Encrypt(string Text1, int nShift)
        {
            int baseValue = 0;
            StringBuilder NewText = new StringBuilder();
            Text1 = Trim(Text1);
            foreach (char c in Text1)
            {
                if (!char.IsLetter(c))
                {
                    NewText.Append(c);
                    continue;
                }
                baseValue = (char.IsUpper(c)) ? 'A' : 'a';
                int nextChar = (c - baseValue + nShift) % 26 + baseValue;
                char NewChar = (char)nextChar;
                NewText.Append(NewChar);
            }
            return NewText.ToString();
        }
        string Decrypt(string Text1, int nShift)
        {
            int baseValue = 0;
            StringBuilder NewText = new StringBuilder();
            Text1 = Trim(Text1);
            foreach (char c in Text1)
            {
                if (!char.IsLetter(c))
                {
                    NewText.Append(c);
                    continue;
                }
                baseValue = (char.IsUpper(c)) ? 'A' : 'a';
                int nextChar = (c + baseValue - nShift) % 26 + baseValue;
                char NewChar = (char)nextChar;
                NewText.Append(NewChar);
            }
            return NewText.ToString();
        }
        /*string Encrypt(string Text1,int nShift)
        {
            StringBuilder NewText = new StringBuilder();
            Text1=Trim(Text1);
            foreach (char c in Text1)
            {
                int nChar = (int)c + nShift;
                //(c == ' ' || (int)c < 65 || ((int)c > 90 && (int)c < 97) || (int)c > 122)
                if (!char.IsLetter(c)) 
                {
                    NewText.Append(c);
                    continue;
                }
                else if ((int)c>=65&&(int)c<=90)
                {
                    while (nChar>90){nChar=nChar-26;}
                }
                else if ((int)c>=97 && (int)c<=122)
                {
                    while (nChar>122){nChar=nChar-26;}
                }
                char NewChar = (char)nChar;
                NewText.Append(NewChar);
            }
            return NewText.ToString();
        }*/
        #endregion
    }
}
