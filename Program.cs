string frase = "Responda com Sim ou Não.\n";
string erro = "Na próxima responda com Sim ou Não.\n";
string deveria = "Deveria?\n";
string otimo = "Ótimo.\n";
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
}
Console.ForegroundColor = ConsoleColor.White;

frase = "Está se movendo?\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
}
Console.ForegroundColor = ConsoleColor.Cyan;
string resposta = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.Blue;
if (resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
for (int i = 0; i < deveria.Length; i++)
{
Console.Write(deveria[i]);
    Thread.Sleep(75);
} 
Console.ForegroundColor = ConsoleColor.Cyan;
resposta = Console.ReadLine()!;
if (resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < otimo.Length; i++)
{
Console.Write(otimo[i]);
    Thread.Sleep(75);
} 
}
else if (resposta.Trim().Substring(0,1).ToUpper().Contains("N"))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
frase = "Utilize Silver Tape.\n";
    for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
} 
}
else if (!resposta.Trim().Substring(0,1).ToUpper().Contains("N") || resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 0; i < erro.Length; i++)
{
Console.Write(erro[i]);
    Thread.Sleep(75);
} 
}
}
else if (resposta.Trim().Substring(0,1).ToUpper().Contains("N"))
{
for (int i = 0; i < deveria.Length; i++)
{
Console.Write(deveria[i]);
    Thread.Sleep(75);
} 
Console.ForegroundColor = ConsoleColor.Cyan;
resposta = Console.ReadLine()!;
if (resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
        Console.ForegroundColor = ConsoleColor.Yellow;
frase = "Utilize WD-40.\n";
    for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
} 
}
else if (resposta.Trim().Substring(0,1).ToUpper().Contains("N"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < otimo.Length; i++)
{
Console.Write(otimo[i]);
    Thread.Sleep(75);
} 
}
else if (!resposta.Trim().Substring(0,1).ToUpper().Contains("N") || resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 0; i < erro.Length; i++)
{
Console.Write(erro[i]);
    Thread.Sleep(75);
} 
}
}
else if (!resposta.Trim().Substring(0,1).ToUpper().Contains("N") || resposta.Trim().Substring(0,1).ToUpper().Contains("S"))
{
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < erro.Length; i++)
{
Console.Write(erro[i]);
    Thread.Sleep(75);
} 
}
Console.ResetColor();