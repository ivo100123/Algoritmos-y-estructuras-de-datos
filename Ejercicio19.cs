
double[,] A = new double[2, 2]
{
    { 4, 7 },
    { 2, 6 }
};


double determinante = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];


double temporal = A[0, 0];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        
        if (i == 0 && j == 1 || i == 1 && j == 0) 
        {
            A[i, j] = A[i, j] * -1;
        }
    }
}

A[0, 0] = A[1, 1];
A[1, 1] = temporal;

for (int i = 0; i < A.GetLength(0); i++)
{   
    for (int j = 0; j < A.GetLength(1); j++)
    {
        
        A[i, j] = A[i, j] * (1 / determinante);
    }
}


for (int i = 0; i < A.GetLength(0); i++)
{   
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write(A[i, j] + " ");
    }
}
