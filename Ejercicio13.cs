

int[,] matriz = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int elementoFinal = matriz[matriz.GetLength(0) - 1,matriz.GetLength(1) - 1];

  for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
            {
                if (j > 0)
                {
                    
                    matriz[i, j] = matriz[i, j - 1];
                }
                else if (i > 0)
                {
                    
                    matriz[i, 0] = matriz[i - 1, matriz.GetLength(1) - 1];
                }
            }
        }

matriz[0,0] = elementoFinal;

for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0 ; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j] + " ");
            }
        }
