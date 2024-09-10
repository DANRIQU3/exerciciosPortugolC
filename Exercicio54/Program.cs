using System.Text.RegularExpressions;

decimal peso = 0, somaAlturas = 0, qtdMais90kg = 0, qtdeMenos50kgMenos1_60m = 0,
    qtdMais1_90mMais100kg = 0, contador = 0;
int altura = 0;

while (contador < 7)
{
    Console.WriteLine("Digite seu peso:");
    peso = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite sua altura (cm):");
    altura = Convert.ToInt32(Console.ReadLine());

    somaAlturas += altura;

    if (peso > 90)
    {
        qtdMais90kg++;
    }

    if (peso < 50 && altura < 160)
    {
        qtdeMenos50kgMenos1_60m++;
    }

    if (altura > 190 && peso > 100)
    {
        qtdMais1_90mMais100kg++;
    }

    contador++;
}
    Console.WriteLine("Qual foi a média de altura do grupo:" + somaAlturas / 7);
    Console.WriteLine("Quantas pessoas pesam mais de 90Kg:" +  qtdMais90kg);
    Console.WriteLine("Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m:" + qtdeMenos50kgMenos1_60m);
    Console.WriteLine("Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg:" + qtdMais1_90mMais100kg);
