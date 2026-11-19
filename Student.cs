using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC02C50
{
    internal class Student
    {
        public string Name;
        public int Age;

        public override string ToString()
        {
            return $"Name : {Name} , Age : {Age}";
        }
    }
}
