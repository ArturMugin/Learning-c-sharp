using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public class Student : User
    {
        public Student()
        {
            Console.WriteLine("Student was created");
        }
        public override void HelloToConsole()
        {
            Console.WriteLine($"Hi, I am a student, my name is {FullName} I come from student.cs");
        }
    }
}
