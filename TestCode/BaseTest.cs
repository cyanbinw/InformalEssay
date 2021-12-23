using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class BaseTest
    {
        public virtual void Begin()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------- " + this.ToString() + " Begin -----------------------");
        }

        public virtual void End()
        {
            Console.WriteLine("----------------------- " + this.ToString() + " End -----------------------");
        }
    }
}
