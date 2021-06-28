using CamundaClient;
using System;

namespace OReillyTraining
{
    public class Program
    {
        public static void Main(string[] args)
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
        }    

        void JobHandler(IJobClient jobClient, IJob activatedJob)
        {
            var variables = JsonConvert.DeserializeObject<Dictionary<string, string>>(activatedJob.Variables);

            Log.LogInformation("Yeah, your request was approved and can now be ordered! Please celebrate accordingly!");

            jobClient.NewCompleteJobCommand(activatedJob).Send();
        }        
    }
}
