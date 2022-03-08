using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestRedis
{
    public class RedisWork : BaseTest
    {
        public override void Run()
        {
            login();
        }

        public static ServiceStack.Redis.RedisClient client = new ServiceStack.Redis.RedisClient("10.71.9.1", 6379);

        public void login()
        {
            //存储
            client.Set<string>("name", "name");
            client.Set<string>("password", "password");

            //读取
            string name = client.Get<string>("name");
            string pwd = client.Get<string>("password");

            Console.WriteLine("name: " + name + " password: " + pwd);
        }
    }
}
