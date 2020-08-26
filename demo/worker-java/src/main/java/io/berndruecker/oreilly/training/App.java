package io.berndruecker.oreilly.training;

import org.camunda.bpm.client.ExternalTaskClient;


public class App {
  
  public static void main(String[] args) {
    // bootstrap the client
    ExternalTaskClient client = ExternalTaskClient.create().baseUrl("http://localhost:8080/engine-rest").build();

    // subscribe to the topic
    client.subscribe("celebrate").handler((externalTask, externalTaskService) -> {

      // retrieve a variable from the process instance
      String something = externalTask.getVariable("something");

      // Do the business logic
      System.out.println("Yeah, '"+something+"' was approved and can now be ordered! Please celebrate accordingly!");

      // complete the external task
      externalTaskService.complete(externalTask);

    }).open();
  }
  
}
