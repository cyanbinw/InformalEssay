using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode
{
    public abstract class BaseWork
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Work { get; set; }

        public abstract void Run();
    }
}
