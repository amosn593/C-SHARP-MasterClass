## Events and Delegates in C#

### Delegates
A delegate is a type that represents references to methods with a particular parameter list and return type. Delegates are used to pass methods as arguments to other methods. 

#### Using Delegates
```
1. Declare a delegate:

public delegate void MyDelegate(string message);

2. Define a method that matches the delegate signature:

public void ShowMessage(string message)
{
    Console.WriteLine(message);
}

3. Instantiate the delegate:

MyDelegate del = ShowMessage;

4. Invoke the delegate:

del("Hello, World!");


```

### Events
An event in C# is a message sent by an object to signal the occurrence of an action. Events are based on delegates and are used to provide notifications.

#### Using Events

```
1. Declare a delegate and an event:

public delegate void Notify();
public class Process
{
    public event Notify ProcessCompleted;
    
    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // Some processing logic...
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}

2. Subscribe to the event:

class Program
{
    static void Main(string[] args)
    {
        Process process = new Process();
        process.ProcessCompleted += Process_ProcessCompleted;
        process.StartProcess();
    }

    private static void Process_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
    }
}


```

### Key Points
Delegates: Type-safe method pointers, used to pass methods as arguments and define callback methods.
Events: Provide a way for a class to notify other classes or objects when something of interest occurs.
Events are based on delegates and use the event keyword to define.
Multicast Delegates: Delegates that can hold references to more than one method.
Event Handlers: Methods that are executed in response to an event.

## Microsoft Recommend EventHandler