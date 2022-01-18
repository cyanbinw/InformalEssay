using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestDelegation
{
    public delegate void Work();
    public delegate int ActionWork(int i, int y);
    public class DelegateWork : BaseTest
    {
        public override void Run()
        {
            Action();
        }

        void Action()
        {
            Work work = Test1;
            work += Test2;
            work.Invoke();

            ActionWork actionWork = TestAction1;
            actionWork += TestAction2;

            actionWork.Invoke(2, 1);

            Ticket(3, 7);
        }

        void Test1()
        {
            Console.WriteLine("I am Test1");
        }

        void Test2()
        {
            Console.WriteLine("I am Test2");
        }

        int TestAction1(int i, int y)
        {
            Console.WriteLine("I am TestAction1");
            return i + y;
        }

        int TestAction2(int i, int y)
        {
            Console.WriteLine("I am TestAction2");
            return i - y;
        }

        Action<int, int> Ticket = (i, y) =>
        {
            Console.WriteLine(i + y);
        };

        Func<string, string> Func = str => str;
    }
}
