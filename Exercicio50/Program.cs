int contador = 0, quantidadeAcima5 = 0, quantidadeDivisiveis3 = 0, numero;
string numerosSorteados = " ";

Random rand = new Random();

while(contador < 20)
{
    numero = rand.Next(0, 10);

    numerosSorteados += numero + " ";

    if(numero > 5)
    {
        quantidadeAcima5++;
    }

    if(numero % 3 == 0)
    {
        quantidadeDivisiveis3++;
    }

    contador++;
}

Console.WriteLine(numerosSorteados + " foram sorteados");
Console.WriteLine(quantidadeAcima5 + " números estão acima de 5");
Console.WriteLine(quantidadeDivisiveis3 + " números são divisiveis por 3");