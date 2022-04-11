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

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override void HelloToConsole()
        {
            Console.WriteLine($"Hi, I am a student, my name is {FullName} I come from student.cs");
        }
    }
}
