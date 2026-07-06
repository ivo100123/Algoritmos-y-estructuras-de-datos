/*2. obtenerVehiculoMasEficiente
Este método recorrería toda la matriz, calcularía la ganancia total de cada vehículo
(apoyándose en el método anterior) y devolvería el índice del vehículo que obtuvo la
mayor ganancia o realizó más entregas.
● ¿Para qué sirve? Para identificar al "empleado o vehículo del mes". Es clave
para el análisis de rendimiento que pide el enunciado.
● Logística interna: Un bucle que recorre cada fila, compara los totales y guarda
el índice del mayor.*/

int[,] matriz =
{// Autos|Pedidos
    {1,     5,2,4,2,1,4,5},
    {2,     5,8,4,5,2,5,1},
    {3,     8,5,3,8,2,7,2}
};

int[] valor = [1000,2000,3000,2000,5000,1000,6000];

// calcularGananciaTotalPorVehiculo(matriz,0);

int calcularGananciaTotalPorVehiculo(int[,] matriz,int vehiculo) 
{

    int resul = 0;
    for(int i = 0; i < matriz.GetLength(1); i++)
    {
        foreach(int componente in valor) 
        {
            resul += (matriz[vehiculo, i] * componente);
        }
    }

    return resul;

}

void obtenerVehiculoMasEficiente(int[,] matriz) 
{
    int valorVehiculoMayor = 0;
    int pedidosVehiculoActual = 0;
    int pedidosVehiculoMayor = 0;

    

    for (int i = 0; i < matriz.GetLength(0); i++) 
    {
        for (int j = 0; j < matriz.GetLength(1); j++) 
        {

            pedidosVehiculoActual += matriz[i, j];

          int valorVehiculoActual = calcularGananciaTotalPorVehiculo(matriz, i);

           if (valorVehiculoActual > valorVehiculoMayor) valorVehiculoMayor = valorVehiculoActual;
        }
    }
}

