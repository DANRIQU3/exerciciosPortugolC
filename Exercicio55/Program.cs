int numero = 0, somatorio = 0;

while(numero != 1111)
{
    somatorio += numero;

    Console.WriteLine("Digite um número:");
    numero = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("O somatório dos números é:" + somatorio);

