using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestNewFunction
{
    public class Tuple
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string S { get; set; }

        public Tuple(int x, int y, string s) => (X, Y, S) = (x, y, s);

        public void Deconstruct(out int x, out int y, out string s) => (x, y, s) = (X, Y, S);
    }
}
