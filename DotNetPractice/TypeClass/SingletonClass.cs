using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.TypeClass
{
    class Singleton
    {
        // Singleton/static class
        // In C#, one is allowed to create a singleton/static class, by using static keyword.
        // A static class can only contain static data members, static methods, and a static constructor.
        // It is not allowed to create objects of the static class.
        // Static classes are sealed, means you cannot inherit a static class from another class.


        // Create a static variable of class and initialise it with a object in a static method
        private static Singleton Instance;
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public void Display()
        {
            Console.WriteLine(true);
        }
       
    }
    internal class SingletonClass
    {
        public static void Main1()
        {
            Singleton.getInstance().Display();
            Console.ReadKey();
        }
    }
}

// Thread Safety Singleton
public sealed class Singleton2
{
    Singleton2() { }
    private static readonly object lockin = new object();
    private static Singleton2 instance = null;
    public static Singleton2 Instance
    {
        get
        {
            lock (lockin)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
        }
    }
}

// Thread Safe Singleton without using locks and no lazy instantiation
public sealed class Singleton4
{
    private static readonly Singleton4 instance = new Singleton4();
    static Singleton4()
    {
    }
    private Singleton4()
    {
    }
    public static Singleton4 Instance
    {
        get
        {
            return instance;
        }
    }
}