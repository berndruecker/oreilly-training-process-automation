# Training "Process Automation in Modern Architectures"


## Lab 1: Execute Your First BPMN Process

You have three options to do this lab, depending on your level of interest:

1. Install Camunda locally: This needs either Docker or a Java runtime locally. Do this if you program regularly and love to fully understand what you are doing. This setup makes it easy to play around with the environment afterwards.
2. Leverage a managed Camunda instance: This will only require you to code in Java, NodeJS or C# in a later step. Do this if you want to get your hands dirty at least a bit, but rely on a prepared environment to keep things simple.
3. Watch the recording: If you want to skip doing something yourself, you can watch a simple walk through 


### Use Local Camunda Installation

#### Camunda Run

The easiest start to use Camunda is the so called "Camunda Run" distribution. This starts Camunda as an own component and allows you to connect to it via HTTP. You will learn more about architecture options in the training.

Please follow the Installation Guide in https://docs.camunda.org/manual/latest/user-guide/camunda-bpm-run/#starting-with-camunda-bpm-run. This also explains how to run it via docker, which is actually the easiest option:

```
docker run -d -p 8080:8080 camunda/camunda-bpm-platform:run-latest
```

If you have enterprise credentials (e.g. a trial) for Camunda, you can also run the enterprise edition:

```
docker login registry.camunda.cloud
docker run -d -p 8080:8080 registry.camunda.cloud/cambpm-ee/camunda-bpm-platform-ee:run-7.13.4
```

#### Camunda Modeler

Download the Camunda Modeler: https://camunda.com/download/modeler/. Follow the instructions there, basically you just have to unzip and start the exectuable.

####

Now, model your first BPMN process using the Camunda Modeler.

TODO: Add hints on what to enter where

Deploy the model to your local Camunda Run instance listening on port 8080:


Run an instance from the modeler:

Go to Camunda Cockpit via http://localhost:8080/camunda/app/cockpit/ (User: demo, Password: demo) and inspect the process instance
Go to Camunda Tasklist via http://localhost:8080/camunda/app/tasklist/ (User: demo, Password: demo), add a simple filter, open the task, claim it and complete the task
Start a new process instance via tasklist


### Managed Camunda

* Details of hosted instance
* Camunda Modeler
* Model, Deploy and Run an Instance of your first process
* Inspect in Cockpit

### Recording



## Lab 2: Implement a Service Task

You have options:

1. Java Worker
2. NodeJS Worker
3. C# Worker
4. Plain REST
