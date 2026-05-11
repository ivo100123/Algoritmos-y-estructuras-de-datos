Console.WriteLine("Inserte el número a invertir");
int.TryParse(Console.ReadLine().Trim(),out int num);
Console.WriteLine(invertirNumero(num));

void invertirNumero(int n)
{

    if (n < 10)
    {
        Console.Write(n);
        return;
    }

    Console.Write(n % 10);

    InvertirNumero(n / 10);
}



