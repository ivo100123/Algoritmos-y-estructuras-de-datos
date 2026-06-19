int[,] matriz = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int cont = 0;

Console.WriteLine("Ingrese columna a sumar 0 - 2");
int.TryParse(Console.ReadLine().Trim(), out int input);

for (int j = 0; j < matriz.GetLength(0); j++)
{
    cont += matriz[j, input];
}


Console.WriteLine($"Su resultado es {cont}");
