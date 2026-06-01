int[] suma = [1,2,3,4,5,6,7,8,9,10];
Console.WriteLine($"Su promedio es: {sumaYPromedio(suma)}");


int sumaYPromedio(int[] array)
{
    int resultadoSuma = 0;
    foreach(int componente in array)
    {
        resultadoSuma += componente;
    }

    return resultadoSuma / array.Length;
}
