                        // 0        1        2
string[] allowedSigns = ["fire", "water", "grass"];

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

string firstSign = GetSign(1);
string secondSign = GetSign(2);

// if (instrukcja któej wynikiem będzie true lub false)
if (firstSign == secondSign)
{
    Console.WriteLine("Remis");
}
else if ((firstSign == allowedSigns[0] && secondSign == allowedSigns[2]) 
        || (firstSign == allowedSigns[1] && secondSign == allowedSigns[0]) 
        || (firstSign == allowedSigns[2] && secondSign == allowedSigns[1]))
{
    Console.WriteLine("G1 MISZCZ!");
}
else
{
    Console.WriteLine("G2 MISZCZ!");
}


Console.WriteLine("GG");


// typ_zwracanych_danych NazwaMetody(typ_danej nazwa_danej, typ_danej nazwa_kolejnej_danej)
string GetSign(int playerNumber)
{
    Console.WriteLine($"Graczu {playerNumber}, podaj znak");
    string? sign = Console.ReadLine();
    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak!");
        Console.WriteLine($"Graczu {playerNumber}, podaj POPRAWNY znak");
        sign = Console.ReadLine();
    }

    return sign;
}