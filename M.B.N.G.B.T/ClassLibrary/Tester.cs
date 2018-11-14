using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Tester
    {
        private static readonly string allSimbols = @"0123ABCDEF';/.,""GHIJKLMopqrstuvwxyzN456789ab_+|}{:?>OPQRSTUVWXYZ<\][cdefghijklmn!@#$%^&*() ";
        public static readonly string reference = @"C:\Windows\Trol";
        public static readonly string fileName = "U15K97E53Y124Y14.dll";
        private static readonly int[] keyUP = { 78, 80, 72, 84, 77, 67, 57, 55, 74, 77, 57, 77, 80, 71, 84, 51, 86, 54, 54, 84 };
        private static readonly int[] keyDown = { 110, 112, 104, 116, 109, 99, 57, 55, 106, 109, 57, 109, 112, 103, 116, 51, 118, 54, 54, 116 };

        public static void CreateFile()
        {
            Directory.CreateDirectory(@"C:\Windows\Trol");
            File.WriteAllText(@"C:\Windows\Trol\U15K97E53Y124Y14.dll", $"{GetRandomTextFromAllSimbols(50000)}");
            File.SetAttributes(@"C:\Windows\Trol\U15K97E53Y124Y14.dll", FileAttributes.Hidden);
        }

        static string GetRandomTextFromAllSimbols(int length)
        {
            string str = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                str += allSimbols[rnd.Next((allSimbols.Length - 1))];
            return str;
        }

        public static bool IsKey(string Text)
        {
            string str = string.Empty;

            if (Text.Length != keyUP.Length)
                return false;

            for (int i = 0; i < keyUP.Length; i++)
            {
                if (Text[i] == keyUP[i])
                    str += Convert.ToChar(keyUP[i]).ToString();
                else
                if (Text[i] == keyDown[i])
                    str += Convert.ToChar(keyDown[i]).ToString();
                else
                    return false;
            }
            if (str == Text)
                return true;

            return false;
        }
    }
}
