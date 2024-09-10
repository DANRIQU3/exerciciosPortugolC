decimal valorCasa, salarioComprador, valorMensalCasa, limiteComprometimentoSalario;
int anosAPagar;

Console.WriteLine("Digite o valor da casa:");
valorCasa = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o salario do comprador:");
salarioComprador = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o prazo em anos para pagamento:");
anosAPagar = Convert.ToInt32(Console.ReadLine());

valorMensalCasa = (valorCasa / anosAPagar) / 12;
limiteComprometimentoSalario = salarioComprador * 0.03M;

if(limiteComprometimentoSalario > valorMensalCasa)
{
    Console.WriteLine("Compra aprovada");
}
else
{
    Console.WriteLine("Compra negada");
}