decimal ladoA, ladoB, ladoC;

Console.WriteLine("Digite o comprimento do lado A:");
ladoA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado B:");
ladoB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado C:");
ladoC = Convert.ToDecimal(Console.ReadLine());

if (ladoA < ( ladoB + ladoC ) &&
    ladoB < ( ladoC + ladoA ) &&
    ladoC < ( ladoA + ladoB ))
{
    Console.WriteLine("É possível formar um triângulo.");
}
else
{
    Console.WriteLine("Não é possível formar um triângulo.");
}