using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassLibraryMBNGBT
    {
        public List<int> SortingAndSerchInArrMissingNumbers(int[] arr, int arrLength)
        {
            List<int> ls = new List<int>();
            int index = 0;
            if (arr.Length != 0)
            {
                SortingArr(ref arr);
            }
            for (int i = 1; i <= arrLength; i++)
            {
                if (index != arr.Length && arr[index] <= i && arr.Length != 0)
                {
                    index++;
                }
                else
                {
                    ls.Add(i);
                }
            }
            return ls;
        }

        public string CopyTheText(string str, int startLength, int finishLength)
        {
            string tamp = string.Empty;
            try
            {
                for (int i = startLength; i < finishLength; i++)
                {
                    tamp += str[i];
                }
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
            return tamp;
        }

        public ulong[] FilteringDigitsInTheText(string str)
        {
            List<ulong> ls = new List<ulong>();
            string tamp = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    tamp += str[i];
                    if (str.Length <= i + 1 || !Char.IsDigit(str[i + 1]) && tamp != string.Empty)
                    {
                        ls.Add(Convert.ToUInt64(tamp));
                        tamp = string.Empty;
                    }
                }
            }
            return ls.ToArray();
        }

        public bool SerchMatchingNumberInArr(int[] arr, int a)
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
            if (arr.Length != 0)
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
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private static int[] GetArrayTheExcessNumberInTheArray(int[] theRightArray, int[] nonValidArray)
        {
            List<int> ls = new List<int>();
            int length = theRightArray.Length;
            int indexchihstarr = 0;

            if (theRightArray.Length < nonValidArray.Length)
                length = nonValidArray.Length;

            for (int i = 0; i < length; i++)
            {
                if (theRightArray[indexchihstarr] == nonValidArray[i])
                {
                    if (indexchihstarr + 1 != theRightArray.Length - 1)
                        indexchihstarr++;
                }
                else
                {
                    ls.Add(nonValidArray[i]);
                }
            }

            return ls.ToArray();
        }
    }
}
