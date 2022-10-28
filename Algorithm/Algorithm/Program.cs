using Calculator;
using Fibonacci;
using StringCollection;
using SortCollection;

namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? option = "";
          

            while (option != null && !option.Equals("exit"))
            {
                Console.WriteLine("");
                Console.WriteLine("========================");
                Console.WriteLine("Choose Algorithm");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Fibonacci");
                Console.WriteLine("3. Reverse String");
                Console.WriteLine("4. Sort Collection");
                Console.WriteLine("========================");
                Console.Write("> ");
                option = Console.ReadLine();
                Console.WriteLine("");

                switch (option)
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
                        Console.Write("Enter a number: ");
                        int fiboNum = Int32.Parse(Console.ReadLine());
                        int FiboRes = Fibo.GetFibo(fiboNum);
                        Console.WriteLine("Result: " + FiboRes);
                        break;
                    case "3":
                        Console.Write("Enter a string: ");
                        string? reverseString = Console.ReadLine();
                        string result = ReverseString.Build(reverseString);
                        Console.WriteLine("Reverse String: " + result);
                        break;
                    case "4":
                        Console.WriteLine("========================");
                        Console.WriteLine("Choose Sort Algorithm");
                        Console.WriteLine("1. Bubble Sort");
                        Console.WriteLine("2. Fibonacci");
                        Console.WriteLine("3. Reverse String");
                        Console.WriteLine("4. Sort Collection");
                        Console.WriteLine("========================");
                        Console.Write(">");
                        string? sortOption = Console.ReadLine();
                        switch(sortOption)
                        {
                            case "1":
                                Console.Write("Type Size of the Num Array: ");
                                int size = Int32.Parse(Console.ReadLine());
                                int[] numArray = new int[size];
                                for(int i = 0; i < size; i++) 
                                {
                                    int n = Int32.Parse(Console.Read());
                                    numArray[0] = n;

                                }
                                int[] sortResult = BubbleSort.Build(numArray);
                                for(int i = 0; i < sortResult.Length; i++)
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
            }

            
        }



    }
}