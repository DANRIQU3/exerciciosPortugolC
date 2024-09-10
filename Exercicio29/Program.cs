string nome;
decimal salario, novoSalario;
int anos;

Console.WriteLine("Digite o nome do funcionario:");
nome = Console.ReadLine();

Console.WriteLine("Digite o salário do funcionário:");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite quantos eles o funcionario trabalha na empresa");
anos = Convert.ToInt32(Console.ReadLine());

if (anos < 3 )
{
    novoSalario = salario + (salario * 0.03M);
}
else if (anos < 10 )
{
    novoSalario = salario + (salario * 0.125M);
}
else
{
    novoSalario = salario + (salario * 0.2M);
}

Console.WriteLine(nome + " seu novo saláio será de: R$ " + novoSalario);