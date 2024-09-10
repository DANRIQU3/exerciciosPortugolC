int anoNascimento, idadeMinima = 16, idade;

Console.WriteLine("Digite sua ano nascimento: ");
anoNascimento = Convert.ToInt32(Console.ReadLine());

idade = DateTime.Now.Year - anoNascimento;

if (idade > idadeMinima)
{
    Console.WriteLine("Você pode votar");
}
else
{
    Console.WriteLine("Você não pode votar");
}