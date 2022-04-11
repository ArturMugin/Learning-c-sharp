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
            me.Verified = true;
            me.HelloToConsole();
        }

    }
}