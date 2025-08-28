﻿Fight();



static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 130;

    string p1Name = "Alex";
    string p2Name = "Calin";

    while (p1Hp > 0 || p2Hp > 0)
    {

        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        p2Hp -= Random.Shared.Next(10, 40); // Alex slår Calin
        p1Hp -= Random.Shared.Next(10, 25); // Calin slår Alex

    }
    Console.ReadLine();

    if (p1Hp > 0)
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine("Oavgjort!");
        Console.WriteLine($"{p1Name} Du fick 100xp!");
    }
    else
    {
        Console.WriteLine($"{p2Name} vann!");
        Console.WriteLine($"{p2Name} Du fick 100xp!");
    }

}
Console.ReadLine();