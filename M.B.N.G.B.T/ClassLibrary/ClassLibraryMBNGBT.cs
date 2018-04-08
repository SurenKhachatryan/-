using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassLibraryMBNGBT
    {
        public bool MatchingNumber(int[] arr, int a)
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

        public bool ArrItemsEquals(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                SortingArr(ref arr1);
                SortingArr(ref arr2);
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public void SortingArr(ref int[] arr)
        {
            int index = 0;
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (temp >= arr[j])
                    {
                        temp = arr[j];
                        index = j;
                    }
                }
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
