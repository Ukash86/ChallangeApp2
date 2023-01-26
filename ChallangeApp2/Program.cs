using ChallengeApp2;

    Employee user1 = new Employee("Nicola ", "Tesla ", 50);
    Employee user2 = new Employee("Leonardo ", "da Vinci ", 40);
    Employee user3 = new Employee("Elon ", "Musk ", 30);
    string lat = "(lat - ";

    Console.WriteLine("Pracownik z największą liczbą punktów to:");

    string name1 = user1.Name;
    string surname = user1.Surname;
    int age = user1.Age;
    user1.AddScore(5);
    user1.AddScore(9);
    user1.AddScore(8);
    user1.AddScore(6);
    user1.AddScore(4);
    var result = user1.Result;

    string name2 = user2.Name;
    string surname2 = user2.Surname;
    int age2 = user2.Age;
    user2.AddScore(7);
    user2.AddScore(9);
    user2.AddScore(3);
    user2.AddScore(2);
    user2.AddScore(4);
    var result2 = user2.Result;

    string name3 = user3.Name;
    string surname3 = user3.Surname;
    int age3 = user3.Age;
    user3.AddScore(2);
    user3.AddScore(7);
    user3.AddScore(8);
    user3.AddScore(7);
    user3.AddScore(6);
    var result3 = user3.Result;

    if (result >= result2 & result >= result3)
    {
        Console.WriteLine(result + " pkt - " + user1.Name + user1.Surname + lat + user1.Age + ")");
    }
    else if (result2 >= result & result2 >= result3)
    {
        Console.WriteLine(result2 + " pkt - " + user2.Name + user2.Surname + lat + user2.Age + ")");
    }
    else if (result3 >= result & result3 >= result2)
    {
        Console.WriteLine(result3 + " pkt - " + user3.Name + user3.Surname + lat + user3.Age + ")");
    }