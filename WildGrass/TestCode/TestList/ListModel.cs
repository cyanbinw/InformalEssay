using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestList
{
    public class ListModel:List<Data>
    {
        public string Message { get; set; }
        public int Size { get; set; }
    }

    public class Data
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public string strData = "test";

        public int intData = 12;
    }
}
