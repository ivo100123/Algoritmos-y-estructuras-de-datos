int input = 0;
double temperatura;


do{
Console.WriteLine("Inserte operación a realizar:\n 1 - Fahrenheit a celsius\n 2- Celsius a fahrenheit");
int.TryParse(Console.ReadLine().Trim(),out input);
}while(input != 1 && input != 2);


//Fahrenheit = (Celsius * 9/5) + 32


if (input == 1)
{
    Console.WriteLine("Inserte su temperatura fahrenheit (si no tiene decimales,poner con temp.00)");
    double.TryParse(Console.ReadLine().Trim(),out temperatura);
    Console.WriteLine(FahrenheitACelsius(temperatura));
}


if (input == 2)
{
    Console.WriteLine("Inserte su temperatura Celsius (si no tiene decimales,poner con temp.00)");
    double.TryParse(Console.ReadLine().Trim(),out temperatura);
    Console.WriteLine(CelsiusAFahrenheit(temperatura));
}


double FahrenheitACelsius(double temp)
{
    return (temperatura - 32) * 5/ 9;
}


double CelsiusAFahrenheit(double temp)
{
    return (temperatura * 9/5) + 32;
}
