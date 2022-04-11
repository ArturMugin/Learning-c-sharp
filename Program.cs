using System;
using training;

namespace training
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
            Student me = new Student("Arthur", "Mugin");
            me.HelloToConsole();

            iTalk you = new Student("first", "last");

        }

    }
}