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
            user2.FirstName = "Arthur";
            user2.LastName = "Mugin";

            Console.WriteLine(user.Equals(user2));

        }

    }
}