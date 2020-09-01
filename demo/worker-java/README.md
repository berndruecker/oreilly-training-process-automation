# External Task Worker / Java

* Download/clone the code in this folder.

* You might need to adjust the external topic name in the file `Worker.cs`. In the demo code it is `celebrate`.
* If you use the managed Camunda instane you need to adjust the URL for Camunda in the file `Worker.cs`.

* Run the worker:

```
mvn package exec:java
```

* You should see something like this:

```
[INFO]
[INFO] --- maven-jar-plugin:2.4:jar (default-jar) @ oreilly-approval-demo-worker ---
[INFO] Building jar: C:\DEV\oreilly\oreilly-training-process-automation\demo\worker-java\target\oreilly-approval-demo-worker-1.0-SNAPSHOT.jar
[INFO]
[INFO] --- exec-maven-plugin:1.6.0:java (default-cli) @ oreilly-approval-demo-worker ---
SLF4J: Failed to load class "org.slf4j.impl.StaticLoggerBinder".
SLF4J: Defaulting to no-operation (NOP) logger implementation
SLF4J: See http://www.slf4j.org/codes.html#StaticLoggerBinder for further details.
Yeah, 'Book' was approved and can now be ordered! Please celebrate accordingly!
```