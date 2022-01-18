using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestNewFunction
{
    public class RunTest: ITest
    {

        public void Run()
        {
            tuple();
        }

        void tuple()
        {
            var t = new Tuple(11, 5, "Tuple");
            (int x, int y, string s) = t;
            Console.WriteLine($"x = {x}; y = {y}; s = {s}");
        }
    }
}
