using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Test
    {
        public int intReturn(int a)
        {
            return 10;
        }

        public static void Main1(string[] args)
        {
            TestDerived t = new TestDerived();
            Console.WriteLine(t.intReturn(10));
            Console.ReadKey();
        }
    }

    class TestDerived : Test
    {
        public int intReturn(int a)
        {
            return 15;
        }
    }
    internal class Practice
    {
        // Keep in mind, main() is not acceptable, Main() is 
        public static void Main(string[] args)
        {
            Practice p = new Practice();
            int[] a = { 1, 2, 3, 3 };
            int[] b = { 1, 2, 3 };

            Console.WriteLine(p.getTargetIndexValues(a, b,4)); // get Target Index Values
            
            Console.WriteLine(p.reverseString("google")); // reverse String

            Console.WriteLine(p.isPalendrom("radar")); // is Palendrom

            p.findFrequencyOfTarget(a,3); // find Frequency Of Target

            p.printArray(p.rotateArray(new[] { 10, 20, -30, -40, 50 })); // Rotate Array

            Console.ReadKey();
        }
        
        public int[] rotateArray(int[] numbers)
        {
            int size = numbers.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = numbers[(i + 1) % size];
            }
            return shiftNums;
        }
        public void findFrequencyOfTarget(int[] a, int target)
        {
            List<int> found = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        count++;
                    }
                }
                if (count > 1 && !found.Contains(a[i]))
                {
                    found.Add(a[i]);
                    Console.WriteLine(a[i] + " is repeating " + count + " Times");
                }
            }
        }
        public bool isPalendrom(string str)
        {
            if (str == reverseString(str))
            {
                return true;
            }
            else
                return false;
        }
        public string reverseString(string str)
        {
            StringBuilder rStr = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
            {
                rStr = rStr.Append(str[i]);
            }
            return rStr.ToString();
        }
        public string getTargetIndexValues(int[] a, int[]b , int target)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] + b[j] == target)
                    {
                        return a[i] + " " + b[j];
                    }
                }
            }
            return "";
        }
        public void printArray(int[] a)
        {
            foreach (var i in a)
            {
                Console.Write(i.ToString() + " ");
            }
        }
    }
}
