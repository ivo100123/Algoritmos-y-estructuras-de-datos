string? respuesta;
string tipoVehiculo;
int pasajeros;
int cantidadVehiculos = 0;
float recaudo = 0f;
float costo = 0f;
TimeOnly hora;


do
{
    Console.WriteLine("Que desea hacer?");
    respuesta = Console.ReadLine().ToLower().Trim();


    if (respuesta == "nuevo vehiculo")
    {
        cantidadVehiculos++;
       
        Console.WriteLine("Perfecto! ¿Que tipo de vehículo? (Moto,Auto,Camión)");
        tipoVehiculo = Console.ReadLine().Trim().ToLower();


        switch(tipoVehiculo)
        {
            case "moto":
            costo = 5.00f;
            break;


            case "auto":
            costo = 10.00f;
            break;


            case "camion":
            Console.WriteLine("Cuantos ejes tiene el camión?");
            int.TryParse(Console.ReadLine().Trim(), out int ejes);
            costo = 15.00f * ejes;
            break;
        }


        hora = TimeOnly.FromDateTime(DateTime.Now);
        if((hora >= new TimeOnly(6,0) && hora <= new TimeOnly(9,0)) || (hora >= new TimeOnly(17,0) && hora <= new TimeOnly(20,0)))
        {
            Console.WriteLine("Debido a la hora pico,el costo aumentará un 20%");
            costo += (costo * 20)/100;
        }
        Console.WriteLine("Cuantos pasajeros tiene el vehículo?");
        pasajeros = Convert.ToInt32(Console.ReadLine().Trim());
        if(pasajeros > 3)
        {
            Console.WriteLine("Felicidades,debido a nuestro incentivo verde,se le garantiza un descuento del 50%");
            costo -= (costo*50)/100;
        }


        Console.WriteLine($"Costo total: {costo:C}");
        recaudo += costo;








    }
    else if(respuesta != "salir") Console.WriteLine("Comando inválido. Seleccione 'salir' o 'nuevo vehiculo'");




} while (respuesta != "salir");


Console.WriteLine($"El promedio de ganancia por vehículo fue: {recaudo / cantidadVehiculos:C}");
Console.WriteLine($"Y el recaudo {recaudo:C}");
