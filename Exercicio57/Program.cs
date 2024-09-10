int idade = 0, totalIdades = 0, qtdAlunos  = 0;

while(idade != 999)
{
    totalIdades += idade;
    qtdAlunos++;

    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("O total de alunos é de: " +  qtdAlunos);
Console.WriteLine("A média na turma é de: " +  totalIdades / qtdAlunos);