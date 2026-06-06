
int[] array = { 1, 2, 3, 3, 4, 5, 5, 6 };

int nuevaLongitud = EliminarDuplicados(array);

for (int i = 0; i < nuevaLongitud; i++) //Uso nueva longitud para que no se vean los valores repetidos
                                        //por eso no puedo usar foreach,porque sino muestra todo
{
    Console.Write(array[i] + " ");
}


int EliminarDuplicados(int[] array) //calcula el tamaño que tiene el array sin los duplicados
{
    if (array.Length == 0) return 0;

    int j = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != array[j])
        {
            j++;
            array[j] = array[i];
        }
    }

    return j + 1;
}
