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
                return FirstName + " " + LastName; 
            }

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public override bool Equals(object obj)
        {
            if(FullName == ((User)obj).FullName)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public static void PrintUsers(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString);
            }
        }

        public static void PrintUser(User user)
        {
            Console.Write("Static method. Print user");
            Console.WriteLine(user);
        }

        public static int Find(List<User> users, string fullName)
        {
            for (int i = 0; i < users.Count; i++)
            {

                    if (users[i].FullName == fullName)
                    {
                        //return the index of the user
                        return i;
                    }
                
            }
            return -300;

        }

        public static int Find(List<User> users, User user)
        {
            for (int i = 0; i < users.Count; i++)
            {

                if (users[i].Equals(user))
                {
                    return i;
                }

            }
            return -300;
        }

    }
}
