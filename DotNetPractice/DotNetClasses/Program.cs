using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    //Generic Class 
    class KeyValuePairs<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    class DataStore<T>
    {
        public T Data { get; set; }
    }

    interface IVendorTransDetails
    {
        void getVendorID();
    }
    class ClaimsMaster
    {
        virtual public string getDCNNO()
        {
            return "PC20100308A00005";
        }
    }

    abstract class Abstract : ClaimsMaster, IVendorTransDetails
    {
        //Here we should implement modifiers oterwise it throws complie-time error  
        public void getVendorID()
        {
            int s = new int();
            s = 001;
            Console.Write(s);
        }

        // Virtual Function Override
        public override string getDCNNO()
        {
            return "NEW PC20100308A00005";
        }
    }

    abstract class Animal : Abstract
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Calculation
    {
        public float add(int a, int b)
        {
            return a + b;
        }
    }

    class ScientificCalculation : Calculation
    {
        public float mod(int a, int b)
        {
            float ans = add(1, 2);
            return a % b;
        }
        public float multiply(float a, float b)
        {
            float ans = a*b;
            return ans;
        }
        public int multiply(int a, float b)
        {
            int ans = (int)(a * b);
            return ans;
        }
    }

    public static class StringClass
    {
        // Method 5
        public static int ToInt(this string g)
        {
            return Convert.ToInt32(g);
        }
    }

    class Program
    {
        private static string print()
        {
            return "Hi, I am Dharmanshu!";
        }
        static void Main1(string[] args)
        {
            ScientificCalculation calculation = new ScientificCalculation();
            Console.Write(calculation.multiply(float.MaxValue, float.MaxValue)); // Print infinity sign
            
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            Console.WriteLine("-----------------Extension---------------------------");
            string ex = "55";
            ex.ToInt();
            Console.WriteLine("-----------------Extension---------------------------");


            Console.WriteLine("-----------------Hashtable---------------------------");
            //Hashtable is non - generic type.
            //Hashtable is a weakly typed data structure, so you can add keys and values of any object type.
            //Values need to have boxing / unboxing.
            //When you try to access non existing key Hashtable, it gives null values.
            //Hashtable never maintains an order of the stored values.
            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add(1, "Welcome");
            my_hashtable.Add("A2", "to");
            my_hashtable.Add(3, "GeeksforGeeks");
            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
            //string nname = my_hashtable["A4"].ToString(); // Gives Error
            Console.WriteLine("-----------------Hashtable---------------------------");


            Console.WriteLine("-----------------Dictionary---------------------------");
            //When you try to access non existing key dictionary, it gives runtime error.
            //Dictionary maintains an order of the stored values.
            Dictionary<string,string> my_dic = new Dictionary<string, string>();
            my_dic.Add("A1", "Welcome");
            my_dic.Add("A2", "to");
            my_dic.Add("A3", "GeeksforGeeks");
            foreach (KeyValuePair<string, string> element in my_dic)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   element.Key, element.Value);
            }
            //string name = my_dic["A4"]; // GIVES Error
            
            Console.WriteLine("-----------------Dictionary---------------------------");

            // Custome Generic Class
            DataStore<string> store = new DataStore<string>();

            // Jagged Array
            int[][] jArray = new int[2][];
            jArray[0] = new int[3] { 1, 2, 3 };
            jArray[1] = new int[4] { 4, 5, 6, 7 };

            GC.Collect();

            int[] i = new int[0];
            //Console.WriteLine(i[0]); // Error Index out of bound

            Program obj = null;
            Console.WriteLine(print()); // Output

            // ArrayList
            ArrayList array1 = new ArrayList();
            array1.Add(1);
            array1.Add("Pony");
            foreach (var x in array1)
            {
                Console.WriteLine(x);
            }

            // List
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            foreach (var x in list1)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }


}
