using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Practice
{
    public class MemoryCaching
    {
        static void Main1(string[] args)
        {
            ObjectCache cache = MemoryCache.Default;
            List<string> list = cache["list"] as List<string>;

            if (list == null)
            {
                list = new List<string>();
                list.Add("Apple");
                list.Add("Banana");
                list.Add("Carrot");
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10.0);
                cache.Set("list", list, policy);
            }

            var fruits = cache.Get("list") as List<string>;
            printFruit(fruits,0);

            var first_timer = new System.Timers.Timer(5000);
            first_timer.Elapsed += OnTimedEvent;
            first_timer.AutoReset = false;
            first_timer.Enabled = true;

            var secound_timer = new System.Timers.Timer(10000);
            secound_timer.Elapsed += OnTimedEvent;
            secound_timer.AutoReset = false;
            secound_timer.Enabled = true;

            Console.ReadLine();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ObjectCache cache = MemoryCache.Default;
            var fruits = cache.Get("list") as List<string>;
            printFruit(fruits,5);
        }

        private static void printFruit(List<string> fruits, int Delay)
        {
            Console.WriteLine($"-- Fruit List after {Delay} Sec ---");
            if (fruits != null)
            {
                foreach (var item in fruits)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No Fruits Found");
            }
            
        }

        private static async void CallMethodAfter10Seconds()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            // Call your method here
        }
    }
}
