decimal salario = 0, totalSalariosHomens = 0, totalSalariosMulheres = 0;
string sexo, continuar = "S";

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite seu salário:");
    salario = Convert.ToDecimal(Console.ReadLine());

    if (sexo.ToUpper() == "M")
    {
        totalSalariosHomens += salario;
    }
    else
    {
        totalSalariosMulheres += salario;
    }

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();

}

Console.WriteLine("O total de salário dos homens foi: R$ " + totalSalariosHomens);
Console.WriteLine("O total de salário das mulheres foi: R$ " + totalSalariosMulheres);
