using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    internal class User
    {
        public bool Verified { get; set; } = false;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName; 
            }

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void HelloToConsole()
        {
            Console.WriteLine($"Hi im {FullName}");
        }

    }
}
