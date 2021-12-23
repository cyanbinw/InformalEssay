using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestGeneric
{
    public class Generic : ITest
    {
        public void Run()
        {
            var i = new GenericWork();
            TestGeneric(i);
        }

        void TestGeneric<T>(T item)  where T : BaseWork
        {
            item.Run();
        }
    }

    public class GenericWork : BaseWork
    {
        public override void Run()
        {
            Console.WriteLine("name is :" + this.Name);
        }

    }
}
