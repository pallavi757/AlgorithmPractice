using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationString
{

    public class StringPermutaion
    {
        public static void Recursion(string S, int start)
        {
            int Length = S.Length;

            for (int i = start; i < Length; i++)
            {
                S = (Swap(S, start, i));
                Console.WriteLine(S);
                Recursion(S, start + 1);
                S = Swap(S, start, i);
            }
        }
        public static string Swap(string S, int start, int end)
        {
            char temp;
            char[] charArray = S.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string str = new string(charArray);
            return str;
        }
       
        public void Getuser()
        {
           // Console.WriteLine("String permutations");
            Console.Write("Enter String: ");
            string S = Console.ReadLine();
            Recursion(S, 0);
        }

    }
}
