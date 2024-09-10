int multiplicando;

Console.WriteLine("Digite um número da tabuada:");
multiplicando = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(multiplicando + " x " + i + " = " + (multiplicando * i));
}