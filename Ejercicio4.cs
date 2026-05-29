int[] array = {1,2,3,4,5,6,7,8,9};

Console.WriteLine("Ingrese numero a buscar");
int.TryParse(Console.ReadLine().Trim(),out int num);
Console.WriteLine(busquedaLineal(array,num));

int busquedaLineal(int[] arreglo, int valor)
{
    
    for(int i = 0; i < arreglo.Length; i++)
    {
        if(array[i] == valor) return i;
        else i = valor - 2;
    }

    return -1; 
}
