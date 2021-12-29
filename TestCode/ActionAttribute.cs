using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple=true,Inherited=false)]
    public class ActionAttribute : Attribute
    {
        public ActionAttribute(string name)
        {
            Console.WriteLine("----------------------- " + this.ToString() + " Begin -----------------------");
        }
    }
}
