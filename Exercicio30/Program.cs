decimal ladoA, ladoB, ladoC;

Console.WriteLine("Digite o comprimento do lado A:");
ladoA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado B:");
ladoB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado C:");
ladoC = Convert.ToDecimal(Console.ReadLine());

if (ladoA < (ladoB + ladoC) &&
    ladoB < (ladoC + ladoA) &&
    ladoC < (ladoA + ladoB))

    if (ladoA == ladoB && ladoB == ladoC)
    {
    Console.WriteLine("Ira formar um triângulo equilátero.");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
    Console.WriteLine("Ira formar um triângulo isósceles.");
    }
    else
    {
    Console.WriteLine("Ira formar um triangulo escaleno");
    }
else
{
    Console.WriteLine("Não é possivel formar um trinângulo.");
}