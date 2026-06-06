
string[] arreglo = {"favor", "por", "aprobame", "Profe"};

invertir(arreglo);

foreach (string nombre in arreglo)
{
    Console.Write(nombre + " ");
}


void invertir(string[] array)
{
    int inicio = 0;
    int fin = array.Length - 1;

    while (inicio < fin)
    {
        string temporal = array[inicio];
        array[inicio] = array[fin];
        array[fin] = temporal;

        inicio++;
        fin--; 
    }
}
