using System;
using training;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.doSometing();

        }

        public void doSometing()
        {
            User user = new User();
            user.FirstName = "Arthur";
            user.LastName = "Mugin";
            //User.PrintUser(user);

            User user2 = new User();
            user2.FirstName = "Bob";


            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user2);

            User.PrintUsers(users);

        }

    }
}