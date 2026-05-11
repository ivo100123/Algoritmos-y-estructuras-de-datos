int radio;
double area;
string mensaje = "-- EL RESULTADO ES ";


Console.WriteLine("Ingrese el radio de su circulo");
int.TryParse(Console.ReadLine().Trim(),out radio);


area = CalcularAreaCirculo(radio);


Console.WriteLine(ImprimirResultado(mensaje,area));


double CalcularAreaCirculo(int radio)
{
    return 3.14 * Math.Pow(radio, 2);
}


string ImprimirResultado(string msj, double resultado)
{
    return msj + resultado + " --";
}
