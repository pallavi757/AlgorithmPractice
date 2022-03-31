using System;
namespace AlgorithmProgram
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 For String Permutations");
            Console.WriteLine("2 For Binary Search");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StringPermutaion stringPermutaion = new StringPermutaion();
                    stringPermutaion.Getuser();
                    break;
                case 2:
                    BinarySearch bs = new BinarySearch();
                    Console.WriteLine("Enter the word for search ");
                    string word = Console.ReadLine();
                    int result = bs.binarySearch(word);
                    if (result == 1)
                        Console.WriteLine("Item not present");
                    else
                        Console.WriteLine("Item at index " + result);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

    }
}