﻿int primeiroValor, segundoValor, incremento;

Console.WriteLine("Digite o primeiro valor:");
primeiroValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
segundoValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o incremento:");
incremento = Convert.ToInt32(Console.ReadLine());

while(primeiroValor <= segundoValor)
{
    Console.Write(primeiroValor + " ");

    primeiroValor += incremento;
}

Console.Write("Acabou!");