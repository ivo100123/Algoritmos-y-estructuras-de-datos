int[,] matriz = new int[10, 10];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++) //Si la posicion del array es par,insertamos un cero
    {
        if ((i + j) % 2 == 0) matriz[i, j] = 0; //Si la posicion de la matriz es impar,insertamos otro valor. Las posiciones pares tienen que tener 0,y las impares i
        else matriz[i, j] = 1; 
    }
}

foreach (int componente in matriz) Console.WriteLine(componente);
