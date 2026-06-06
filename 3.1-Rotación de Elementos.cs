
int[] array = { 3, 5, 7, 2, 1 };

Console.WriteLine("Cuantas veces quiere rotar?");
int.TryParse(Console.ReadLine().Trim(),out int rotacion)

RotarDerecha(array, rotacion);

foreach(int num in array)Console.Write(num + " ");


static void RotarDerecha(int[] array, int rotacion)
{
    int n = array.Length;
    rotacion = rotacion % n;

    Revertir(array, 0, n - 1);
    Revertir(array, 0, rotacion - 1);
    Revertir(array, rotacion, n - 1);
}

static void Revertir(int[] array, int inicio, int fin)
{
    while (inicio < fin)
    {
        int temp = array[inicio];
        array[inicio] = array[fin];
        array[fin] = temp;

        inicio++; //Esto es basicamente lo mismo de antes. Inicio va para adelante y
        fin--;    // Fin va para atras hasta que se encuentran en el centro
    }
}
