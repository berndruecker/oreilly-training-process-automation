# External Task Worker / NodeJS

* Requirements:
  * NodeJS (tested with version >= 14)
  * NPM

* Download/clone the code in this folder. You might need to adjust the external topic name in the file `index.js`. In the demo code it is `celebrate`.
* You need to set your Camunda cloud client connection details in the file `index.js`. Simply replace the existing sample values.

* Run the worker:

```
npm install
node index.js 
```

* You should see something like:

```
15:18:23.122 | zeebe |  INFO: Authenticating client with Camunda Cloud...
15:19:10.883 | zeebe |  [celebrate] INFO: Yeah, your request was approved and can now be ordered! Please celebrate accordingly!
```