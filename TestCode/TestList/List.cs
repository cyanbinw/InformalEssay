using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace TestCode.TestList
{
    public class List: ITest
    {
        public void Run()
        {
            ListModel list = new ListModel();
            ListModel item = new ListModel();
            List<Data> d = new List<Data>();
            int[] n = new int[10];
            ArrayList array = new ArrayList();
            for(var i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Name = "name" + i;
                data.Size = i;
                d.Add(data);
                item.Add(data);
            }

            list.AddRange(item.Concat(d).ToList());
            list.Size = list.Count;
            foreach(var i in list)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine(list.Size);

            DifferenceSet();
        }

        public void DifferenceSet()
        {
            Console.WriteLine("----------------------------------------------");
            ListModel item1 = new ListModel();
            ListModel item2 = new ListModel();
            List<Data> data = new List<Data>();
            for (var i = 0; i < 10; i++)
            {
                Data data1 = new Data();
                Data data2 = new Data();
                data1.Name = "name" + i;
                data1.Size = i;
                data2.Name = "name" + (i+ 5);
                data2.Size = i + 5;
                item1.Add(data1);
                item2.Add(data2);
            }

            data = item1.Except(item2, new SetDifferenceSet()).ToList();
            data.AddRange(item2.Except(item1, new SetDifferenceSet()).ToList());

            foreach(var i in data)
            {
                Console.WriteLine(i.Name);
            }
        }
    }


    public class SetDifferenceSet : IEqualityComparer<Data>
    {
        public bool Equals([AllowNull] Data x, [AllowNull] Data y)
        {
            return (x.Name == y.Name) && (x.Size == y.Size);
        }

        public int GetHashCode([DisallowNull] Data obj)
        {
            return 1;
        }
    }
}
