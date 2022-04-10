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

            Console.WriteLine(user);

        }

    }
}