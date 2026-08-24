/*Ejercicio 1: Escritor de Notas Diario (Modo Sobrescribir vs. Modo
Añadir)
Objetivo: Comprender la diferencia entre crear un archivo desde cero y añadir contenido al
final (append).
Consigna
1. Crea un programa que le pida al usuario su nombre y su frase favorita.
2. Guarda estos datos en un archivo llamado diario.txt utilizando StreamWriter.
3. Vuelve a ejecutar el programa o añade un segundo bloque para agregar la fecha actual
al mismo archivo sin borrar lo anterior (append: true).*/

Console.WriteLine("Inserte su nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Inserte su frase favorita");
string frase = Console.ReadLine();

// Paso 1: Sobrescribir o crear el archivo (append = false)
using (StreamWriter archivo = new StreamWriter("Diario.txt")) 
{
    archivo.WriteLine("Usuario " +  nombre);
    archivo.WriteLine("Frase " + frase );
}

// Paso 2: Añadir datos al final (append = true)
using (StreamWriter archivo = new StreamWriter("Diario.txt",true))
{
    archivo.WriteLine("Usuario " + nombre);
    archivo.WriteLine("Frase " + frase);
}
