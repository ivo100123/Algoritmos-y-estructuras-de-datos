int numero;
int pasos = 0;


Console.WriteLine("Ingrese su número.");
numero = int.Parse(Console.ReadLine());


while(numero != 1)
{
    pasos++;


    if (numero % 2 == 0)
    {
        Console.WriteLine("Número par. Dividimos por 2.");
        numero = numero / 2;
        Console.WriteLine(numero);
    }
    else
    {
        Console.WriteLine("Número impar. Multiplicamos por 3 y sumamos 1");
        numero = (numero * 3) + 1;
        Console.WriteLine(numero);
    }
}


Console.WriteLine($"Juego terminado. Pasos hasta llegar a 1: {pasos}");
