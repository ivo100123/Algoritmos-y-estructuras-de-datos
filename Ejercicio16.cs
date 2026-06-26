double[,] A = new double[2,2]
{
    {1.5,2.3},
    {4.2,5.2}
};

double[,] B = new double[2,2]
{
    {2.3,5.3},
    {8.4,7.4}
};

double[,] C = new double[2,2];

for(int i = 0; i < A.GetLength(0); i++)
{
    for(int j = 0; j < A.GetLength(1); j++)
    {
        C[i,j] = A[i,j] - B[i,j];
    }
}

for(int i = 0; i < A.GetLength(0); i++)
{
    for(int j = 0; j < A.GetLength(1); j++)
    {
        Console.WriteLine(C[i,j] + " ");
    }
}
