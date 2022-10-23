using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestLock
{
    public class WorkLock : BaseTest
    {
        public static ConcurrentDictionary<string, List<TestWork>> Client = new ConcurrentDictionary<string, List<TestWork>>();
        private static object _lock = new object();

        public override void Run()
        {
            for(var i = 0; i < 20; i++)
            {
                Register(i, "test" + i);
                Thread.Sleep(1000);
            }

            for(var j = 0; j < 10; j++)
            {
                Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    Update(j, "test update " + j);                 
                });
            }

            for (var z = 0; z < 10; z++)
            {
                if(z / 2 == 0)
                {
                    Task.Run(() =>
                    {
                        Thread.Sleep(2000);
                        Remove(z);
                    });
                }
            }
        }

        public void Register(int id, string name)
        {
            Client.AddOrUpdate("test", new List<TestWork>() { new TestWork(id, name) }, (key, oldValue) =>
            {
                oldValue.Add(new TestWork(id, name));
                return oldValue;
            });
        }

        public void Update(int id, string name)
        {
            List<TestWork> works;
            Client.TryGetValue("test", out works);
            lock (_lock)
            {              
               foreach(var i in works)
                {
                    if(i.Id == id)
                    {
                        i.Name = name;
                    }
                }
            }
        }

        public void Remove(int id)
        {
            List<TestWork> works;
            Client.TryGetValue("test", out works);
            lock (_lock)
            {
                var i = works.Find(x => x.Id == id);
                works.Remove(i);
            }
        }
    }
}
