using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCode.TestThreaded
{
    public class Threaded : BaseTest, ITest
    {
        public void Run()
        {
            //for (var i =0; i < 10; i++)
            //{             
            //    Console.WriteLine(TaskAction(i).Result);
            //}
            TaskVoid();
        }

        public async Task<string> TaskAction(int id)
        {
            string str = await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return "Task:";
            });

            str += id;
            return str;
        }

        public async void TaskVoid()
        {
            await Task.Run(() => {
                Console.WriteLine("Complete");
            });
        }
    }
}
