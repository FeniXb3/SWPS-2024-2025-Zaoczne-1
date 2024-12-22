// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zagrajmy w rock paper scissors");
Console.WriteLine("Graczu 1, podaj znak");
// typ nazwa;
// typ nazwa = wartosc;
string? firstSign = Console.ReadLine();

// pętla while:
// dopóki (warunek)
// { działanie, które ma się powtarzać tak długo, jak warunek jest prawdziwy}
while (firstSign != "rock" && firstSign != "paper" && firstSign != "scissors")
{
    Console.WriteLine("Niepoprawny znak!");
    Console.WriteLine("Graczu 1, podaj POPRAWNY znak");
    firstSign = Console.ReadLine();
}

Console.WriteLine("Graczu 2, podaj znak");
string? secondSign = Console.ReadLine();
while (secondSign != "rock" && secondSign != "paper" && secondSign != "scissors")
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
else if ((firstSign == "rock" && secondSign == "scissors") 
        || (firstSign == "paper" && secondSign == "rock") 
        || (firstSign == "scissors" && secondSign == "paper"))
{
    Console.WriteLine("G1 MISZCZ!");
}
else
{
    Console.WriteLine("G2 MISZCZ!");
}


Console.WriteLine("GG");