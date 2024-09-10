decimal salario, percentualAumento = 0.15M, salarioFinal;

Console.WriteLine("Digite o seu salario :");
salario = Convert.ToDecimal(Console.ReadLine());

salarioFinal = salario + salario * percentualAumento;

Console.WriteLine("O seu novo salario é de: " +  salarioFinal);
