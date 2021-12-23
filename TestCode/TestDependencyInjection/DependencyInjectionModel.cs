using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestDependencyInjection
{
    public interface IWrite
    {
        public void Wirte();
    }

    public abstract class Book
    {
        public string Name { get; set; }

        public virtual void Read()
        {
            Console.WriteLine(Name);
        }

        public abstract void ChangeName();
    }

    public class YellowBook : Book,IWrite
    {
        public YellowBook(string name)
        {
            this.Name = name;
        }

        public void Wirte()
        {
            Console.WriteLine(Name + "sss");
        }

        public override void Read()
        {
            base.Read();
            ChangeName();
            Console.WriteLine(this.Name);
        }

        public override void ChangeName()
        {
            this.Name = "YellowBook";
        }
    }

    public class NoYellowBook : IWrite
    {

        public void Wirte()
        {
            Console.WriteLine( "sss");
        }
    }
}
