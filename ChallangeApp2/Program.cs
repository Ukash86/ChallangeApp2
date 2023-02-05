using ChallengeApp2;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

Console.WriteLine("Witam w programie <= BEST WORKER => oceny pracowników");
Console.WriteLine("=========================================");
Console.WriteLine("A - pracownik z bonusem (szansa na awans)");
Console.WriteLine("B - dobry pracownik");
Console.WriteLine("C - przecietny pracownik");
Console.WriteLine("D - pracownik do poprawy");
Console.WriteLine("E - pracownik do zwolnienia");
Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine();
var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    float grade;
    if (input == "a" || input == "b" || input == "c" || input == "d" || input == "e"
        || input == "A" || input == "B" || input == "C" || input == "D" || input == "E") ;
    else if (!float.TryParse(input, out grade))
    {
        Console.WriteLine("Podana wartość nie jest oceną !!!");
        Console.WriteLine("Więc...");
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: { e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Ilość prawidłowych otrzymanych ocen przez pracownika to:  {statistics.QuantityGrades}");
Console.WriteLine();
Console.WriteLine($"Average:      {statistics.Average}");
Console.WriteLine($"Min:          {statistics.Min}");
Console.WriteLine($"Max:          {statistics.Max}");
Console.WriteLine();
Console.WriteLine($"Klasyfikacja  => {statistics.AverageLetter} <=");