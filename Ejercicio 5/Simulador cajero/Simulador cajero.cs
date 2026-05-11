float saldo;
float monto;
string menu_eleccion;
int calc_eleccion;


Console.WriteLine("Bienvenido. Elija Calculadora o Extraccion");
menu_eleccion = Console.ReadLine().Trim().ToLower();

if(menu_eleccion == "extraccion")
{
mostrarMenu();
Console.WriteLine(RealizarRetiro(saldo,monto));


void mostrarMenu()
{
    Console.WriteLine("Inserte su saldo disponible");
    Console.WriteLine("(No,no da el presupuesto para que lo guardemos por ud.)");
    float.TryParse(Console.ReadLine().Trim(),out saldo);

    Console.WriteLine("Cuanto es el monto a retirar?");
    float.TryParse(Console.ReadLine().Trim(),out monto);
}

float RealizarRetiro(float saldoActual, float montoARetirar)
{
    bool montoValido = false;
   
    if (montoARetirar > saldoActual || montoARetirar < 0) montoValido = false;
    else montoValido = true;

    if (montoValido == false)
    {
       Console.WriteLine("Su monto no es valido. No se completó la operación.\n Su saldo es:");
       return saldoActual;
    }
    else
    {
        montoValido = true;
        Console.WriteLine($"Retiró {montoARetirar:C}\n Su saldo es:");
        saldoActual -= montoARetirar;
        return saldoActual;
    }
};
}
else if (menu_eleccion == "calculadora")
{
    Console.WriteLine("Que desea hacer? 1 - Suma\n 2- Resta\n 3- Multiplicacion\n 4- Division\n 5- Salir")
    int.TryParse(Console.ReadLine().Trim(),out calc_eleccion)

    switch (calc_eleccion)
    {
            1:
                Console.WriteLine("Inserte primer numero");
                int.TryParse(Console.ReadLine().Trim(),out int num1);

                Console.WriteLine("Inserte segundo numero");
                int.TryParse(Console.ReadLine().Trim(),out int num2);

                int resul = num1 + num2;

                Console.WriteLine($"Su resultado es {resul}");
                break;

            2:

             Console.WriteLine("Inserte primer numero");
                int.TryParse(Console.ReadLine().Trim(),out int num1);

                Console.WriteLine("Inserte segundo numero");
                int.TryParse(Console.ReadLine().Trim(),out int num2);

                int resul = num1 - num2;

                Console.WriteLine($"Su resultado es {resul}");
                break;

            3:
                 Console.WriteLine("Inserte primer numero");
                int.TryParse(Console.ReadLine().Trim(),out int num1);

                Console.WriteLine("Inserte segundo numero");
                int.TryParse(Console.ReadLine().Trim(),out int num2);

                int resul = num1 * num2;

                Console.WriteLine($"Su resultado es {resul}");
                break;

            4:
                 Console.WriteLine("Inserte primer numero");
                int.TryParse(Console.ReadLine().Trim(),out int num1);

                Console.WriteLine("Inserte segundo numero");
                int.TryParse(Console.ReadLine().Trim(),out int num2);

                int resul = num1 / num2;

                Console.WriteLine($"Su resultado es {resul}");
                break;
    }
}
