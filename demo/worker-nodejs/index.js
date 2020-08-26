const {
  Client,
  logger,
  Variables
} = require("camunda-external-task-client-js");

// configuration for the Client:
//  - 'baseUrl': url to the Workflow Engine
//  - 'logger': utility to automatically log important events
const config = {
  baseUrl: "http://localhost:8080/engine-rest",
  use: logger
};

// create a Client instance with custom configuration
const client = new Client(config);

// create a handler for the task
const handler = async ({ task, taskService }) => {
  // get task variable 'defaultScore'
  const something = task.variables.get("something");

  // do the business logic
  console.log("Yeah, '" + something + "' was approved and can now be ordered! Please celebrate accordingly!");

  // complete the task
  try {
    await taskService.complete(task);
  } catch (e) {
    console.error(`Failed completing service task, ${e}`);
  }
};

client.subscribe("celebrate", handler);