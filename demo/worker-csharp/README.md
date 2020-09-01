# External Task Worker / C#  Dotnet Core

* Download/clone the code in this folder. You might need to adjust the external topic name in the file `Worker.cs`. In the demo code it is `celebrate`.

* Run the worker:

```
dotnet build
dotnet run
```

* You should see something like:

```
C:\DEV\oreilly\oreilly-training-process-automation\demo\worker-csharp>dotnet run
Register Task Worker for Topic 'celebrate'
Execute External Task from topic 'celebrate': ExternalTask [Id=81e51da4-ec01-11ea-806a-0242ac110002, ActivityId=Task_Celebrate]...

Celebrating!

...finished External Task 81e51da4-ec01-11ea-806a-0242ac110002
```
