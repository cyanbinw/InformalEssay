using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode
{
    public abstract class BaseWork
    {
        public string Name { get; set; } = string.Empty;
        public int Size { get; set; }
        public string Work { get; set; } = string.Empty;

        public abstract void Run();
    }
}
