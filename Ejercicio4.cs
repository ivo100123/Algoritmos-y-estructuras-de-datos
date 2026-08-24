/*Objetivo: Practicar el uso de iteraciones para escribir datos continuos sin salto de línea (Write)
y el uso de codificaciones de texto especificadas en los constructores.
Consigna
1. Usa StreamWriter especificando la codificación Encoding.UTF8 para crear el archivo
tabla_multiplicar.txt.
2. Utiliza un bucle para escribir la tabla de multiplicar del 7 (del 1 al 10).
3. Utiliza Write() en lugar de WriteLine() para generar una fila de números separados por
guiones en una misma línea y WriteLine() solo para separar secciones.*/

using System.Text;


try
{
   
    using (StreamWriter archivo = new StreamWriter("tabla.txt", false, Encoding.UTF8))
    {
        for (int i = 1; i <= 10; i++)
        {
            
            int resultado = 7 * i;
            archivo.Write($"{resultado}");
            if (i < 10)
            {
                archivo.Write(" - ");

            }
        }

        for (int i = 1; i <= 10; i++)
        {
            archivo.WriteLine($"7 x {i} = {7 * i}");
        }
    }
    Console.WriteLine($"Tabla guardada en tabla.txt");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
}
