int[] array = {1,2,3,6,7,8,9,13};

Console.WriteLine("Se rompió la regla " + estrictamenteCreciente(array) + " veces");

int estrictamenteCreciente(int[] a)
{
    int contador = 0;
    int temporal = a[0];

    for (int i = 1; i < a.Length; i++)
    {
        temporal++;
        if (a[i] == temporal) contador++;

    }
    
    return contador;
}


