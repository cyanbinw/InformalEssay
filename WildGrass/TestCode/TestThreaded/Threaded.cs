using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCode.TestThreaded
{
    public class Threaded : BaseTest
    {
        public override void Run()
        {
            Console.WriteLine("start Threaded");
            Console.WriteLine("Current Process ID " + Thread.CurrentThread.ManagedThreadId);
            TaskAction1();
            
            string test2 = "Test 2";
            Task<int> value = TaskAction2(test2);
            Console.WriteLine("Test 2 Process ID " + value.Result);
            Console.WriteLine("complete Threaded");
        }

        public async void TaskAction1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Test 1 Pending...");
                Thread.Sleep(5000);
                Console.WriteLine("Test 1 Task Process ID " + Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Test 1 Complete");
            });
            Console.WriteLine("Test 1 Process ID " + Thread.CurrentThread.ManagedThreadId);
        }

        public async Task<int> TaskAction2(string item)
        {
            await Task.Run(() => {
                Console.WriteLine("Test 2 Pending...");
                Thread.Sleep(3000);
                Console.WriteLine(item);
                Console.WriteLine("Task 2 Complete");
            });
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}
