Console.WriteLine("Ingrese su año");
int año = Convert.ToInt32(Console.ReadLine().Trim());


if (año % 4 == 0)
{
    if (año % 100 == 0)
    {
        if (año % 400 == 0) Console.WriteLine("Su número es un año bisiesto");
        else Console.WriteLine("Su número NO es un año bisiesto");
    }
    else
    {
        // Esto es lo que faltaba: años divisibles por 4 pero no por 100
        Console.WriteLine("Su número es un año bisiesto");
    }
}
else
{
    Console.WriteLine("Su número NO es un año bisiesto");
}
