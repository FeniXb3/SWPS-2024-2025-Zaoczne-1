string firstAllowedSign = "rock";
string secondAllowedSign = "paper";
string thirdAllowedSign = "scissors";

Console.WriteLine("Zagrajmy w rock paper scissors");
Console.WriteLine("Graczu 1, podaj znak");
// typ nazwa;
// typ nazwa = wartosc;
string? firstSign = Console.ReadLine();

// pętla while:
// dopóki (warunek)
// { działanie, które ma się powtarzać tak długo, jak warunek jest prawdziwy}
while (firstSign != firstAllowedSign && firstSign != secondAllowedSign && firstSign != thirdAllowedSign)
{
    Console.WriteLine("Niepoprawny znak!");
    Console.WriteLine("Graczu 1, podaj POPRAWNY znak");
    firstSign = Console.ReadLine();
}

Console.WriteLine("Graczu 2, podaj znak");
string? secondSign = Console.ReadLine();
while (secondSign != firstAllowedSign && secondSign != secondAllowedSign && secondSign != thirdAllowedSign)
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
else if ((firstSign == firstAllowedSign && secondSign == thirdAllowedSign) 
        || (firstSign == secondAllowedSign && secondSign == firstAllowedSign) 
        || (firstSign == thirdAllowedSign && secondSign == secondAllowedSign))
{
    Console.WriteLine("G1 MISZCZ!");
}
else
{
    Console.WriteLine("G2 MISZCZ!");
}


Console.WriteLine("GG");