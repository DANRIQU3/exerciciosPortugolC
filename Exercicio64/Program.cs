string sexo;
decimal peso, totalPesoMulheres = 0, maiorPesoHomens = 0;
int qtdeMulheres = 0, qtdeHomensMais100kg = 0;

for(int i = 1; i <= 8 ; i++)
{
    Console.WriteLine("Digite seu sexo:");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite seu peso:");
    peso = Convert.ToDecimal(Console.ReadLine());

    if (sexo.ToUpper() == "M")
    {
        if (peso > 100)
        {
            qtdeHomensMais100kg++;
        }

        if (maiorPesoHomens < peso)
        {
            maiorPesoHomens = peso;
        }
    }
    else
    {
        qtdeMulheres++;
        totalPesoMulheres += peso;
    }
}

Console.WriteLine("Quantas mulheres foram cadastradas:" + qtdeMulheres);
Console.WriteLine("Quantos homens pesam mais de 100Kg:" + qtdeHomensMais100kg);
Console.WriteLine("A média de peso entre as mulheres:" +  totalPesoMulheres / qtdeMulheres);
Console.WriteLine("O maior peso entre os homens:" + maiorPesoHomens);