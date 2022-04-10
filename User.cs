using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    internal class User
    {
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; 
            }

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Output(int times)
        {
            string message = "";
            for (int i = 0; i < times; i++){ 
                message += $"{FullName}\n";
            }

            return message;
        }

        public static void PrintUsers(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.Output(1));
            }
        }

        public static void PrintUser(User user)
        {
            Console.Write("Static method. Print user");
            Console.WriteLine(user.Output(1));
        }

    }
}
