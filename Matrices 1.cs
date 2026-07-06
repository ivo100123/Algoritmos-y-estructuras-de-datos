/*Escribir un método que dada una matriz de enteros devuelva la fila que contiene el
máximo elemento de la matriz.*/

int[,] matriz =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

maxElemento(matriz);

void maxElemento(int[,] matriz) 
{
    int filaMayor = matriz.GetLength(0);

    for(int i = 0; i < matriz.GetLength(0); i++) 
    {
        for (int j = 0; i < matriz.GetLength(1); j++) 
        {
            if (matriz[i,0] > matriz[0, j]) { filaMayor = i; }
        }
    }

    Console.WriteLine($"Fila mayor es {filaMayor + 1}");

}
