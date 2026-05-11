Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());


bool esPrimo = true;


if (numero <= 1) esPrimo = false;


for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        esPrimo = false;
        break;
    }
}


if (!esPrimo)
{
    Console.WriteLine("El número NO es primo.");
}
else
{
    Console.WriteLine("El número es primo.");


    int contador = 1;
    bool encontrado = false;


    while (!encontrado)
    {
        int arriba = numero + contador;
        int abajo = numero - contador;


       
        if (contador == 2)
        {
           
            bool primoArriba = true;
            if (arriba <= 1) primoArriba = false;


            for (int i = 2; i < arriba; i++)
            {
                if (arriba % i == 0)
                {
                    primoArriba = false;
                    break;
                }
            }


            if (primoArriba)
            {
                Console.WriteLine($"Primo gemelo: {arriba}");
                encontrado = true;
                break;
            }


           
            bool primoAbajo = true;
            if (abajo <= 1) primoAbajo = false;


            for (int i = 2; i < abajo; i++)
            {
                if (abajo % i == 0)
                {
                    primoAbajo = false;
                    break;
                }
            }


            if (primoAbajo)
            {
                Console.WriteLine($"Primo gemelo: {abajo}");
                encontrado = true;
                break;
            }
        }


        contador++;
    }
}
