using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestDependencyInjection
{
    public class DependencyInjection : BaseTest
    {
        public IContainer Container { get; set; }

        public override void Run()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<NoYellowBook>().As<IWrite>();
            builder.RegisterType<YellowBook>().As<Book>();
            Container = builder.Build();

            Test();
        }

        public void Test()
        {
            IWrite write = Container.Resolve<IWrite>();
            var read = Container.Resolve<Book>(new NamedParameter("name", "noYellow"));
            
            write.Wirte();
            read.Name = "ppp";
            read.Read();
            
        }

        public void Date()
        {
            var date = DateTime.Now;
            Console.WriteLine(date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

            Console.WriteLine("----------------------------------------------");
        }
    }
}
