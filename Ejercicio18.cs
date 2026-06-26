double[,] A = new double[2,2]
{
    {1.5,2.3},
    {4.2,5.2}
};


 // La nueva matriz invierte las dimensiones (Columnas x Filas)
    double[,] resultado = new double[A.GetLength(1), A.GetLength(0)];

    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            // El elemento [i,j] pasa a ser [j,i]
            resultado[j, i] = A[i, j];
        }
    }

 for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write(resultado[i,j] + " ");
        }
    }
