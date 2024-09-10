int contador = 1;

Console.WriteLine("Digite um número");
int limite = Convert.ToInt32(Console.ReadLine());

while (contador <= limite)
{
    Console.Write(contador + " ");

    contador ++;
}
Console.Write("Acabou!");