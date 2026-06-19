int[,] matriz = new int[3, 3] 
{
    { 1, -2, 3 },
    { -4, 5, 6 },
    { -7, 8, -9 }
};

int cont = 0;

for(int i = 0; i < matriz.GetLength(0); i++) 
{
    
    for(int j = 0; j < matriz.GetLength(1); j++) 
    {
        if (matriz[i, j] > 0) cont++;
    }
} 

Console.WriteLine($"La cantidad de positivos es {cont}");
