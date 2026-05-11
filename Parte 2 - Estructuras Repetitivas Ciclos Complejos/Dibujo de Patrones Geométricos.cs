Console.WriteLine("Ingrese un numero:");
int num = int.Parse(Console.ReadLine().Trim());


int ancho = 2 * num - 1;




for (int i = 0; i < num; i++)
{
    for (int j = 0; j < ancho; j++)
    {
        if (j == num - 1 - i || j == num - 1 + i)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}




for (int i = num - 2; i >= 0; i--)
{
    for (int j = 0; j < ancho; j++)
    {
        if (j == num - 1 - i || j == num - 1 + i)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}
