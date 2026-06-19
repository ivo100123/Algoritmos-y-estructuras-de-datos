int[,] matriz = new int[3, 3] 
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 888, 9 }
};

int mayorNum = 0;
int mayorColumna = 0;
int mayorFila = 0;

for(int i = 0; i < matriz.GetLength(0); i++) 
{
    for(int j = 0; j < matriz.GetLength(1); j++) 
    {
        if (matriz[i,j] > mayorNum) 
        {
         mayorNum = matriz[i,j];
         mayorColumna = j;
         mayorFila = i;
        }
    }
   
} 

Console.WriteLine($"El mayor elemento esta en la posicion {mayorFila},{mayorColumna}");
