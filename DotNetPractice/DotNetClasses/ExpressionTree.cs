using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    internal class ExpressionTree
    {
        public static void Main1(string[] args)
        {
            Func<string,string,string> stringJoins = (str1,str2) => string.Concat(str1,str2);

            Expression<Func<string, string, string>> stringJoinsExpression = (str1, str2) => string.Concat(str1, str2);

            var func = stringJoinsExpression.Compile();
            var result = func("Hello ", "Dharmanshu");
            Console.WriteLine(result);  

            result = stringJoinsExpression.Compile()("Hello ", "Dharmanshu Soni");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
