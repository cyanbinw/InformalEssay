using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestAbstract
{
    public abstract class DataAbstract : BaseTest
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public string strData = "test";

        public int intData = 12;

    }
}
