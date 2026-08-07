//Enunciado: Escribe un programa que pida al usuario una cadena de texto (una palabra o frase)
//y utilice una pila para invertirla. El programa debe meter cada carácter en la pila y
//luego sacarlos uno a uno para construir la cadena invertida.

Stack<char> palabra = new Stack<char>();
string respuesta = "";

Console.WriteLine("Inserte frase a invertir");
string input = Console.ReadLine().Trim().ToLower();

char[] letras = input.ToCharArray();

foreach(char letra in letras) 
{
    palabra.Push(letra);
}

while (palabra.Count > 0)
{ 
    respuesta += palabra.Pop();                          
}

Console.WriteLine(respuesta);
