using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClassLibrary
{
    public class ClassLibraryMBNGBT
    {
        public List<int> SortingAndSerchInArrMissingNumbers(int[] arr, int arrLength)
        {
            List<int> ls = new List<int>();
            int index = 0;
            if (arr.Length != 0)
                SortingArr(ref arr);

            for (int i = 1; i <= arrLength; i++)
            {
                if (index != arr.Length && arr[index] <= i && arr.Length != 0)
                    index++;
                else
                    ls.Add(i);
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

        public Int32[] GetArrFiltringNumbersInTheText(string str)
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

        public bool SearchMatchingNumberInArr(int[] arr, int a)
        {
            for (int j = 0; j < arr.Length; j++)
                if (arr[j] == a)
                    return true;
            return false;
        }

        public bool ArrItemsEquals(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                SortingArr(ref arr1);
                SortingArr(ref arr2);
                for (int i = 0; i < arr1.Length; i++)
                    if (arr1[i] != arr2[i])
                        return false;
                return true;
            }
            return false;
        }

        public bool ArrItemsEqualswiThoutSorting(byte[] arr1, byte[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                    if (arr1[i] != arr2[i])
                        return false;
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
                tamp = exactArray[i];
                for (int j = 0; j < nonValidArray.Length; j++)
                {
                    if (exactArray[i] == nonValidArray[j])
                    {
                        j = nonValidArray.Length;
                        tamp = 0;
                    }
                }
                if (tamp != 0)
                    ls.Add(tamp);
            }
            return ls.ToArray();
        }

        /// <summary>
        /// Сравнивает два массива только с одинаковыми длиноми и возвращает массивы неправильных индексов и чисел։
        /// </summary>
        /// <param name="correctArray"></param>
        /// <param name="arrComparison"></param>
        /// <param name="arrayIndexOfIncorrectNumbers"></param>
        /// <returns></returns>
        public int[] GetArraysNon_validIndexsAndNumbers(int[] correctArray, int[] arrComparison, out int[] arrayIndexOfIncorrectNumbers)
        {
            try
            {
                if (correctArray.Length != arrComparison.Length)
                    throw new Exception();

                List<int> listIncorrectNumbers = new List<int>();
                List<int> listIndexsIncorrectNumbers = new List<int>();
                for (int i = 0; i < arrComparison.Length; i++)
                {
                    if (correctArray[i] != arrComparison[i])
                    {
                        listIncorrectNumbers.Add(i);
                        listIndexsIncorrectNumbers.Add(arrComparison[i]);
                    }
                }
                arrayIndexOfIncorrectNumbers = listIncorrectNumbers.ToArray();
                return listIndexsIncorrectNumbers.ToArray();
            }
            catch (Exception)
            {
                throw new Exception("The lengths of the arrays are not equal - длины массивы не равны");
            }
        }

        /// <summary>
        /// Сравнивает два массива только с одинаковыми длиноми и возвращает массивы неправильных индексов и чисел։
        /// </summary>
        /// <param name="correctArray"></param>
        /// <param name="arrComparison"></param>
        /// <param name="arrayIndexOfIncorrectNumbers"></param>
        /// <returns></returns>
        public byte[] GetArraysNon_validIndexsAndNumbers(byte[] correctArray, byte[] arrComparison, out byte[] arrayIndexOfIncorrectNumbers)
        {
            try
            {
                if (correctArray.Length != arrComparison.Length)
                    throw new Exception();

                List<byte> listIncorrectNumbers = new List<byte>();
                List<byte> listIndexsIncorrectNumbers = new List<byte>();
                for (byte i = 0; i < arrComparison.Length; i++)
                {
                    if (correctArray[i] != arrComparison[i])
                    {
                        listIncorrectNumbers.Add(i);
                        listIndexsIncorrectNumbers.Add(arrComparison[i]);
                    }
                }
                arrayIndexOfIncorrectNumbers = listIncorrectNumbers.ToArray();
                return listIndexsIncorrectNumbers.ToArray();
            }
            catch (Exception)
            {
                throw new Exception("The lengths of the arrays are not equal - длины массивы не равны");
            }
        }

        public double DecreaseInNumbersAfterTheDecimalPoint(double number, int newLanghtAfterTheDecimalPoint)
        {
            string temp = string.Empty;
            int index = (GetIndexFirstCommaInTheText(number.ToString()) + 1);
            if (index != 0)
            {
                if ((number.ToString().Length - index) >= newLanghtAfterTheDecimalPoint)
                    for (int i = 0; temp.Length != (newLanghtAfterTheDecimalPoint + index); i++)
                    {
                        temp += number.ToString()[i];
                    }
                else
                    return number;
            }
            else
                temp = number.ToString();

            return Convert.ToDouble(temp);
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
                    if (text.Length - 1 == i || !Char.IsLetter(text[i + 1]))
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

        public int GetCountArrayElementsEqual(string[] arr)
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

        public bool SearchBigNumberInArr(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > number)
                    return true;
            return false;
        }

        public int GetCountTheSimbolInText(string text, char simbol)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == simbol)
                    counter++;

            return counter;
        }

        public int GetIndexLastSimbolInText(string text, char simbol)
        {
            int index = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == simbol)
                    index = i;

            return index;
        }

        public int GetCountNumbersAfterSimbols(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
                if (Char.IsDigit(text[i]))
                    if (i == text.Length - 1 || !Char.IsDigit(text[i + 1]))
                        counter++;

            return counter;
        }

        public string DeleteExtraCommaInText(string text)
        {
            string temp = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (temp != string.Empty || text[i] != ',')
                {
                    if (text[i] == ',')
                    {
                        for (int j = i; j < text.Length; j++)
                        {
                            if ((text.Length - 1) == j || text[j + 1] != ',')
                            {
                                temp += text[i];
                                i = j;
                                j = text.Length;
                            }
                        }
                    }
                    else
                        temp += text[i];
                }
            }
            return temp;
        }

        public int GetCountAndArrBigNumbers(int[] arr, int minNumber, out int[] arrOut)
        {
            int count = 0;
            List<int> ls = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (minNumber < arr[i])
                {
                    ls.Add(arr[i]);
                    count++;
                }
            }
            arrOut = ls.ToArray();
            return count;
        }

        public bool IsSortedNumbers(int[] arr)
        {
            int[] arrTemp = new int[arr.Length];
            Array.Copy(arr, arrTemp, arr.Length);
            if (arr.Length != 0)
                SortingArr(ref arr);
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != arrTemp[i])
                    return false;
            return true;
        }

        public bool SearchEqualNumbersInALineAfterAComma(string text)
        {
            var arrNumbers = GetArrFiltringNumbersInTheText(text);
            for (int i = 0; i < arrNumbers.Length; i++)
                for (int j = i + 1; j < arrNumbers.Length; j++)
                    if (arrNumbers[i] == arrNumbers[j])
                        return true;
            return false;
        }

        public int[] DeleteItmesInArr(int[] arr, int startIndex, int finishIndex)
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                ls.Add(arr[i]);
                if (i == startIndex - 2)
                    i = finishIndex - 1;
            }
            return ls.ToArray();
        }

        public int[] DeleteItmesInArr(int[] arr, int index)
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                ls.Add(arr[i]);
                if (i != index - 2)
                    i = arr.Length;
            }
            return ls.ToArray();
        }

        public int GetCountNumberOfEqualDigits(int[] arr)
        {
            int counter = 0;
            int[] arrNew = new int[arr.Length];
            Array.Copy(arr, arrNew, arr.Length);
            if (arrNew.Length != 0)
                SortingArr(ref arrNew);
            for (int i = 0; i < arrNew.Length; i++)
            {
                if (i + 1 != arrNew.Length)
                    if (arrNew[i] == arrNew[i + 1])
                        counter++;
            }
            return counter;
        }

        public string GetOneTextArrItemsSeparationCommas(int[] arr)
        {
            string temp = string.Empty;
            for (int i = 0; i < arr.Length; i++)
                if (i != arr.Length - 1)
                    temp += $"{arr[i]},";
                else
                    temp += $"{arr[i]}";
            return temp;
        }

        public int[] GetRightNumbersInAnArray(int[] exactArray, int[] nonValidArray)
        {
            List<int> ls = new List<int>();
            for (int i = 0; i < nonValidArray.Length; i++)
            {
                for (int j = 0; j < exactArray.Length; j++)
                {
                    if (nonValidArray[i] == exactArray[j])
                    {
                        ls.Add(nonValidArray[i]);
                        j = exactArray.Length;
                    }
                }
            }
            ls.Sort();
            return ls.ToArray();
        }

        public int GetSumElementsInArr(int[] arr)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
                return sum;
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }

        public int GetMaxNumberInArr(int[] arr)
        {
            int temp = arr[0];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    if (temp < arr[i])
                        temp = arr[i];

                return temp;
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }

        public int GetMinNumberInArr(int[] arr)
        {
            int temp = arr[0];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                    if (temp > arr[i])
                        temp = arr[i];

                return temp;
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }

        public int GetIndexNameImageInArr(Image[] arr, string text)
        {
            for (int i = 0; i < arr.Length; i++)
                if (text == arr[i].Name)
                    return i;
            return -1;
        }

        public int GetCountthisNumberInArr(byte[] arr, int number)
        {
            int counter = 0;
            foreach (var item in arr)
                if (number == item)
                    counter++;
            return counter;
        }
    }
}
