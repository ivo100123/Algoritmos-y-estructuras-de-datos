int edad;


Console.WriteLine("Inserte su edad");
int.TryParse(Console.ReadLine().Trim(),out edad);


mayorEdad(edad);


bool mayorEdad(int input)
{


    if(edad > 18)
    {
        Console.WriteLine("Usted es mayor de edad");
        return true;
    }


    else
    {
        Console.WriteLine("Usted NO es mayor de edad");
        return false;
    }
   
};
