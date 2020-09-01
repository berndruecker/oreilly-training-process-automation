# External Task Worker / NodeJS

* Download/clone the code in this folder. You might need to adjust the external topic name in the file `index.js`. In the demo code it is `celebrate`.

* Run the worker:

```
npm install
node index.js 
```

* You should see something like:

```
C:\DEV\oreilly\oreilly-training-process-automation\demo\worker-nodejs>node index.js
✓ subscribed to topic celebrate
Yeah, '' was approved and can now be ordered! Please celebrate accordingly!
✓ completed task 6cb2fab7-ec02-11ea-806a-0242ac110002
```