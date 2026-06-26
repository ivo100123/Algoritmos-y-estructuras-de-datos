int[,] matriz = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};


int elementoInicial = matriz[0, 0];


for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        if (j < matriz.GetLength(1) - 1)
        {
           
            matriz[i, j] = matriz[i, j + 1];
        }
        else if (i < matriz.GetLength(0) - 1)
        {
           
            matriz[i, j] = matriz[i + 1, 0];
        }
    }
}


matriz[matriz.GetLength(0) - 1, matriz.GetLength(1) - 1] = elementoInicial;


for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
   
}
