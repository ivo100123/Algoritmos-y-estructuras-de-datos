
char[] array = { 'a', 'b', 'a', 'c', 'b', 'a', 'd', 'c', 'a', 'b' };
bool[] visitado = new bool[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (visitado[i]) continue; //Si ya lo contamos antes,lo ignora

    int contador = 1; //Empieza en 1 porque ya empieza en una aparicion de la letra

    for (int j = i + 1; j < array.Length; j++) //Busca la letra que ya encontramos en el resto del array
    {
        if (array[i] == array[j])
        {
            contador++;
            visitado[j] = true; //Lo marcamos como ya contado para que no la cuente dos veces
        }
    }

    Console.WriteLine($"{array[i]} aparece {contador} veces"); //Imprime todas las letras
}
