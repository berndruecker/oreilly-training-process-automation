using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using NLog.Extensions.Logging;
using Zeebe.Client;
using Zeebe.Client.Api.Responses;
using Zeebe.Client.Api.Worker;
using Zeebe.Client.Impl.Builder;
using Newtonsoft.Json;

namespace OReillyTraining
{
    public class Program
    {
        static void Main(string[] _)
        {
            IZeebeClient client = CamundaCloudClientBuilder.Builder()
                .UseClientId("Yx6Q63H1Nx~tztL-tGo~tAqJfzLI6pkx")
                .UseClientSecret("Qj0cv6CYTc5lmYLIlsbv7XhvPMLU--jJbf~loZywSf3UFeULrGoqtV.0-mj85q2R")
                .UseContactPoint("9cfc0e64-b2f5-47ee-af0d-64c24341f4b7.zeebe.camunda.io:443")
                .Build();                
            
            client.NewWorker()
                .JobType("celebrate")
                .Handler(JobHandler)
                .MaxJobsActive(3)
                .Timeout(TimeSpan.FromSeconds(10))
                .PollInterval(TimeSpan.FromMinutes(1))
                .PollingTimeout(TimeSpan.FromSeconds(30))
                .Name("CSharpWorker")
                .Open();

            Console.Write("Type any key to stop");
            Console.ReadLine();
        }    

        static void JobHandler(IJobClient jobClient, IJob activatedJob)
        {
            Console.WriteLine("Yeah, your request was approved and can now be ordered! Please celebrate accordingly!");
            jobClient.NewCompleteJobCommand(activatedJob).Send();
        }        
    }
}
