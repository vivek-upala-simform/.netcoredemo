using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace netcoredemo.Service
{
    public class MathService
    {
        /// <summary>
        /// This function will perform the addition of the specified argument.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static double Division(int a,int b)
        {
            return a/b;
        }
    }
}
