# Algoritmos-y-estructuras-de-datos
1-Definiciones.
¿Qué es una matriz en el contexto de la programación y las matemáticas?
Un conjunto de datos almacenado en un array bidimensional

1.1-¿Cómo se representa una matriz de dos dimensiones en un lenguaje de programación (por
ejemplo, Python, Java, C++)? Explica las estructuras de datos comunes utilizadas.
En C# se representan como:
matriz[numeroFilas,numeroColumnas] para matrices con igual cantidad de filas que de columnas o bien matriz[numeroFilas][numeroColumnas] para matrices desiguales

1.2-¿Qué son las dimensiones de una matriz? Si tienes una matriz A con m filas y n
columnas, ¿cómo se denota su tamaño?
Son la cantidad de espacios que tiene para almacenar elementos. Su tamaño se denota como mxn.

1.3-Principales diferencias entre matrices y vectores (cuadro,)

Una matriz es un arreglo bidimensional para almacenar valores. Un vector es una flecha que indica movimiento o espacio.

2- Elementos y posiciones de una matriz.
¿Cómo se accede a un elemento específico dentro de una matriz? Si una matriz se llama M, ¿cómo se representa la posición de un elemento en la fila i y columna j?
Se accede con el comando M[i,j] o M[i][j]

2.1-¿Es importante el orden de los índices (fila, columna) al acceder a un elemento? Explica
por qué.
Sí,porque las matrices tienen un solo lugar para cada 
valor,y si se rompe el orden,se puede omitir o perder un valor.

3- Tipos de matrices. Define qué es una matriz cuadrada.
Matriz cuadrada: Es aquella que tiene el mismo número de filas que de columnas m = n.
matriz nula,matriz fila,matriz columna.

3.1-¿Qué es una matriz fila y una matriz columna?
Matriz fila: Es una matriz que tiene una sola fila y cualquier número de columnas n.
Matriz columna: Es una matriz que tiene una sola columna y cualquier número de filas m.

3.2-¿Qué es una matriz nula?
Es aquella donde todos y cada uno de sus elementos son iguales a 0 sin importar sus dimensiones.

4- Operaciones básicas: Suma
¿Cuál es la condición fundamental para poder sumar o restar dos matrices?
Que tengan el mismo tamaño

4.1-Si tienes dos matrices A y B del mismo tamaño, ¿cómo se realiza la operación de suma A
+ B? Describe el proceso a nivel de elementos.
  Se suma elemento por elemento. Elemento[1,1] + Elemento[1,1] de la otra matriz.
  
5- Operaciones básicas: Multiplicación
¿Cuál es la condición fundamental para poder multiplicar dos matrices A y B (es decir,
calcular A * B)?
el número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz.

5.1-Si la matriz A es de tamaño m×n y la matriz B es de tamaño p×q, ¿cuáles deben ser los
valores de n y p para que la multiplicación sea posible? ¿Cuál será el tamaño de la matriz
resultante C?

Los valores deben cumplir que n = p para que la multiplicación sea posible.
La matriz resultante C tendrá un tamaño de m (las filas de la primera y las columnas de la segunda).

5.2-Explica conceptualmente cómo se calcula un elemento C[i][j] de la matriz producto.
Se obtiene mediante el producto punto entre la fila i de la matriz A y la columna j de la matriz B.
Se multiplica el primer elemento de la fila i por el primer elemento de la columna j, 
luego el segundo por el segundo, el tercero por el tercero, y finalmente se suman todos esos resultados intermedios.

6- Otros
¿Es posible realizar el videojuego ‘Tetris’ utilizando matrices? Justifique su respuesta.
Sí,porque Tetris es en esencia una cuadrícula al igual que una matriz.

-6.1-Qué tipos de datos puede almacenar una matriz?
Cualquiera,pero tienen que ser todos del mismo tipo.
