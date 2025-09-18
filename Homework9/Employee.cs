using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    internal class Employee
    {
        public static string Name { get; }
        public static string Surname { get; }
        public static int Age { get; }

        public enum Position
        {
            Manager,
            Developer,
            Tester
        }


    }
}
