int idade, maiorIdade = 0, qtdeHomens = 0, idadeMulherMaisJovem = 0, totalIdadeHomens = 0;
string sexo, continuar = "S";

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }

    if (sexo.ToUpper() == "M")
    {
        qtdeHomens++;
        totalIdadeHomens += idade;
    }
    else
    {
        if (idade > idadeMulherMaisJovem)
        {
            idadeMulherMaisJovem = idade;
        }
    }

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}   

    Console.WriteLine("qual é a maior idade lida:" + maiorIdade);
    Console.WriteLine("quantos homens foram cadastrados:" + qtdeHomens);
    Console.WriteLine("qual é a idade da mulher mais jovem:" + idadeMulherMaisJovem);
    Console.WriteLine("qual é a média de idade entre os homens:" + totalIdadeHomens);

