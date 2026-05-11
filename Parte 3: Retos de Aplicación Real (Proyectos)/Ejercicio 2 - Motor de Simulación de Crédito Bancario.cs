int edad;
int ingresos;
int puntaje;
int monto;
double interes = 0;
double cuota;
string input;


Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine().Trim());


if (edad >= 18 && edad <= 75)
{
    Console.WriteLine("Ingrese sus ingresos mensuales");
    ingresos = Convert.ToInt32(Console.ReadLine().Trim());


    do
    {
        Console.WriteLine("Cuanto es su puntaje crediticio? (0 - 1000)");
        puntaje = Convert.ToInt32(Console.ReadLine().Trim());
        if (puntaje < 0 || puntaje > 1000) Console.WriteLine("Puntaje inválido");
    } while (puntaje < 0 || puntaje > 1000);


    Console.WriteLine("Cuanto es el monto que necesita?");
    monto = Convert.ToInt32(Console.ReadLine().Trim());


    Console.WriteLine("Cuál es el plazo deseado (en meses)?");
    int.TryParse(Console.ReadLine().Trim(), out int plazo);


   
    if (puntaje > 800) interes = 0.05;
    else if (puntaje >= 600) interes = 0.12;
    else
    {
        Console.WriteLine("Confirmar operación? (si/no)");
        if (Console.ReadLine().Trim().ToLower() != "si")
        {
            Console.WriteLine("Operación cancelada.");
            return;
        }
        interes = 0.12;
    }


    double total = monto + (monto * interes);
    cuota = total / plazo;


    while (((ingresos * 30) / 100.0) < cuota)
    {
        Console.WriteLine($"La cuota mensual excede el 30% de sus ingresos. ¿Aumentar su plazo? (Plazo actual:{plazo}) Cancelar/Si");
        input = Console.ReadLine().Trim().ToLower();


        if (input == "si")
        {
            plazo++;
            cuota = total / plazo;
        }
        else if (input == "cancelar")
        {
            Console.WriteLine("Operación cancelada.");
            break;
        }
        else Console.WriteLine("Invalido.");
    }


    if (((ingresos * 30) / 100.0) >= cuota)
    {
        Console.WriteLine("Cuota mensual Apta para su sueldo");
    }


    Console.WriteLine("Mes\t | Pago\t | Saldo Restante");


    int mes = 0;
    double saldo = total;


    for (int i = 0; i < plazo; i++)
    {
        mes++;
        saldo -= cuota;
        if (saldo < 0) saldo = 0;


        Console.Write(mes + "\t\t");
        Console.Write(cuota + "\t\t");
        Console.WriteLine(saldo);
    }
}
else Console.WriteLine("Edad inválida.");


Console.WriteLine("\nGracias por usar nuestros servicios.");


        Console.Write(cuota + "\t\t");
        Console.Write(saldo);
        }
    }
}
else Console.WriteLine("Edad inválida.");


Console.WriteLine("\nGracias por usar nuestros servicios.");
