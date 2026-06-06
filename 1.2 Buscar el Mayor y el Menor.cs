int[] arreglo = { 12, 5, 8, 20, 3, 15, 7, 10 };

int valorMayor = arreglo[0];
int valorMenor = arreglo[0];
int posicionMayor = 0;
int posicionMenor = 0;

for (int i = 1; i < arreglo.Length; i++) //Empezamos en 1 pq las variables ya tienen el 0
{
    if (arreglo[i] > valorMayor) 
    {
        valorMayor = arreglo[i];
        posicionMayor = i;
    }

    if (arreglo[i] < valorMenor)
    {
        valorMenor = arreglo[i];
        posicionMenor = i;
    }
}

Console.WriteLine($"El mayor es {valorMayor} en la posición {posicionMayor + 1}"); //+1 xq cuenta desde el 0
Console.WriteLine($"El menor es {valorMenor} en la posición {posicionMenor + 1}");
