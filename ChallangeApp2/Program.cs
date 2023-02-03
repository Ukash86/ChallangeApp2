using ChallengeApp2;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witam w programie <= BEST WORKER => oceny pracowników");
Console.WriteLine("=========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    float grade;
    if (!float.TryParse(input, out grade))
    {
        Console.WriteLine("Podana wartość nie jest oceną !!!");
        Console.WriteLine("Więc...");
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");