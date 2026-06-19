int[,] matriz = new int[3, 3] 
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int temporal;

Console.WriteLine("Ingrese columna a cambiar 0 - 2");
int.TryParse(Console.ReadLine().Trim(),out int indice1);

Console.WriteLine("Intercambiar por columna... 0 - 2");
int.TryParse(Console.ReadLine().Trim(),out int indice2);

for(int i = 0; i < matriz.GetLength(0); i ++)
{
  for(int j = 0; j < matriz.GetLength(1); j++)
  {
    temporal = matriz[i,indice1];
    matriz[i,indice1] = matriz[i,indice2];
    matriz[i,indice2] = temporal;
  }
}

for(int i = 0; i < matriz.GetLength(0); i ++)
{
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i,j] + " ");
    }
}
