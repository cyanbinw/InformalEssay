using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestReadOnly
{
    public class ReadOnlyWork : BaseTest
    {
        private readonly ReadOnlyModle readOnlyModle;

        private readonly ReadOnlyModleList readOnlyModleList;

        public ReadOnlyWork()
        {
            readOnlyModle = new ReadOnlyModle();
            readOnlyModleList = new ReadOnlyModleList();
        }

        public override void Run()
        {
            Console.WriteLine(readOnlyModle.Year + " " + readOnlyModle.Name + " " + readOnlyModleList.Count);
            readOnlyModle.Name = "Test";
            readOnlyModleList.Add(readOnlyModle);
            Console.WriteLine(readOnlyModle.Year + " " + readOnlyModle.Name + " " + readOnlyModleList.Count);
        }
    }
}
