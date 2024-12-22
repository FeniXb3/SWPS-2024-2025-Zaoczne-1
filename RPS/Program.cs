                        // 0        1        2
string[] allowedSigns = ["fire", "water", "grass"];

Console.WriteLine($"Zagrajmy w {string.Join(" ", allowedSigns)}");
Console.WriteLine("Graczu 1, podaj znak");
// typ nazwa;
// typ nazwa = wartosc;
string? firstSign = Console.ReadLine();

// pętla while:
// dopóki (warunek)
// { działanie, które ma się powtarzać tak długo, jak warunek jest prawdziwy}

// czepiaj się gracza, dopóki znak, który poda nie znajduje się w tablicy allowedSigns
while (!allowedSigns.Contains(firstSign))
{
    Console.WriteLine("Niepoprawny znak!");
    Console.WriteLine("Graczu 1, podaj POPRAWNY znak");
    firstSign = Console.ReadLine();
}

Console.WriteLine("Graczu 2, podaj znak");
string? secondSign = Console.ReadLine();
while (!allowedSigns.Contains(secondSign))
{
    Console.WriteLine("Niepoprawny znak!");
    Console.WriteLine("Graczu 2, podaj POPRAWNY znak");
    secondSign = Console.ReadLine();
}

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