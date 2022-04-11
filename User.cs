using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    public abstract class User
    {
        public User()
        {
            //Console.WriteLine("User being creted");
        }
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public bool Verified { get; set; } = false;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string FirstName { get; }
        public string LastName { get; }
        public abstract  void HelloToConsole();
    }
}