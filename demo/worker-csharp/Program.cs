using CamundaClient;
using System;

namespace OReillyTraining
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CamundaEngineClient Camunda = new CamundaEngineClient(
                new Uri("http://localhost:8080/engine-rest/engine/default/"), 
                "demo", 
                "demo");
            Camunda.Startup(); // Deploys all models to Camunda and Start all found ExternalTask-Workers
            Console.ReadLine(); // wait for ANY KEY
            Camunda.Shutdown(); // Stop Task Workers
        }    
    }
}
