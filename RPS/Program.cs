//                         0        1        2
string[] allowedSigns = ["fire", "water", "grass"];

string GetLowercaseInput()
{
    return Console.ReadLine()?.ToLower() ?? string.Empty;
}

Console.WriteLine("Graczu 1, jak masz na imię?");
string? firstPlayerName = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(firstPlayerName))
{
    firstPlayerName = "Seba";
    Console.WriteLine($"Jak nie chcesz powiedzieć, jak się nazywasz, to nazwę Cię {firstPlayerName}");
}

Console.WriteLine("Graczu 2, jak masz na imię?");
string? secondPlayerName = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(secondPlayerName))
{
    secondPlayerName = "Dżesika";
    Console.WriteLine($"Jak nie chcesz powiedzieć, jak się nazywasz, to nazwę Cię {secondPlayerName}");
}

Console.WriteLine("Do ilu punktów chcecie grać?");
int defaultExpectedPoints = 3;
if (!int.TryParse(Console.ReadLine(), out int expectedPoints))
{
    expectedPoints = defaultExpectedPoints;
    Console.WriteLine($"Niepoprawna wartość! Ustawiamy oczekiwaną liczbę punktów na {expectedPoints}");
}
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");

while (firstPlayerPoints < expectedPoints && secondPlayerPoints < expectedPoints)
{
    string firstSign = GetSign(firstPlayerName);
    string secondSign = GetSign(secondPlayerName);

    // if (instrukcja któej wynikiem będzie true lub false)
    if (firstSign == secondSign)
    {
        Console.WriteLine("Remis");
    }
    else if ((firstSign == allowedSigns[0] && secondSign == allowedSigns[2])
            || (firstSign == allowedSigns[1] && secondSign == allowedSigns[0])
            || (firstSign == allowedSigns[2] && secondSign == allowedSigns[1]))
    {
        Console.WriteLine($"{firstPlayerName} MISZCZ!");
        // poniższe trzy linijki robią to samo
        // to,z której skorzystasz zależy od konktekstu i tego,co chcesz osiągnąć
        // firstPlayerPoints = firstPlayerPoints - 1;
        firstPlayerPoints += 1;
        // firstPlayerPoints++;
    }
    else
    {
        Console.WriteLine($"{secondPlayerName} MISZCZ!");
        secondPlayerPoints += 1;
    }

    Console.WriteLine($"{firstPlayerName}: {firstPlayerPoints} - {secondPlayerName}: {secondPlayerPoints}");
}
Console.WriteLine("GG");


// typ_zwracanych_danych NazwaMetody(typ_danej nazwa_danej, typ_danej nazwa_kolejnej_danej)
string GetSign(string playerName)
{
    Console.WriteLine($"{playerName}, podaj znak");
    string sign = GetLowercaseInput();
    while (!allowedSigns.Contains(sign))
    {
        Console.WriteLine("Niepoprawny znak!");
        Console.WriteLine($"{playerName}, podaj POPRAWNY znak");
        sign = GetLowercaseInput();
    }

    return sign;
}