using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestProperty
{
    public class PropertyWork : ITest
    {
        public void Run()
        {
            PropertyModel model = new PropertyModel();
            string str = model.PropertyStr;
            str = "I have changed";            
            string read = model.ReadOnly ;
            read = "I have changed ReadOnly";
            model.Run();
        }
    }

    public class PropertyModel : BaseWork
    {
        public string PropertyStr { get; private set; }

        public readonly string ReadOnly = "I am ReadOnly";

        public PropertyModel()
        {
            this.PropertyStr = "Test";
            Console.WriteLine(this.PropertyStr);
        }

        public override void Run()
        {
            Console.WriteLine(PropertyStr);
            Console.WriteLine(ReadOnly);
        }
    }
}
