int numero, somatorio = 0, contador = 0;

while( contador < 7)
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    somatorio += numero;

    contador++;
}

Console.WriteLine("O valor final foi: " + somatorio);