int[] array = {5,7,8,4,3,2,6,9}; //pq no tengo creatividad para hacer numeros nuevos :)

Console.WriteLine("Ingrese numero a buscar");
int.TryParse(Console.ReadLine().Trim(),out int num);
Console.WriteLine(busquedaLineal(array,num));

int busquedaLineal(int[] arreglo, int valor)
{
    for(int i = 0; i < arreglo.Length; i++)
    {
        if(valor == arreglo[i]) return i;  //Si encuentra una coincidencia,devuelve el slot
    }

    return -1; // Si cierra el ciclo,no encontro nada y mandamos -1
}
