
/// <summary>
/// 1.Single Responsibility Principle(SRP)
///Principle: A class should have only one reason to change, meaning it should have only one job or responsibility.
/// </summary>
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

