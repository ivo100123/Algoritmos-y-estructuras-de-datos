int numero1;
int numero2;
int numero3;


Console.WriteLine("Ingrese su primer número");
int.TryParse(Console.ReadLine().Trim,out numero1);


Console.WriteLine("Ingrese su segundo número");
int.TryParse(Console.ReadLine().Trim,out numero2);


Console.WriteLine("Ingrese su tercer número");
int.TryParse(Console.ReadLine().Trim,out numero3);


Console.WriteLine("El mayor de sus números es " + ObtenerMaximo(numero1,numero2,numero3));


int ObtenerMaximo(int num1,int num2,int num3)
{
    if (num1 > num2 && num1 > num3) return num1;
    else if (num2 > num1 && num2 > num3) return num2;
    else if (num3 > num1 && num3 > num2) return num3;
    else
    {
        Console.WriteLine("Error. Sus tres números son iguales");
        return 0;
    }
}
