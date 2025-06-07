using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class StringProgram
    {
        public StringBuilder GetDuplicateCharacter(string _title)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicateChar = new StringBuilder();

            foreach (var item in _title)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item); // Unique char in string
                }
                else
                {
                    duplicateChar.Append(item); // Duplicate char in string
                }
            }

            return duplicateChar;
        }

        public StringBuilder GetUniqueCharFromString(string _title)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicateChar = new StringBuilder();

            foreach (var item in _title)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item); // Unique char in string
                }
                else
                {
                    duplicateChar.Append(item);// Duplicate char in string
                }
            }

            return result;
        }

        public string ReverseString(string _title)
        {
            string result = "";

            if (string.IsNullOrEmpty(_title))
                return string.Empty;

            for (int i = _title.Length - 1; i >= 0; i--)
            {
                result += _title[i];
            }

            return result;
        }

        public string ReverseEachString(string _title)
        {
            string result = "";
            if (string.IsNullOrEmpty(_title))
                return string.Empty;

            string[] arr = _title.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    result += ReverseString(arr[i]) + " ";
                }
                else
                {
                    result += ReverseString(arr[i]) + " ";
                }
            }

            return result;
        }

        public int GetWordCount(string _title)
        {
            if (string.IsNullOrEmpty(_title))
                return 0;

            _title = _title.Trim();

            var length = _title.Split(' ').Length;

            return length;
        }

        public void GetFirstCharForEachWord(string sentence)
        {
            if (!string.IsNullOrEmpty(sentence))
            {
                string[] arr = sentence.Split(' ');

                foreach (string item in arr)
                {
                    Console.WriteLine(item.Substring(0, 1).ToUpper() + " ");
                }

                Console.ReadKey();
            }
        }

        public bool isPalandrom(string s)
        {
            string revs = "";
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
                return true;
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
                return false;
            }
            
        }
        static void Main1(string[] args)
        {
            StringProgram _stringDT = new StringProgram();
            var value1 = _stringDT.GetDuplicateCharacter("google");
            Console.WriteLine("Duplicate char in 'google' is = " + value1);
            

            var value2 = _stringDT.GetUniqueCharFromString("google");
            Console.WriteLine("Unique char in string 'google' is = " + value2);

            var value3 = _stringDT.ReverseString("google");
            Console.WriteLine("Reversed string for 'google' is = " + value3);

            var value4 = _stringDT.ReverseEachString("My name is mukesh");
            Console.WriteLine("Reversed string for 'My name is mukesh' is = " + value4);

            var value5 = _stringDT.GetWordCount("My name is mukesh");
            Console.WriteLine("Word count for the string 'My name   is mukesh' is = " + value5);

            string forLength = _stringDT.ReverseString("google");
            string resFirst = forLength.Substring(0, 1); // get First Character
            string resLast  = forLength.Substring(forLength.Length-1, 1); // get First Character

            Console.WriteLine("First Char of "+ forLength + " = " + resFirst);
            Console.WriteLine("Last  Char of "+ forLength + " = " + resLast);

            Console.ReadKey();
        }
    }
}
