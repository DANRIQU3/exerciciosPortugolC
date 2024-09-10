using System.ComponentModel.Design;

int anoNascimento, idade;

Console.WriteLine("Digite o ano do nascimento:");
anoNascimento = Convert.ToInt32(Console.ReadLine());

idade = DateTime.Now.Year - anoNascimento;

if(idade <= 18)
{
    Console.WriteLine("Faltam: " + (18 - idade) + " para o alistamento");
}
else
{
    Console.WriteLine("Já se passaram : " + (idade - 18) + " do ano do alistamento");
}