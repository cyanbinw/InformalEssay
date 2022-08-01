using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestLock
{
    public class TestWork
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TestWork(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
