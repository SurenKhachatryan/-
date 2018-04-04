using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassLibraryMBNGBT
    {
        public static bool MatchingNumber(int[] arr, int a)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == a)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
