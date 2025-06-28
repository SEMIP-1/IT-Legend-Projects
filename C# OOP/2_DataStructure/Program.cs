using System.Collections;

namespace _2_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.MainProgram();
            Console.WriteLine("Goodbye, World!");
        }
        void MainProgram()
        {
            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine("Enter the number of the case");
                Console.WriteLine("1- ArrayList Basic Operations");
                Console.WriteLine("2- ArrayList Performance");
                Console.WriteLine("3- Generic List");
                Console.WriteLine("4- Stack Training");
                Console.WriteLine("5- Undo Example");
                Console.WriteLine("6- Printer Example");
                Console.WriteLine("7- Learn Dictionaries");
                Console.WriteLine("8- Learn Hashset");
                Console.WriteLine("9- Learn SortedList\n");
                Console.WriteLine("Enter the number of the case");
                int nCase = ReadNumber();
                switch (nCase)
                {
                    case 1:
                        ArrayListBasicOperations();
                        break;
                    case 2:
                        ArrayListPerformance();
                        break;
                    case 3:
                        GenericList();
                        break;
                    case 4:
                        StackTraining();
                        break;
                    case 5:
                        UndoExample();
                        break;
                    case 6:
                        Printer();
                        break;
                    case 7:
                        LearnDictionaries();
                        break;
                    case 8:
                        LearnHashset();
                        break;
                    case 9:
                        LearnSortedList();
                        break;
                }
                Console.WriteLine("Do You Want to continue? Yes=y ,No=n");
                string sContinue = ReadLines();
                RunProgram = (sContinue == "y");
            }
        }
        //-------------------Data Structure----------------------------------
        //-------------------1- Array------------------------
        // 4- Array List Basic Operations
        void ArrayListBasicOperations()
        {
            Console.WriteLine("--------ArrayList Basic Operations---------");
            // intalaization
            ArrayList myList = new ArrayList();
            // adding items
            Console.WriteLine("--------List adding---------");
            Console.WriteLine(myList.Capacity);
            myList.Add(10);
            myList.Add(30);
            myList.Add(15);
            Console.WriteLine(myList.Count);
            //Access by index
            Console.WriteLine("--------list by index----------");
            Console.WriteLine(myList[1]);
            // loop for all items
            Console.WriteLine("--------Looping to print after adding--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("--------");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //remove items
            Console.WriteLine("--------Remove item at index 2--------------");
            myList.Remove(myList[2]);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //search for items
            Console.WriteLine("--------Search for item 10--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                if (Convert.ToInt32(myList[i]) == 10)
                {
                    Console.WriteLine("Item found");
                }
                ;
            }
            // clear list
            Console.WriteLine("--------Clear List--------------");
            myList.Clear();
        }
        // 5-Array List Performance
        void ArrayListPerformance()
        {
            // int =>>>>>object boxing
            // object =>>>>>int unboxing (Convert)
            Console.WriteLine("--------ArrayList Basic Operations---------");
            // intalaization
            ArrayList myList = new ArrayList();
            // adding items
            Console.WriteLine("--------List adding---------");
            int[] number = new int[3] { 1, 2, 3 };
            Console.WriteLine(myList.Capacity);
            myList.Add(10);
            myList.Add(30);
            myList.Add(15);
            myList.AddRange(number);
            myList.Insert(1, 500);
            Console.WriteLine(myList.Count);
            //Access by index
            Console.WriteLine("--------list by index----------");
            Console.WriteLine(myList[1]);
            // loop for all items
            Console.WriteLine("--------Looping to print after adding--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("--------");
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //remove items
            Console.WriteLine("--------Remove item at index 1--------------");
            //myList.Remove(myList[2]);
            myList.RemoveAt(1);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //search for items
            Console.WriteLine("--------Search for item 10--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                if (Convert.ToInt32(myList[i]) == 10)
                {
                    Console.WriteLine("Item found");
                }
                ;
            }
            // clear list
            Console.WriteLine("--------Clear List--------------");
            myList.Clear();
        }
        //6-Generic List
        void GenericList()
        {
            // Most used 
            Console.WriteLine("--------ArrayList Basic Operations---------");
            // intalaization
            List<string> myList = new List<string>();
            // adding items
            Console.WriteLine("--------List adding---------");
            Console.WriteLine(myList.Capacity);
            myList.Add("10");
            myList.Add("30");
            myList.Add("15");
            Console.WriteLine(myList.Count);
            //Access by index
            Console.WriteLine("--------list by index----------");
            Console.WriteLine(myList[0]);
            // loop for all items
            Console.WriteLine("--------Looping to print after adding--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("--------");
            foreach (string i in myList)
            {
                Console.WriteLine(i);
            }
            //remove items
            Console.WriteLine("--------Remove item at index 2--------------");
            myList.Remove(myList[2]);
            foreach (string i in myList)
            {
                Console.WriteLine(i);
            }
            //search for items
            Console.WriteLine("--------Search for item 10--------------");
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == "10")
                {
                    Console.WriteLine("Item found");
                }
                ;
            }
            // clear list
            Console.WriteLine("--------Clear List--------------");
            myList.Clear();

        }
        //8-Stack
        void StackTraining()
        {
            Console.WriteLine("--------ArrayList Basic Operations---------");
            // intalaization
            string[] names = new string[3] { "ahmed", "mohamed", "mostafa" };
            Stack<string> myStack = new Stack<string>(names);
            var newNames = myStack.ToArray();
            // adding items
            Console.WriteLine("--------List adding---------");
            myStack.Push("10");
            myStack.Push("30");
            myStack.Push("15");
            Console.WriteLine(myStack.Count);
            //Access top element
            Console.WriteLine("--------Top element----------");
            string name = myStack.Peek();
            name = myStack.Pop();
            name += "ahmed";
            myStack.Push(name);
            Console.WriteLine(name);
            //remove items
            Console.WriteLine("--------Remove item--------------");
            myStack.Pop();
            //search for items
            Console.WriteLine("--------Search for item 10--------------");
            foreach (string i in myStack)
            {
                Console.WriteLine(i);
                if (i == "10")
                {
                    Console.WriteLine("Item found");
                }
                ;
            }
            Console.WriteLine("--------------");
            for (int i = 0; i < myStack.Count; i++)
            {
                Console.WriteLine(myStack.ElementAt(i));
            }
            Console.WriteLine("--------------");
            bool ifContains = myStack.Contains("30");
            Console.WriteLine(ifContains);
            // clear list
            Console.WriteLine("--------Clear List--------------");
            myStack.Clear();
        }
        //10-Undo Example
        void UndoExample()
        {
            List<string> lstWords = new List<string>();
            Stack<string> stUndo = new Stack<string>();
            while (true)
            {
                string massage = @"""1-Add 
2-Remove 
3-Undo Remove
4-Show 
5-Exit""";
                Console.WriteLine(massage);
                int nchoise = ReadNumber();
                switch (nchoise)
                {
                    case 1:
                        AddTest();
                        break;
                    case 2:
                        RemoveTest();
                        break;
                    case 3:
                        UndoRemove();
                        break;
                    case 4:
                        Show();
                        break;
                    case 5:
                        return;
                }
            }
            void AddTest()
            {
                Console.WriteLine("Enter the text");
                lstWords.Add(ReadLines());

                Show();
            }
            void RemoveTest()
            {
                string word = lstWords[lstWords.Count - 1];
                lstWords.RemoveAt(lstWords.Count - 1);
                stUndo.Push(word);
                Show();
            }
            void UndoRemove()
            {
                string word = stUndo.Pop();
                lstWords.Add(word);
                Show();
            }
            void Show()
            {
                Console.WriteLine("-------list--------");
                foreach (string word in lstWords)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("-------------------");
            }
        }
        //11-Queue & 12-Printer Example
        //FIFO (Firstr In First Out)
        void Printer()
        {
            Queue<String> queue = new Queue<string>();
            while (true)
            {
                Console.WriteLine($"Please enter Action\n"
                + "1- Add file\n"
                + "2- Print file\n"
                + "3- Exit\n"
                + "-------------");
                int nChoice = ReadNumber();
                Console.WriteLine("Your Choisce is: " + nChoice);
                Console.WriteLine("-------------");
                switch (nChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the file name");
                        string fileName = ReadLines();
                        Console.WriteLine($"File {fileName} is added to the queue");
                        queue.Enqueue(fileName);
                        Console.WriteLine($"there are {queue.Count} files in the queue");
                        Console.WriteLine("-------------");
                        break;
                    case 2:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("No files to print");
                            Console.WriteLine("-------------");
                        }
                        else
                        {
                            string file = queue.Dequeue();
                            Console.WriteLine($"File {file} is printed");
                            Console.WriteLine("-------------");
                        }
                        break;
                    case 3:
                        return;
                }
            }
        }
        //****************************************************************
        //-------------------2- Hash Table-------------------
        //14-Dictionaries
        void LearnDictionaries()
        {
            Console.WriteLine("--------Dictionaries Basic Operations---------");
            // intalaization
            Dictionary<string, string> dic = new Dictionary<string, string>();
            // adding items
            Console.WriteLine("--------List adding---------");
            dic.Add("Languages", "C#");
            dic.Add("IDE", "VS");
            dic.Add("OS", "Windows");
            Console.WriteLine(dic.Count);
            //Access by Key
            Console.WriteLine("--------list by Key----------");
            var dicValue = dic["Languages"];
            Console.WriteLine(dicValue);
            //remove items
            Console.WriteLine("--------Remove item--------------");
            dic.Remove("IDE");
            //search for items
            Console.WriteLine("--------Search for item --------------");
            if (dic.ContainsKey("OS"))
            {
                Console.WriteLine("Item found");
            }
            if (dic.ContainsValue("OS"))
            {
                Console.WriteLine("Item found");
            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            int nCount = dic.Count;
            while (nCount > 0)
            {
                // do something
                nCount--;
            }
            // clear list
            Console.WriteLine("--------Clear List--------------");
            dic.Clear();
        }
        //****************************************************************
        //15-Hashset / 16-Hashset Operations
        void LearnHashset()
        {
            Console.WriteLine("--------Hashset Basic Operations---------");
            // intalaization
            HashSet<string> dic = new HashSet<string>();
            // adding items
            Console.WriteLine("--------List adding---------");
            dic.Add("Languages");
            dic.Add("IDE");
            dic.Add("IDE");
            dic.Add("OS");
            Console.WriteLine(dic.Count);
            //Access by Key
            Console.WriteLine("--------Access by Key----------");
            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            var dicValue = dic.Contains("Languages");
            string? myItem = string.Empty;
            dic.TryGetValue("IDE", out myItem);
            //remove items
            Console.WriteLine("--------Remove item--------------");
            dic.Remove("IDE");
            Console.WriteLine(dicValue);
            // clear list
            Console.WriteLine("--------Clear List--------------");
            dic.Clear();
            string word = "this is the best developer in developer company";
            string word2 = "the cest c# course in the market";
            dic = new HashSet<string>(word2.Split(' '));
            Console.WriteLine($"this is word: ({word})");
            var dic2 = new HashSet<string>(word.Split(' '));
            var ArrayOfWords = dic2.ToArray();
            Console.WriteLine(string.Join(" ", dic2));
            dic.UnionWith(dic2);
            Console.WriteLine(string.Join(" ", dic));
            dic.IntersectWith(dic2);
            Console.WriteLine(string.Join(" ", dic));
            dic.ExceptWith(dic2);
            Console.WriteLine(string.Join(" ", dic));
        }
        //****************************************************************
        //17-Sortedlist
        void LearnSortedList()
        {
            Console.WriteLine("--------SortedList Basic Operations---------");
            // intalaization
            SortedList<int, string> Tasks = new SortedList<int, string>();
            // adding items
            Console.WriteLine("--------List adding---------");
            Tasks.Add(0, "Print PDf");
            Tasks.Add(10, "Prepare ASP.Net course");
            Tasks.Add(1, "Attend meeting in room 7");
            Console.WriteLine(Tasks.Count);
            //Access by Key
            Console.WriteLine("--------Access by Key----------");
            var myTask = Tasks[1];
            //remove items
            Console.WriteLine("--------Remove item--------------");
            Tasks.Remove(1);
            //search for items
            Console.WriteLine("--------Search for item --------------");
            Tasks.ContainsKey(10);
            Tasks.ContainsValue(myTask);
            foreach (var item in Tasks)
            {
                Console.WriteLine($"{item.Key} ==> {item.Value}");
            }
            // clear list
            Console.WriteLine("--------Clear List--------------");
            Tasks.Clear();
            Console.WriteLine(Tasks.Count);
        }
        //****************************************************************
        //--------------------------------------------------------------
        // Read integer from user
        int ReadNumber()
        {
            int Number = 0;
            bool isConverted = int.TryParse(Console.ReadLine(), out Number);
            if (!isConverted)
            {
                Console.WriteLine("Enter a valid number");
            }
            return Number;
        }
        // Read lines from user
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
        //--------------------------------------------------------------
    }
}
