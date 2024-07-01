## SOLID Principles

1. Single Responsibility Principle (SRP)
A class should have only one reason to change, meaning it should have only one job or responsibility.

```
public class ReportGenerator
{
    public string GenerateReport()
    {
        // Code to generate report
        return "Report content";
    }
}

public class ReportPrinter
{
    public void PrintReport(string report)
    {
        // Code to print report
        Console.WriteLine(report);
    }
}

```
2. Open/Closed Principle (OCP)
Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
```
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double Area()
    {
        return _width * _height;
    }
}

```

3. Liskov Substitution Principle (LSP)
Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
```
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override double Area()
    {
        return _width * _height;
    }
}

```
In this example, Ostrich violates the LSP because it cannot fly, which is expected behavior of Bird. To adhere to LSP, the design needs to be reconsidered.

4. Interface Segregation Principle (ISP)
No client should be forced to depend on methods it does not use.
```
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }
}

public class SimplePrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

```

5. Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.

```
public interface IMessageSender
{
    void SendMessage(string message);
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

public class Notification
{
    private readonly IMessageSender _messageSender;

    public Notification(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Send(string message)
    {
        _messageSender.SendMessage(message);
    }
}

// Usage
var emailSender = new EmailSender();
var notification = new Notification(emailSender);
notification.Send("Hello, DIP!");

```

