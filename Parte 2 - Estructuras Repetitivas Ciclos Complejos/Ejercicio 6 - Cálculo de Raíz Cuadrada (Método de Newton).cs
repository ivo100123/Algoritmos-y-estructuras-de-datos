Console.WriteLine("Ingrese un número:");
double n = double.Parse(Console.ReadLine());


double aprox = n;
double precision = 0.0001;


while (true)
{
    double siguiente = 0.5 * (aprox + n / aprox);


    double diferencia = siguiente - aprox;
    if (diferencia < 0)
        diferencia = -1 * diferencia;


    if (diferencia < precision)
        break;


    aprox = siguiente;
}


Console.WriteLine($"Raiz aproximada: {aprox}");
