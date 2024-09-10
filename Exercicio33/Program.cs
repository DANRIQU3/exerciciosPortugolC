decimal peso, altura, imc;

Console.WriteLine("Digite seu peso:");
peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite sua altura:");
altura = Convert.ToDecimal(Console.ReadLine());

imc = peso / (altura * altura);

if(imc < 18.5M )
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine("Peso ideal");
}
else if (imc < 30)
{
    Console.WriteLine("Sobrepeso");
}
else if (imc < 40)
{
    Console.WriteLine("Obesidade");
}
else
{
    Console.WriteLine("Obesidade mórbida");
}