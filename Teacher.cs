using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    internal class Teacher : User
    {
        public override void HelloToConsole()
        {
            Console.WriteLine($"Helli, I am TEACHER, my name is {FullName.ToUpper()} and I come from Teacher.cs");
        }
    }
}
