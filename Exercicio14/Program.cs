int totalkm, totalDias;
decimal valorDia = 90, valorkmRodado = 0.20M, valorTotal;

Console.WriteLine("Digite a quantidade de dias que você ficou com o carro:"):
totalDias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade KM rodados:");
totalkm = Convert.ToInt32(Console.ReadLine());

valorTotal = (totalDias + valorDia) + ( totalkm + valorkmRodado);   

Console.WriteLine("O valor total da fatura é de: R$ " + valorTotal);
