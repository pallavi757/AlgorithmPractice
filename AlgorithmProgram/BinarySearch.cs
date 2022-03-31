using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BinarySearch
    {
        public int binarySearch(String SearchWord)
        {
            String[] arr = { "Java", "C-Programming", "C-Sharp", "Python" };
            int left_ind = 0, right_ind = arr.Length - 1;
            while (left_ind <= right_ind)
            {
                int temp = left_ind + (right_ind - left_ind) / 2;
                int res = SearchWord.CompareTo(arr[temp]);

                if (res == 0)
                    return temp;
                if (res > 0)
                    left_ind = temp + 1;
                else
                    right_ind = temp - 1;
            }
            return 1;
        }
    }
}
