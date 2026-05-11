try 
{
    Console.Write("Inserte el número base:");
    int num = int.Parse(Console.ReadLine());
    Console.Write("Exponente: ");
    int ex = int.Parse(Console.ReadLine());

    Console.WriteLine($"Resultado: {CalcularPotencia(num, ex)}");
}


catch (FormatException) 
{
    Console.WriteLine("No se pueden ingresar valores no numéricos.");
}
catch (Exception ex) 
{
    Console.WriteLine($"Esta función no acepta números negativos");
}

int CalcularPotencia(int baseNum, int exponente)
{
    if (exponente < 0)
         return ("Esta función no soporta exponentes negativos");

    // Caso Base
    if (exponente == 0) 
        return 1;

    // Caso Recursivo
    return baseNum * CalcularPotencia(baseNum, exponente - 1);
}
