Console.WriteLine("Ingrese un número");
int.TryParse(Console.ReadLine().Trim(), out int n);


bool primero = true;


for (int i = 2; i <= n; i++)
{
    while (n % i == 0)
    {
        if (!primero)
        {
            Console.Write(" * ");
        }


        Console.Write(i);
        primero = false;


        n = n / i;
    }
}
