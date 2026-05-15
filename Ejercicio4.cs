double[] array = {5,7,8,4,3,2,6,9}; //pq no tengo creatividad para hacer numeros nuevos :)

 foreach(double numero in array)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();


 foreach(double numero in multiplicarPorPi(array))
        {
            Console.Write(numero + " ");
        }


double[] multiplicarPorPi(double[] nums)
{
    double[] resultado = new double[nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
     resultado[i] = nums[i] * 3.14;
    }

    return resultado;
    
}
