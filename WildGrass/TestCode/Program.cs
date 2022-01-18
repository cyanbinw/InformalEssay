// See https://aka.ms/new-console-template for more information

using TestCode;
using TestCode.TestAbstract;
using TestCode.TestCopy;
using TestCode.TestDelegation;
using TestCode.TestDependencyInjection;
using TestCode.TestList;
using TestCode.TestNewFunction;
using TestCode.TestProperty;
using TestCode.TestThreaded;

test();
Console.WriteLine("------------------Test Complete---------------");
Console.ReadKey();

static void test()
{
    ITest data = new DataWork();
    data.Run();

    ITest dataAbstract = new DataWork();
    dataAbstract.Run();

    Console.WriteLine("----------------------------------------------");

    ITest copy = new Copy();
    copy.Run();

    Console.WriteLine("----------------------------------------------");

    ITest list = new List();
    list.Run();

    Console.WriteLine("----------------------------------------------");

    ITest dependency = new DependencyInjection();
    dependency.Run();

    Console.WriteLine("----------------------------------------------");

    var date = DateTime.Now;
    Console.WriteLine(date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));

    Console.WriteLine("----------------------------------------------");

    ITest run = new RunTest();
    run.Run();

    Console.WriteLine("----------------------------------------------");

    ITest threaded = new Threaded();
    threaded.Run();

    Console.WriteLine("----------------------------------------------");

    ITest delegates = new DelegateWork();
    delegates.Run();

    Console.WriteLine("----------------------------------------------");

    ITest property = new PropertyWork();
    property.Run();
}
