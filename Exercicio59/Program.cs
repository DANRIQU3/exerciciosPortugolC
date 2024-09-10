int idade, idadePessoaMaisVelha = 0, idadeMulherMaisJovem = 0, idadeMulherMaisJovem = 999, totalIdade = 0,
    quantidade = 0, qtdeHomensMais30Anos = 0, qtdeMulheres18Anos = 0;
string nome, sexo, continuar = "S", nomePessoaMaisVelha = "", nomeMulherMaisJovem = "";

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > idadePessoaMaisVelha)
    {
        nomePessoaMaisVelha = nome;
        idadePessoaMaisVelha = idade;
    }

    if (sexo.ToUpper() == "F")
    {
        if (idade < idadeMulherMaisJovem)
        {
            nomeMulherMaisJovem = nome;
            idadeMulherMaisJovem = idade;
        }

        if (idade < 18)
        {
            qtdeMulheres18Anos++;
        }
        else
        {
            if (idade > 30)
            {
                qtdeHomensMais30Anos++;
            }
        }

        totalIdade += idade;
        quantidade++;

        Console.WriteLine("Deseja continuar informando (S ou N)");
        continuar = Console.ReadLine();
    }

     Console.WriteLine("O nome da pessoa mais velha:" + nomePessoaMaisVelha);
     Console.WriteLine("O nome da mulher mais jovem:" + nomeMulherMaisJovem);
     Console.WriteLine("A média de idade do grupo:" + totalIdade / quantidade);
     Console.WriteLine("Quantos homens tem mais de 30 anos:" + qtdeHomensMais30Anos);
     Console.WriteLine("Quantas mulheres tem menos de 18 anos:" + qtdeMulheres18Anos);


