using System;
using System.Text.RegularExpressions;

namespace string2int
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput1 = "abc573";
            int number1 = String2Int(textInput1);
            Console.WriteLine(number1);
            string textInput2 = "a5b7c3";
            int number2 = String2Int(textInput2);
            Console.WriteLine(number2);
        }

        public static int String2Int(string textInput)
        {
            var regex = new Regex(@"\d+");
            if (!regex.IsMatch(textInput)) {
                Console.WriteLine($"{textInput} test digit is not support.");
                return 0;
            }
            var matches = regex.Matches(textInput);
            var strNum = string.Join(string.Empty, matches);
            var num = ConvertToInt(strNum);
            return num;
        }

        public static int ConvertToInt(string s) 
        {
            int num = 0;
            int n = s.Length;
            // Iterate till length of the string
            for (int i = 0; i < n; i++) {
                num = num * 10 + (s[i] - 48);
            }
            return num;
        }
    }
}
