using System.ComponentModel.Design;

string tipoCarro;
int quantidadeDias, kmPercorridos;
decimal valorCobranca = 0;

Console.WriteLine("Digite o tipo de carro (popular ou luxo):");
tipoCarro = Console.ReadLine();

Console.WriteLine("Digite a quantidade de dias do aluguel:");
quantidadeDias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite os kms percorridos:");
kmPercorridos = Convert.ToInt32(Console.ReadLine());

if (tipoCarro == "popular")
{
    valorCobranca = 90 * quantidadeDias;
    if (kmPercorridos <= 100)
    {
        valorCobranca += 0.20M * kmPercorridos;
    }
    else
    {
        valorCobranca += 0.10M * kmPercorridos;
    }
}
else
{
    valorCobranca = 150 * quantidadeDias;
    if (kmPercorridos <= 200)
    {
        valorCobranca += 0.30M * kmPercorridos;
    }
    else
    {
        valorCobranca += 0.25M * kmPercorridos;
    }
}

Console.WriteLine("O valor do aluguel foi de R$: " +  valorCobranca);