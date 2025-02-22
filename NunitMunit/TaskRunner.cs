using System;
using System.Threading;

public class TaskRunner
{
    public void LongRunningTask()
    {
        Thread.Sleep(3000); // Simulates a 3-second task
    }
}


