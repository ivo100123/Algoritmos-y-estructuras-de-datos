int[] array = {5,7,8,4,3,2,6,9};

foreach(int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();

foreach(int num in reverso(array))
{
    Console.Write(num + " ");
}

int[] reverso(int[] nums)
{
    int[] resultado = new int[nums.Length];
    
    for(int i = 0; i < nums.Length; i++)
    {
        resultado[i] = nums[nums.Length - (i + 1)];

    } //N - (i + 1)

    return resultado;
}
