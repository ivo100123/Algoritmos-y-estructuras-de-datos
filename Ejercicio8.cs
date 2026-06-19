int[,] matriz = new int[3, 3] 
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int mayor = -1;
int fila = -1;
int columna = -1;

Console.WriteLine("Inserte numero a buscar dentro de la matriz");
int.TryParse(Console.ReadLine().Trim(),out int input);

for(int i = 0; i < matriz.GetLength(0); i++) 
{
    for(int j = 0; j < matriz.GetLength(1); j++) 
    {
        if (matriz[i,j] == input) 
        {
            fila = i;
            columna = j;
        }

    }
   
} 

Console.WriteLine($"El elemento se encuentra en la posicion {fila},{columna}");
