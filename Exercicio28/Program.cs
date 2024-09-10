decimal largura, comprimento, area;

Console.WriteLine("Digite a largura do terreno:");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terreno:");
comprimento = Convert.ToDecimal(Console.ReadLine());

area = largura * comprimento;

if (area < 100)
{
    Console.WriteLine("TERRENO POPULAR");
}
else if (area > 100 || area < 500)
{
    Console.WriteLine("TERRENO MASTER");
}
else
{
    Console.WriteLine("TERRENO VIP");
}