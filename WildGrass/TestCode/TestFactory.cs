using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCode.TestLock;
using TestCode.TestReadOnly;
using TestCode;
using TestCode.TestCopy;
using TestCode.TestAbstract;
using TestCode.TestList;
using TestCode.TestDependencyInjection;
using TestCode.TestNewFunction;
using TestCode.TestThreaded;
using TestCode.TestDelegation;
using TestCode.TestProperty;
using TestCode.TestRedis;
using TestCode.TestTreeNode;

namespace TestCode
{
    public class TestFactory
    {
        public Dictionary<TestType, Func<BaseTest>> Factory { get; private set; }

        public TestFactory() 
        {
            Factory = new Dictionary<TestType, Func<BaseTest>>();
            Factory[TestType.Copy] = () => { return new Copy(); };
            Factory[TestType.DataWork] = () => { return new DataWork(); };
            Factory[TestType.WorkList] = () => { return new WorkList(); };
            Factory[TestType.DependencyInjection] = () => { return new DependencyInjection(); };
            Factory[TestType.RunTest] = () => { return new RunTest(); };
            Factory[TestType.Threaded] = () => { return new Threaded(); };
            Factory[TestType.DelegateWork] = () => { return new DelegateWork(); };
            Factory[TestType.PropertyWork] = () => { return new PropertyWork(); };
            Factory[TestType.RedisWork] = () => { return new RedisWork(); };
            Factory[TestType.TreeNodeWork] = () => { return new TreeNodeWork(); };
            Factory[TestType.WorkLock] = () => { return new WorkLock(); };
            Factory[TestType.ReadOnlyWork] = () => { return new ReadOnlyWork(); };
        }

        public bool Add(TestType key, Func<BaseTest> value)
        {
            return Factory.TryAdd(key, value);
        }
    }

    public enum TestType
    {
        BaseTest,
        DataWork,
        Copy,
        WorkList,
        DependencyInjection,
        RunTest,
        Threaded,
        DelegateWork,
        PropertyWork,
        MongoWork,
        RedisWork,
        TreeNodeWork,
        WorkLock,
        ReadOnlyWork
    }
}
