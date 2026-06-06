
Random random = new Random();
int[] numeros = new int[15];


for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(1, 51);
}


int contadorPrimos = 0;
foreach (int num in numeros)
{
    if (EsPrimo(num))
        contadorPrimos++;
}


int[] primos = new int[contadorPrimos];
int j = 0;

foreach (int num in numeros)
{
    if (EsPrimo(num))
    {
        primos[j] = num;
        j++;
    }
}

Console.WriteLine("numeros:");
foreach(int num in numeros) Console.Write(num + " ");
Console.WriteLine(); //para crear una nueva linea despues de imprimir todo

Console.WriteLine("Primos:");
foreach(int num in primos) Console.Write(num + " ");



static bool EsPrimo(int n)
{
    if (n < 2) return false;

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}
