
int[] array = {1 , 2, 3 , 4 , 5 , 0};

Console.WriteLine("Inserte el numero a ingresar");
int.TryParse(Console.ReadLine(),out int num);

foreach(int componente in intercalar(array,num))
{
    Console.Write(componente + " ");
}

int[] intercalar(int[] a, int valor)
{
    int i; //la pongo afuera para poder usarla fuera del for 

    for(i = a.Length - 2; i >= 0 && a[i] > valor; i--)
    {
        a[i + 1] = a[i];
    }

    a[i + 1] = valor; 

    return a;
}
