using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    internal class Student : User
    {
        public override void HelloToConsole()
        {
            Console.WriteLine("Hi, I am a student, I come from student.cs");
        }
    }
}
