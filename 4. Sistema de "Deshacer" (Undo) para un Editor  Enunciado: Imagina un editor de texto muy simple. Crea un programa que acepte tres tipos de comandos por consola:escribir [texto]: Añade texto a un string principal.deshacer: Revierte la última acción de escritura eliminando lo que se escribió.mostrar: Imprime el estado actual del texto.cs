//4. Sistema de "Deshacer" (Undo) para un Editor 
//Enunciado: Imagina un editor de texto muy simple.
//Crea un programa que acepte tres tipos de comandos por consola:escribir[texto]: Añade texto a un string principal.
//deshacer: Revierte la última acción de escritura eliminando lo que se escribió.mostrar: Imprime el estado actual del texto.

string input = "";
string texto = "";
Stack<string> historial = new Stack<string>();

while(input != "salir") 
{
    Console.WriteLine("Insertar comando: escribir[texto] / deshacer / mostrar / salir");
    input = Console.ReadLine().Trim().ToLower();

    if (input.Contains("escribir[")) escribir();
    else if (input == "deshacer") deshacer();
    else if (input == "mostrar") mostrar();
    else if (input == "salir") break;
    else Console.WriteLine("Comando erroneo.");

}



void escribir() 
{
    historial.Push(texto);

    int posicionInicial = 0;
    int posicionFinal = 0;

    char[] caracteres = input.ToCharArray();

    for(int i = 0; i < caracteres.Length; i++) 
    {
        if (caracteres[i] == '[') {  posicionInicial = i + 1; }
        if (caracteres[i] == ']') {  posicionFinal = i - 1; }
    }

    for (int i = posicionInicial; i < posicionFinal; i++) 
    {
        texto += caracteres[i];
    }

}
void deshacer()
{
    texto = historial.Peek();
    historial.Pop();
    Console.WriteLine("Cambio deshecho");
}

void mostrar()
{
    Console.WriteLine(texto);
}
