string frase = "Responda com Sim ou Não.\n";
string erro = "Na próxima responda com Sim ou Não.\n";
string deveria = "Deveria?\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
}

frase = "Está se movendo?\n";
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
    Thread.Sleep(75);
}
string resposta = Console.ReadLine()!;
if (resposta.Substring(0,1).ToUpper().Contains("S"))
{
for (int i = 0; i < frase.Length; i++)
{
Console.Write(deveria[i]);
    Thread.Sleep(75);
} 
}
else
for (int i = 0; i < frase.Length; i++)
{
Console.Write(erro[i]);
    Thread.Sleep(75);
} 