/*Escribir una función/método llamado busquedaL que toma un arreglo de enteros y un
entero. Si el entero se encuentra entre los elementos del arreglo, el método debe devolver
la posición en la que se encuentra, caso contrario debe devolver un valor que permita
identificar a quien llama a la función/método que el entero no se encuentra en el arreglo.*/

int[] numeros = [1, 2, 3, 4, 5, 7];
int posicion = -2;

Console.WriteLine("Ingrese numero a buscar");
int.TryParse(Console.ReadLine().Trim(), out int num);

busquedaL(numeros,num);
void busquedaL(int[] array,int num) 
{
    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] == num) posicion = i;
    }
    Console.WriteLine($"Su numero esta en la posicion {posicion +1} (si dice -1 = no existe)");
} //+1 para que no cuente desde el 0
