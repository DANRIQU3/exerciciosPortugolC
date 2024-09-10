decimal preco, desconto = 0.5M, valorFinal;

Console.WriteLine("Digite o preço do produto: ");
preco = Convert.ToDecimal(Console.ReadLine());

valorFinal = preco - desconto * preco;

Console.WriteLine("O valor com desconto é de R$ " + valorFinal);