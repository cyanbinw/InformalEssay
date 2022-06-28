using LearnFramework.Interface;

namespace LearnFramework.Models
{
    public class InjectionWork : IInjectionWork
    {
        private AppSettingTest appSettingTest;

        public InjectionWork(AppSettingTest appSettingTest)
        {
            this.appSettingTest = appSettingTest;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public Task Task()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
