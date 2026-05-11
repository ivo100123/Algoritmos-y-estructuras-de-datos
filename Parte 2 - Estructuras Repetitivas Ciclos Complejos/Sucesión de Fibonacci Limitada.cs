int numero1 = 0;
int numero2 = 1;
int numeroTemporal = 0;
int respuesta = 0;


do{
Console.WriteLine("Ingrese el número en el que detenerse");
respuesta = Convert.ToInt32(Console.ReadLine().Trim());
}while(respuesta == 0);


while(numero1 < respuesta)
{
    Console.WriteLine(numero1);
    numeroTemporal = numero1;
    numero1 = numero1 + numero2;  
    numero2 = numeroTemporal;  


}
