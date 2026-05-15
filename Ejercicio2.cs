int[] nums1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; 
int[] nums2 = [11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

foreach(int num in productoDeArreglos(nums1,nums2))
{
    Console.Write(num + " ");
}


int[] productoDeArreglos(int[] a, int[] b)
{
    int N = a.Length; 
    int[] c = new int[N]; 

    for (int i = 0; i < N; i++)
    {
        c[i] = a[i] * b[N - (i + 1)];
    }

    return c;
}
