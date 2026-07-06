/*Escribir un método que dada una matriz de enteros y un entero, devuelva la posición de
la matriz en la que se encuentra ese entero, o un valor que indique que el entero no se
encuentra en la matriz.*/

int[,] matriz =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

Console.WriteLine("Ingrese numero a buscar");
int.TryParse(Console.ReadLine().Trim(), out int num);

busquedaL(matriz, num);
void busquedaL(int[,] matriz, int num)
{
    int[] posicion = [0, 0];

    for (int i = 0; i < matriz.GetLength(0) - 1; i++)
    {
        for (int j = 0; i < matriz.GetLength(1) - 1; j++)
        {
            if (matriz[i, j] == num)
            {
                posicion[0] = i;
                posicion[1] = j;
            }
        }
      
    }
    Console.WriteLine($"Su numero esta en  (si dice -1 = no existe)");
    foreach (int componente in posicion) Console.Write(componente + " ");
    
} //+1 para que no cuente desde el 0
