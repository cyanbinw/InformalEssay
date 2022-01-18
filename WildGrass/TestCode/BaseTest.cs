using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class BaseTest: ITest
    {

        public void Action()
        {
            Begin();
            Run();
            End();
        }

        protected virtual void Begin()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("----------------------- " + this.ToString() + " Begin -----------------------");
        }

        protected virtual void End()
        {
            Console.WriteLine("----------------------- " + this.ToString() + " End -----------------------");
        }

        public virtual void Run()
        {

        }
    }
}
