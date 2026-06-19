int[,] matriz = new int[3, 3] 
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int mayor = 0;

Console.WriteLine("La matriz es de 3x3. ¿Que columna quiere revisar? 0 - 2");
int.TryParse(Console.ReadLine().Trim(),out int input);

for(int i = 0; i < matriz.GetLength(1); i++) 
{
    
    if (matriz[i, input] > mayor) mayor = matriz[i, input];


} 

Console.WriteLine($"El mayor numero de la columna es {mayor}");
