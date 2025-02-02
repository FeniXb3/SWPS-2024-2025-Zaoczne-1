//                         0        1        2
string[] allowedSigns = ["fire", "water", "grass"];
int expectedPoints = 3;
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

while (firstPlayerPoints < expectedPoints && secondPlayerPoints < expectedPoints)
{
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
        // poniższe trzy linijki robią to samo
        // to,z której skorzystasz zależy od konktekstu i tego,co chcesz osiągnąć
        // firstPlayerPoints = firstPlayerPoints - 1;
        firstPlayerPoints += 1;
        // firstPlayerPoints++;
    }
    else
    {
        Console.WriteLine("G2 MISZCZ!");
        secondPlayerPoints += 1;
    }

    Console.WriteLine($"G1: {firstPlayerPoints} - G2: {secondPlayerPoints}");
}
Console.WriteLine("GG");


// typ_zwracanych_danych NazwaMetody(typ_danej nazwa_danej, typ_danej nazwa_kolejnej_danej)
string GetSign(int playerNumber)
{
    Console.WriteLine($"Graczu {playerNumber}, podaj znak");
    string sign = Console.ReadLine() ?? string.Empty;
    sign = sign.ToLower();
    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak!");
        Console.WriteLine($"Graczu {playerNumber}, podaj POPRAWNY znak");
        sign = Console.ReadLine() ?? string.Empty;
    }

    return sign;
}