using System;

decimal nota1, nota2, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (media <= 4.9M)
{
    Console.WriteLine("REPROVADO");
}
else if (media <= 6.9M)
{
    Console.WriteLine("RECUPERAÇAO");
}
else
{
    Console.WriteLine("APROVADO");
}