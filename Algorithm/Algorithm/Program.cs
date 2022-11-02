using Calculator;
using Fibonacci;
using StringCollection;
using SortCollection;

namespace Algorithm
{
    public class Program
    {
        private static ISortCollection? sortCollection;
        private static int size;
        private static int[]? numArray;
        private static int[]? sortResult;

        public static void Main(string[] args)
        { 
            string? option = "";


            Console.WriteLine("Welcome to Hyun's Algorithm!!");
            Console.WriteLine("Please select a number from the list.");
          

            while (option != null && !option.Equals("exit"))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("================================================");
                Console.WriteLine("Choose Algorithm");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Fibonacci");
                Console.WriteLine("3. String Collection");
                Console.WriteLine("4. Sort Collection");
                Console.WriteLine("================================================");
                Console.Write("> ");
                option = Console.ReadLine();
                Console.WriteLine("");

                switch (option)
                {      
                    case "1":
                        Console.WriteLine("================================================");
                        Console.WriteLine("Choose Calculator Options");
                        Console.WriteLine("1. Basic Calculator");
                        Console.WriteLine("2. ");
                        Console.WriteLine("More calculator options are under development");
                        Console.WriteLine("================================================");
                        Console.Write("> ");

                        string? calcOption = Console.ReadLine();
                        switch(calcOption)
                        {
                            case "1":
                                Console.Write("Enter First Number: ");
                                int a = Int32.Parse(Console.ReadLine());
                                Console.Write("Enter Operation: ");
                                string? o = Console.ReadLine();
                                Console.Write("Enter Second Number: ");
                                int b = Int32.Parse(Console.ReadLine());
                                BasicCalculator c = new BasicCalculator(a, o, b);
                                Console.WriteLine("Result: " + c.result());
                                break;
                            case "2":
                                break;
                            default:
                                break;
                        }
                        break;

                    case "2":
                        Console.Write("Enter a number: ");
                        int fiboNum = Int32.Parse(Console.ReadLine());
                        int FiboRes = Fibo.GetFibo(fiboNum);
                        Console.WriteLine("Result: " + FiboRes);
                        break;

                    case "3":
                        Console.WriteLine("================================================");
                        Console.WriteLine("Choose Calculator Options");
                        Console.WriteLine("1. Reverse");
                        Console.WriteLine("2. All Upper Case");
                        Console.WriteLine("More calculator options are under development");
                        Console.WriteLine("================================================");
                        Console.Write("> ");
                        string? strOption = Console.ReadLine();

                        switch(strOption)
                        {
                            case "1":
                                Console.Write("Enter a string: ");
                                string? reverseString = Console.ReadLine();
                                string result = ReverseString.Build(reverseString);
                                Console.WriteLine("Reverse String: " + result);
                                break;
                            case "2":
                                Console.Write("Enter a string: ");
                                string? allUpperCaseString = Console.ReadLine();
                                Console.WriteLine();
                                if (allUpperCaseString != null)
                                {
                                    Console.WriteLine(allUpperCaseString.ToUpper());
                                }
                                else
                                {
                                    Console.WriteLine("Require a string value");
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                        
                    case "4":
                        Console.WriteLine("================================================");
                        Console.WriteLine("Choose Sort Algorithm");
                        Console.WriteLine("1. Bubble Sort");
                        Console.WriteLine("2. Quick Sort");
                        Console.WriteLine("3. Selection Sort");
                        Console.WriteLine("More sort algorithm is under development");
                        Console.WriteLine("================================================");
                        Console.Write("> ");
                        string? sortOption = Console.ReadLine();


                        switch(sortOption)
                        {
                            

                            case "1":
                                Console.WriteLine("================================================");
                                Console.WriteLine("Choose Input Type");
                                Console.WriteLine("1. Random Input");
                                Console.WriteLine("2. Manual Input");
                                Console.WriteLine("================================================");
                                Console.Write("> ");
                                string? bubbleSortOption = Console.ReadLine();
                                switch (bubbleSortOption)
                                {
                                    case "1":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        Random Random = new Random();
                                        for (int i = 0; i < size; i++)
                                        {
                                            int n = Random.Next(0, 99);
                                            numArray[i] = n;
                                        }
                                        Console.Write("Sort Result: ");
                                        sortCollection = new BubbleSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    case "2":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        for (int i = 0; i < size; i++)
                                        {
                                            int n = Int32.Parse(Console.ReadLine());
                                            numArray[i] = n;
                                        }

                                        Console.Write("Sort Result: ");
                                        sortCollection = new BubbleSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                             
                                break;

                            case "2":
                                Console.WriteLine("================================================");
                                Console.WriteLine("Choose Input Type");
                                Console.WriteLine("1. Random Input");
                                Console.WriteLine("2. Manual Input");
                                Console.WriteLine("================================================");
                                Console.Write("> ");
                                string? quickSortOption = Console.ReadLine();
                                switch(quickSortOption)
                                {
                                    case "1":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        Random Random = new Random();
                                        for (int i = 0; i < size; i++)
                                        {
                                            int n = Random.Next(0, 99);
                                            numArray[i] = n;

                                        }
                                        Console.Write("Original Array:");
                                        for(int i = 0; i < numArray.Length; i++)
                                        {
                                            Console.Write(numArray[i] + ", ");
                                        }
                                        Console.WriteLine();
                                        Console.Write("Sort Result: ");
                                        sortCollection = new QuickSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    case "2":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        for (int i = 0; i < size; i++)
                                        {

                                            int n = Int32.Parse(Console.ReadLine());
                                            numArray[i] = n;

                                        }

                                        Console.Write("Sort Result: ");
                                        sortCollection = new QuickSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                
                                break;

                            case "3":
                                Console.WriteLine("================================================");
                                Console.WriteLine("Choose Input Type");
                                Console.WriteLine("1. Random Input");
                                Console.WriteLine("2. Manual Input");
                                Console.WriteLine("================================================");
                                Console.Write("> ");
                                string? selectionSortOption = Console.ReadLine();
                                switch (selectionSortOption)
                                {
                                    case "1":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        Random Random = new Random();
                                        for (int i = 0; i < size; i++)
                                        {
                                            int n = Random.Next(0, 99);
                                            numArray[i] = n;

                                        }
                                        Console.Write("Original Array:");
                                        for (int i = 0; i < numArray.Length; i++)
                                        {
                                            Console.Write(numArray[i] + ", ");
                                        }
                                        Console.WriteLine();
                                        Console.Write("Sort Result: ");
                                        sortCollection = new SelectionSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    case "2":
                                        Console.Write("Type Size of the Num Array: ");
                                        size = Int32.Parse(Console.ReadLine());
                                        numArray = new int[size];
                                        for (int i = 0; i < size; i++)
                                        {

                                            int n = Int32.Parse(Console.ReadLine());
                                            numArray[i] = n;

                                        }

                                        Console.Write("Sort Result: ");
                                        sortCollection = new SelectionSort();
                                        sortResult = sortCollection.Sort(numArray);
                                        for (int i = 0; i < sortResult.Length; i++)
                                        {
                                            Console.Write(sortResult[i] + ", ");
                                        }
                                        break;
                                    default:
                                        break;
                                }

                                break;

                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}