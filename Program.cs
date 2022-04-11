using System;
using training;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.DoSometing();

        }

        public void DoSometing()
        {
            User user = new User();
            user.FirstName = "Arthur";
            user.LastName = "Mugin";


            User user2 = new User();
            user2.FirstName = "Bob";
            user2.LastName = "Marley";

            List<User> users = new List<User>()
            {
                user, user2
            };
            //declare the usre that I am searching
            User search = new User();
            search.FirstName = "Bob";
            search.LastName = "Marley";

            Console.Write(User.Find(users, search));

        }

    }
}