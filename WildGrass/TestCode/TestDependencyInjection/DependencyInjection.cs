using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCode.TestDependencyInjection
{
    public class DependencyInjection:ITest
    {
        public IContainer Container { get; set; }

        public void Run()
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
    }
}
