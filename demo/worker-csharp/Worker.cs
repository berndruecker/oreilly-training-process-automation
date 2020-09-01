using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;

namespace OReillyTraining
{
    
    [ExternalTaskTopic("celebrate")]
    [ExternalTaskVariableRequirements("something")]
    class CelebrateAdapter : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine();
            Console.WriteLine("Celebrating!");
            Console.WriteLine();
        }

    }
}
