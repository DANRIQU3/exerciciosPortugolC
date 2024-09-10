int contador = 30;

while (contador >= 1)
{
    if (contador % 4 == 0)
    {
        Console.Write("[" + contador + "] ");
    }
    else
    {
        Console.Write(contador + " ");
    }
    contador --;
}

Console.Write("Acabou!");