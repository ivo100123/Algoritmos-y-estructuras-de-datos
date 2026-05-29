int[] array = {7,8,6,4,2,1};
int[] array2 = {9,5,3,7,6,2};

Console.WriteLine(productoEscalarConInverso(array,array2));


int productoEscalarConInverso(int[] a, int[] b)
{
    int[] inverso = new int[b.Length];
    int resultado = 0;
    
    
    for(int i = b.Length - 1; i >= 0; i--)
    {
        inverso[i] = b[i];
    }

    for(int i = 0; i < b.Length; i++)
    {
        int multiplicacion = a[i] * inverso[i];
        resultado += multiplicacion;
    }

    return resultado;
}
