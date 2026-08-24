/*Objetivo: Trabajar con diferentes métodos de lectura de StreamReader (ReadToEnd y Peek).
Consigna
1. Crea un programa que lea el archivo diario.txt generado en el Ejercicio 1.
2. Utiliza sr.Peek() para comprobar si el archivo tiene contenido antes de comenzar a leer.
3. Utiliza sr.ReadToEnd() para obtener todo el contenido en un solo string.
4. Muestra en consola:
○ Todo el contenido del archivo.
○ La cantidad total de caracteres.
○ La cantidad total de palabras.*/

if (File.Exists("Diario.txt"))
{

    using (StreamReader archivo = new StreamReader("Diario.txt"))
    {
    
        if (archivo.Peek() >= 0)
        {
            string archivoEntero = archivo.ReadToEnd();
            Console.WriteLine("Archivo entero:");
            Console.WriteLine(archivoEntero);
            int caracteres = archivoEntero.Length;
    
            string[] palabras = archivoEntero.Split(
            new char[] { ' ', '\r', '\n' },
            StringSplitOptions.RemoveEmptyEntries
            );
            Console.WriteLine($"Total de caracteres: {caracteres}");
            Console.WriteLine($"Total de palabras: {palabras.Length}");
        }
        else
        {
            Console.WriteLine("El archivo está vacío.");
        }
    }
}
else Console.WriteLine("Archivo inexistente");
