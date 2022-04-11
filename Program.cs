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
            Student me = new Student();
            me.FirstName = "Arthur";

            Teacher you = new Teacher();
            you.FirstName = "Caleb";

            User generalUser = new User();
            generalUser.FirstName = "General user";

            List<User> user = new List<User>() { me, you, generalUser};

            foreach (User u in user)
            {
                u.HelloToConsole();
            }


        }

    }
}