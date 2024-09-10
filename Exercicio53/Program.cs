int contador = 0, idade, qtdeMulheres = 0, qtdHomens = 0, mediaIdade = 0,
    mediaIdadeHomens = 0, qtdMulheresMais20 = 0;
string sexo = "";

while(contador < 5)
{
    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite seu sexo:(M ou F)");
    sexo = Console.ReadLine();

    if(sexo.ToUpper() == "F")
    {
        qtdeMulheres++;

        if(idade > 20)
        {
            qtdMulheresMais20++;
        }
    }
    else
    {
        qtdHomens++;
        mediaIdadeHomens += idade;
    }

    mediaIdade += idade;    

    contador++;
}

Console.WriteLine("Quantos homens foram cadastrados: " + qtdHomens);
Console.WriteLine(" Quantas mulheres foram cadastradas: " + qtdeMulheres);
Console.WriteLine("A média de idade do grupo: " + (mediaIdade / 5));
Console.WriteLine("A média de idade dos homens: " + (mediaIdade / qtdHomens));
Console.WriteLine("Quantas mulheres tem mais de 20 anos: " + qtdMulheresMais20);
