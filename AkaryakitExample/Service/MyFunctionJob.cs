using Quartz;

namespace AkaryakitExample.Service
{
    public class MyFunctionJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("merhaba dunya");
           
            return Task.CompletedTask;
        }
    }
}
