using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestReadOnly
{
    public class ReadOnlyModle
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public ReadOnlyModle()
        {
            Year = DateTime.Now.Year;
            Name = "ReadOnly";
        }
    }

    public class ReadOnlyModleList : List<ReadOnlyModle>
    {
        public void Add()
        {
            this.Add(new ReadOnlyModle());
        }

        public ReadOnlyModleList()
        {
            this.Add(new ReadOnlyModle());
        }
    }
}
