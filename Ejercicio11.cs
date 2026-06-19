int[,] matriz = new int[3, 3] 
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int temporal;

Console.WriteLine("Ingrese fila a cambiar 0 - 2");
int.TryParse(Console.ReadLine().Trim(),out int indice1);

Console.WriteLine("Intercambiar por fila... 0 - 2");
int.TryParse(Console.ReadLine().Trim(),out int indice2);

for(int i = 0; i < matriz.GetLength(0); i ++)
{
  for(int j = 0; j < matriz.GetLength(1); j++)
  {
    temporal = matriz[indice1,j];
    matriz[indice1,j] = matriz[indice2,j];
    matriz[indice2,j] = temporal;
  }
}

for(int i = 0; i < matriz.GetLength(0); i ++)
{
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i,j] + " ");
    }
}
