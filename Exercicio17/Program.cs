using System.Reflection.Metadata;

int velocidadeCarro, limite = 80;
decimal valorMulta = 5, valorPagar;

Console.WriteLine("Digite a velocidade do carro: ");
velocidadeCarro = Convert.ToInt32(Console.ReadLine());

if (velocidadeCarro > limite)
{
    valorPagar = (velocidadeCarro - limite) * valorMulta;
    Console.WriteLine("Você passou acima do limite permitido, multa: R$ " + valorPagar);
}