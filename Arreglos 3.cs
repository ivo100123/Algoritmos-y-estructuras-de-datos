/*3-Escribir una función/método llamado ordenar que toma un arreglo de enteros. El método
debe devolver el mismo arreglo que tomó como parámetro, pero con sus valores ordenados
de manera ascendente.*/

int[] array = [2, 1, 3, 4, 6, 5, 7];

array = ordenar(array);

foreach(int componente in array) 
{
    Console.Write(componente + " ");
}

int[] ordenar(int[] arreglo) 
{
    int temporal;

    for(int i = 0; i < arreglo.Length - 1; i++) 
    {
        if (arreglo[i] > arreglo[i + 1]) //Si el actual es mayor al siguiente,intercambiar lugares
        {
            temporal = arreglo[i];
            arreglo[i] = arreglo[i + 1];
            arreglo[i + 1] = temporal;
        }
    }
    return arreglo;
}
