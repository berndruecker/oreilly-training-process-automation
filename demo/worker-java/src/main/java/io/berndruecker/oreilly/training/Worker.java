package io.berndruecker.oreilly.training;


import io.camunda.zeebe.client.api.response.ActivatedJob;
import io.camunda.zeebe.client.api.worker.JobClient;
import io.camunda.zeebe.spring.client.EnableZeebeClient;
import io.camunda.zeebe.spring.client.annotation.ZeebeWorker;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
@EnableZeebeClient
public class Worker {

  public static void main(String[] args) {
        SpringApplication.run(Worker.class, args);
    }

  @ZeebeWorker(type = "celebrate")
  public void celebrate(final JobClient client, final ActivatedJob job) {

      // retrieve a variable from the process instance
      Object approved = job.getVariablesAsMap().get("approved");

      // Do the business logic
      System.out.println("Yeah, your request was "+approved+" and can now be ordered! Please celebrate accordingly!");

      // complete the external task
      client.newCompleteCommand(job.getKey()).send()
              .exceptionally((throwable -> {throw new RuntimeException("Could not complete job", throwable);}));
  }

}
