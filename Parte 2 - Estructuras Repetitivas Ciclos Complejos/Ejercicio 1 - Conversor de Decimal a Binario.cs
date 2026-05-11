Console.WriteLine("Ingrese un número");
int.TryParse(Console.ReadLine().Trim(),out int input);


string binario = " ";


while (input > 0)
{
    int residuo = input % 2;
    binario = residuo + binario;
    input = input / 2;
}


Console.WriteLine(binario);
