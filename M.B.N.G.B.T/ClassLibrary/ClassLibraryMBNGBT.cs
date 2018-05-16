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

        public bool SearchWordInArr(string[] arrWord, string word)
        {
            if (arrWord.Length > 0)
            {
                for (int i = 0; i < arrWord.Length; i++)
                {
                    if (word == arrWord[i])
                        return true;
                }
            }
            else
                throw new ArgumentOutOfRangeException();

            return false;
        }

        public string[] GetRandomArrWord(string[] arrWord, int wordsCount)
        {
            List<string> ls = new List<string>();
            Random rnd = new Random();
            DeleteSpaceInArrWords(ref arrWord);
            if (arrWord.Length <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            if (arrWord.Length >= wordsCount)
            {
                for (int i = 0; i < wordsCount; i++)
                {
                    int index = rnd.Next(arrWord.Length);
                    if (ls.Count == 0 || !SearchWordInArr(ls.ToArray(), arrWord[index]))
                        ls.Add(arrWord[index]);
                    else
                        i--;
                }
            }
            else
                throw new IndexOutOfRangeException();

            return ls.ToArray();
        }

        public void DeleteSpaceInArrWords(ref string[] arrWord)
        {
            string tamp = string.Empty;
            string word = string.Empty;
            if (arrWord.Length > 0)
            {
                for (int i = 0; i < arrWord.Length; i++)
                {
                    word = arrWord[i];
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] != ' ')
                            tamp += word[j];
                    }
                    arrWord[i] = tamp;
                    tamp = string.Empty;
                }
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public bool ArrItemsEquals(string[] arr1, string[] arr2)
        {
            string tamp1 = string.Empty;
            string tamp2 = string.Empty;
            if (arr1.Length == arr2.Length)
            {
                SortingArrWordsByLength(ref arr1);
                SortingArrWordsByLength(ref arr2);
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].Length != arr2[i].Length)
                        return false;

                    tamp1 = arr1[i];
                    tamp2 = arr2[i];
                    for (int j = 0; j < tamp1.Length; j++)
                    {
                        if (tamp1[j] != tamp2[j])
                            return false;
                    }
                }
            }
            else
                return false;

            return true;
        }

        public string[] FilteringLetterInTheTextAndGetArrWords(string text)
        {
            List<string> ls = new List<string>();
            string tamp = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    tamp += text[i];
                    if (text.Length-1 == i || !Char.IsLetter(text[i + 1]))
                    {
                        ls.Add(tamp);
                        tamp = string.Empty;
                    }
                }
            }

            return ls.ToArray();
        }

        public void SortingArrWordsByLength(ref string[] arrWord)
        {
            string tamp = arrWord[0];
            int index = 0;

            for (int i = 0; i < arrWord.Length; i++)
            {
                tamp = arrWord[i];
                for (int j = i; j < arrWord.Length; j++)
                {
                    if (tamp.Length >= arrWord[j].Length)
                    {
                        tamp = arrWord[j];
                        index = j;
                    }
                }
                arrWord[index] = arrWord[i];
                arrWord[i] = tamp;
            }
        }

        public string[] GetArrayMissingWordsInAnArray(string[] exactArray, string[] nonValidArray)
        {
            List<string> ls = new List<string>();
            int index = 0;

            for (int i = 0; i < exactArray.Length; i++)
            {
                index = i;
                for (int j = 0; j < nonValidArray.Length; j++)
                {
                    if (exactArray[i] == nonValidArray[j])
                    {
                        index = -1;
                        j = nonValidArray.Length;
                    }
                }
                if (index != -1)
                    ls.Add(exactArray[index]);
            }
            return ls.ToArray();
        }

        public bool SearchInArrayEqualElements(string[] arr)
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                            return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int GetCuntArrayElementsEqual(string[] arr)
        {
            int tamp = 0;
            try
            {
                if (SearchInArrayEqualElements(arr))
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                tamp++;
                                break;
                            }
                        }
                    }
                }
                return tamp;
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
