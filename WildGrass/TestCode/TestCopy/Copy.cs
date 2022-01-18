using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TestCode.TestCopy
{
    public class Copy: BaseTest
    {
        public CopyModel Copy1 { get; set; }
        public CopyModel Copy2 { get; set; }

        public override void Run()
        {
            Copy1 = new CopyModel();
            Copy1.Name = "Data";
            Copy1.Size = 77;
            Copy1.Address = "D:/";
            Copy1.Str = new List<string>() { "sss" };
            Copy2 = ObjectDeepCopy<CopyModel>(Copy1);
            Print();

            HashCode();
        }

        public void Print()
        {
            Copy1.Name = "Copy";
            Copy1.Str[0] = "ddd";

            Console.WriteLine("Name = " + Copy1.Name + " Size = " + Copy1.Size + " Address = " + Copy1.Address + "Str = " + Copy1.Str[0]);
            Console.WriteLine("Name = " + Copy2.Name + " Size = " + Copy2.Size + " Address = " + Copy2.Address + "Str = " + Copy2.Str[0]);
        }

        public void HashCode()
        {
            CopyModel copy1 = new CopyModel();
            copy1.Name = "Data";
            copy1.Size = 77;
            copy1.Address = "D:/";

            CopyModel copy2 = new CopyModel();
            copy2.Name = "Data";
            copy2.Size = 77;
            copy2.Address = "D:/";


            Console.WriteLine(copy1.GetHashCode() + " - " + copy2.GetHashCode());
        }

        //对象里的List 无法深拷贝
        public T ObjectDeepCopy<T>(T inM)
        {
            Type t = inM.GetType();
            T outM = (T)Activator.CreateInstance(t);
            foreach (PropertyInfo p in t.GetProperties())
            {
                t.GetProperty(p.Name).SetValue(outM, p.GetValue(inM));
            }
            return outM;
        }
    }
}
