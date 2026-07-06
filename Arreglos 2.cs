/*Escribir una función/método llamado productoEscalar que toma 2 arreglos de enteros
delmismo tamaño y devuelve el producto escalar entre los 2 arreglos.*/

int[] a = [1, 2, 3, 4, 5];
int[] b = [6, 7, 8, 9, 10];

int resul = 0;

Console.WriteLine($"Producto escalar es {productoEscalar(a, b)}");
int productoEscalar(int[] a, int[] b) 
{
    int totalA = 0;
    int totalB = 0;
    for (int i = 0; i < a.Length; i++) 
    {
       totalA += a[i];
        totalB += b[i];
    }

    resul = totalA * totalB;

    return resul; 
}
