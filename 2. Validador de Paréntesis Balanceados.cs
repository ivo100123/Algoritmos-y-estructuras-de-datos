//2. Validador de Paréntesis Balanceados 
//Enunciado: Crea una función que reciba una cadena de texto que representa una expresión matemática
//(por ejemplo: ((a + b) * (c - d))). El programa debe determinar
//si los paréntesis están correctamente balanceados usando una pila.

Console.WriteLine("Inserte su expresión matemática");
string input = Console.ReadLine().ToLower();

if (comparacionParentesis(input) == true) Console.WriteLine("Parentesis equilibrados");
else Console.WriteLine("Parentesis no equilibrados");

    bool comparacionParentesis(string input)
    {
        Stack<char> signos = new Stack<char>();

        char[] expresion = input.ToCharArray();

        foreach (char componente in expresion)
        {
            if (componente == '(') signos.Push(componente);
            if (componente == ')')
            {
                if (signos.TryPop(out _) == false) return false;
            }
        }

        if (signos.Count > 0) return false;
        else return true;
    }
