int horasAtividadesMes, pontos = 0;
decimal valorFinal;

Console.WriteLine("Digite a quantidade de horas em atividades físicas no mês:");
horasAtividadesMes = Convert.ToInt32(Console.ReadLine());

if (horasAtividadesMes <= 10)
{
    pontos = 2 * horasAtividadesMes;
} else  if (horasAtividadesMes <= 20)
{
    pontos = 5* horasAtividadesMes;
}
else
{
    pontos = 10 * horasAtividadesMes;
}

valorFinal = pontos * 0.05M;

Console.WriteLine("O valor do prêmio é de: R$: " +  valorFinal);