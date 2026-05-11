int sueldo = 0;
int nivelImpuestos = 0;


do
{
    Console.WriteLine("Inserte su sueldo");
    sueldo = Convert.ToInt32(Console.ReadLine().Trim());
} while (sueldo == null || sueldo == 0);


if(sueldo >= 100000) nivelImpuestos = 3;
else if(sueldo > 50000 && sueldo < 1000000) nivelImpuestos = 2;
else if(sueldo < 50000) nivelImpuestos = 1;






Console.WriteLine("Se ha cobrado el 10% de comisión");
sueldo -= (sueldo * 10) / 100;
Console.WriteLine(sueldo);


switch(nivelImpuestos)
{
    case 1:
        Console.WriteLine("Su nivel de impuestos es: Pobre,se le descontará solo 20% de impuestos");
        sueldo -= (sueldo*20)/100;
        Console.WriteLine($"Su sueldo final es {sueldo}");
    break;


    case 2:
        Console.WriteLine("Su nivel de impuestos es: Clase Media,se le descontará 40% de impuestos");
        sueldo -= (sueldo*40)/100;
        Console.WriteLine($"Su sueldo final es {sueldo}");
    break;


    case 3:
        Console.WriteLine("Su nivel de impuestos es: Pobre,se le descontará 80% de impuestos");
        sueldo -= (sueldo*80)/100;
        Console.WriteLine($"Su sueldo final es {sueldo}");
    break;
}
