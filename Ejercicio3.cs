
int[] array = {1 , 5, 6 , 4 , 2  , 7 , 9 , 3 , 8};

foreach (int componente in ordenar(array))
{
    Console.Write(componente + " ");
}

int[] ordenar(int[] a)
{

    for (int i = 0; i < a.Length - 1; i++)
    {
        for (int j = 0; j < a.Length - i - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                int temporal = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temporal;
            }
        }
    }
    
    return a;
}
