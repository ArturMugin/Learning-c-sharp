using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public class Teacher : User
    {
        public Teacher()
        {
            Console.WriteLine("Teacher was created");
        }
        public override void HelloToConsole()
        {
            Console.WriteLine($"Helli, I am TEACHER, my name is {FullName.ToUpper()} and I come from Teacher.cs");
        }
    }
}
