package io.berndruecker.oreilly.training;

import org.camunda.bpm.client.ExternalTaskClient;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;
import org.springframework.stereotype.Component;

@Component
public class DemoProcessWorkerWorker {
  
  @EventListener(ApplicationReadyEvent.class)
  public void connectWorker() {
    // bootstrap the client
    ExternalTaskClient client = ExternalTaskClient.create() //
        .baseUrl("http://localhost:8080/engine-rest") //
        .build();

    // subscribe to the topic
    client.subscribe("celebrate-solution").handler((externalTask, externalTaskService) -> {

      // retrieve a variable from the process instance
      String something = externalTask.getVariable("something");

      // Do the business logic
      System.out.println("Yeah, '"+something+"' was approved and can now be ordered! Please celebrate accordingly!");

      // complete the external task
      externalTaskService.complete(externalTask);

    }).open();
  }
  
}
