int[] nums1 = {1,2,3,4,5,6,7,8,9,10};
int[] nums2 = {11,12,13,14,15,16,17,18,19,20};

Console.WriteLine("Arreglo 1:");
foreach(int num in nums1)
{
    Console.Write(num + " ");
}

Console.WriteLine("\nArreglo 2:");
foreach(int num in nums2)
{
    Console.Write(num + " ");
}

Console.WriteLine("\nResultado:");
foreach(int num in mezclarArreglos(nums1,nums2))
{
    Console.Write(num + " ");
}

int[] mezclarArreglos(int[] arreglo1, int[] arreglo2)
{
    int[] resultado = new int[10];

    for(int i = 0; i < arreglo1.Length; i++)
    {
        if(arreglo2[i] % 2 == 0) resultado[i] = arreglo2[i];
        else resultado[i] = arreglo1[i];
    }
    return resultado;
    
}
