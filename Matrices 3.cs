/*Una empresa de logística analiza el rendimiento de su flota de vehículos. Para ello,
dispone de una matriz de enteros donde cada fila representa a un vehículo y cada
columna representa la cantidad de entregas realizadas en diferentes días de la semana.
También se dispone de un arreglo de enteros que representa el "valor de ganancia o peso"
asignado a cada día de la semana correspondientemente. Crear los siguientes 3 metodos:
1. calcularGananciaTotalPorVehiculo
Este método calcularía la ganancia total de un vehículo específico (una fila de la
matriz) multiplicando las entregas de cada día por el "peso" o ganancia de ese día, y
sumando los resultados.
● ¿Para qué sirve? Te permite saber cuánto dinero o valor generó un
camión/auto en particular a lo largo de la semana.
● Logística interna: Es un producto punto (multiplicar e ir sumando) entre la fila
de la matriz y el arreglo de ganancias.*/

int[,] matriz =
{// Autos|Pedidos
    {1,     5,2,4,2,1,4,5},
    {2,     5,8,4,5,2,5,1},
    {3,     8,5,3,8,2,7,2}
};

int[] valor = [1000,2000,3000,2000,5000,1000,6000];

calcularGananciaTotalPorVehiculo(matriz);

void calcularGananciaTotalPorVehiculo(int[,] matriz) 
{

    int resul = 0;

    Console.WriteLine("Qué vehiculo quiere calcular? (0 - 2)");
    int.TryParse(Console.ReadLine().Trim(), out int vehiculo);

    for(int i = 0; i < matriz.GetLength(1); i++)
    {
        foreach(int componente in valor) 
        {
            resul += (matriz[vehiculo, i] * componente);
        }
    }

    Console.WriteLine($"En la semana,el vehiculo {vehiculo} generó ${resul}");

}
