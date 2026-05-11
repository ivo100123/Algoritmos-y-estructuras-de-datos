Console.WriteLine("Ingrese su numero");
int.TryParse(Console.ReadLine().Trim(),out int input)


int ContarDigitos(int n)
{
  
  	 if (n < 10) 
   	    return 1;

  	return 1 + ContarDigitos(n / 10);
}
