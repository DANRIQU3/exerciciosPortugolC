int numero1, numero2;

Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O primeiro valor é o maior");
}
else if (numero1 < numero2)
{
    Console.WriteLine("O segundo valor é o maior");
}
else
{
    Console.WriteLine("Não existe valor maior, os dois são iguais");
}