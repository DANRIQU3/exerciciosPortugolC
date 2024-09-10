string genero;
decimal salarioAtual, salarioFinal;
int quantidadeAnos;

Console.WriteLine("Digite o gênero do funcionario:");
genero = Console.ReadLine();

Console.WriteLine("Digite a quantos anos ele trabalha na empresa:");
quantidadeAnos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o salario do funcionario:");
salarioAtual = Convert.ToDecimal(Console.ReadLine());

if ( genero.ToUpper() == "M")
{
    if ( quantidadeAnos < 15)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.05M);
    } else if ( quantidadeAnos < 20 )
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.12M);
    }
    else
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.23M);
    }
}
else
{
    if (quantidadeAnos < 20)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.03M);
    }
    else if (quantidadeAnos < 30)
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.13M);
    }
    else
    {
        salarioFinal = salarioAtual + (salarioAtual * 0.25M);
    }
}

Console.WriteLine("O novo salário do funcionário é de R$: " +  salarioFinal);
