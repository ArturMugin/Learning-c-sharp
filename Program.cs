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
            user2.FirstName = "Vova";


            User user3 = new User();
            user3.LastName = "Barduk";


            List<User> users = new List<User>()
            {
                user, user2, user3
            };
            Console.Write(User.Find(users, "Vova "));

        }

    }
}