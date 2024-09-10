int contador = 0, numero, quatidadesPares = 0, quantidadesImpares = 0;

while (contador < 6)
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        quatidadesPares++;
    }
    else
    {
        quantidadesImpares++;
    }
    contador++;
}

Console.WriteLine(quatidadesPares + " números são pares é " + quantidadesImpares + " números são impares");