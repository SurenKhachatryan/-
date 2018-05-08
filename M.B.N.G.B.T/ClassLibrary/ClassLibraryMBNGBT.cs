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

        public Int32[] FilteringDigitsInTheText(string str)
        {
            List<Int32> ls = new List<Int32>();
            string tamp = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    tamp += str[i];
                    if (Convert.ToInt64(tamp) > Int32.MaxValue)
                    {
                        tamp = Convert.ToString(Int32.MaxValue);
                    }
                    if (str.Length <= i + 1 || !Char.IsDigit(str[i + 1]) && tamp != string.Empty)
                    {
                        ls.Add(Convert.ToInt32(tamp));
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

        public int[] GetArrayMissingNumbersInAnArray(int[] exactArray, int[] nonValidArray)
        {
            List<int> ls = new List<int>();
            int tamp = 0;

            for (int i = 0; i < exactArray.Length; i++)
            {
                for (int j = 0; j < nonValidArray.Length; j++)
                {
                    tamp = exactArray[i];
                    if (exactArray[i] == nonValidArray[j])
                    {
                        j = nonValidArray.Length;
                        tamp = 0;
                    }
                }
                if (tamp != 0)
                {
                    ls.Add(tamp);
                }
            }
            return ls.ToArray();
        }

        public double DecreaseInNumbersAfterTheDecimalPoint(double number, int newLanghtAfterTheDecimalPoint)
        {
            string tamp = string.Empty;
            int index = (GetIndexFirstCommaInTheText(number.ToString()) + 1);

            if ((number.ToString().Length - index) >= newLanghtAfterTheDecimalPoint)
                for (int i = 0; tamp.Length != (newLanghtAfterTheDecimalPoint + index); i++)
                {
                    tamp += number.ToString()[i];
                }
            else
                return number;

            return Convert.ToDouble(tamp);
        }

        public int GetIndexFirstCommaInTheText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',')
                    return i;
            }
            return -1;
        }
    }
}
