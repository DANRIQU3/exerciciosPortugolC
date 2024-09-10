int contador = 500, resultado = 0;

while (contador >= 0)
{
    resultado += contador;

    contador -= 50;
}

Console.WriteLine("O resultado da soma foi de " + resultado);