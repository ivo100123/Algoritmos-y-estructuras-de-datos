//2.Enunciado: Simula
//el comportamiento de los botones "Ir a página" y "Atrás" de un navegador web.
//El usuario puede escribir una URL para visitarla, o escribir la palabra "atras" para regresar a la página anterior.
//Usa una pila para almacenar el historial de navegación de modo que el comando "atras" te devuelva siempre la última página visitada.

string input = "";

Stack<string> linkAnterior = new Stack<string>();

while (input != "salir")
{
    Console.WriteLine("Inserte link o atras o salir");
    input = Console.ReadLine().Trim().ToLower();

    switch (input) 
    {
        case "atras":
            Console.WriteLine(linkAnterior.Peek());
            break;

        case "salir":
        break;

        default:
            linkAnterior.Push(input);
        break;
    }

}
