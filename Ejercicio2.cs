/*
Objetivo: Implementar la lectura estructurada de un archivo manejando posibles errores de
E/S (archivos inexistentes) mediante try-catch-finally.
Consigna
1. Solicita al usuario el nombre o la ruta de un archivo de texto.
2. Abre el archivo con StreamReader dentro de un bloque try-catch-finally.
3. Lee y muestra cada línea en la consola numerando cada renglón (ejemplo: 1: Hola, 2:
Mundo).
4. Asegúrate de cerrar el flujo en la sección finally.
*/
Console.WriteLine("Inserte su archivo");
string ruta = Console.ReadLine();

try 
{
    StreamReader archivo = new StreamReader(ruta);
    string parrafo = archivo.ReadLine();
    int numeroParrafo = 1;

    while(numeroParrafo != null) 
    {
        Console.WriteLine($"Numero parrafo {numeroParrafo}: {parrafo}");
        parrafo = archivo.ReadLine();
        numeroParrafo++;

    }

}
catch (FileNotFoundException) 
{
    Console.WriteLine("Archivo inexistente");
}
