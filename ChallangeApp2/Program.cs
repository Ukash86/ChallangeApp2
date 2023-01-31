using ChallengeApp2;

var employee = new Employee("Donald", "Trump");
employee.AddGrade("y");
employee.AddGrade(20.5);
employee.AddGrade("6");
employee.AddGrade('1');
employee.AddGrade('t');
employee.AddGrade(110);
var statistics = employee.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");