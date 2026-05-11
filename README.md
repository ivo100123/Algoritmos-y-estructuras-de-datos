# TP1
Consignas:

Parte 1: Estructuras Selectivas y Condicionales (Nivel Medio-Avanzado)
Aquí no solo evaluamos un "si" o "no", sino rangos, estados y lógica booleana compleja.
1. Validador de Triángulos y Tipo: Solicita tres longitudes. Determina si forman un triángulo
válido y, de ser así, clasifícalo (equilátero, isósceles, escaleno) y di si es rectángulo usando
el teorema de Pitágoras (a^2 + b^2 = c^2)

2. Calculadora de Impuesto Progresivo: Crea un sistema donde el usuario ingresa su sueldo
anual. Aplica deducciones automáticas (ej. 10% fijo) y luego calcula el impuesto basado en
4 niveles de brackets (ej. 0-10k: 0%, 10k-30k: 15%, etc.).
3. Simulador de Cuadrante Geométrico: Dado un punto (x, y), indica en qué cuadrante del
plano cartesiano se encuentra o si está sobre un eje o en el origen.
4. Sistema de Clasificación de Calidad de Aire (AQI): Basado en un valor entero, devuelve
la categoría (Buena, Moderada, Dañina, etc.) y la recomendación de salud correspondiente
usando un switch moderno de C#.
5. Validador de Año Bisiesto Completo: Un algoritmo que verifique si un año es bisiesto
siguiendo todas las reglas (divisible por 4, no por 100, a menos que sea divisible por 400).
Parte 2: Estructuras Repetitivas (Ciclos Complejos)
El reto aquí es optimizar las iteraciones y manejar acumuladores sin usar estructuras de
almacenamiento de datos.
2. Sucesión de Fibonacci Limitada: Genera los números de Fibonacci pero detente justo
antes de superar un número N ingresado por el usuario.
3. Verificador de Números Primos y Primos Gemelos: Determina si un número es primo. Si
lo es, indica cuál es su primo gemelo más cercano (un primo que difiere en 2).
4. Descomposición en Factores Primos: Dado un número, imprime su descomposición (ej.
para 12: 2 * 2 * 3).
5. Conversor de Decimal a Binario: Transforma un número entero a binario usando
únicamente ciclos y operaciones matemáticas (divisiones y residuos), imprimiendo el
resultado correctamente.
6. El Juego de la Conjetura de Collatz: Dado un número n, si es par se divide entre 2; si es
impar, se multiplica por 3 y se suma 1. Repite hasta llegar a 1, contando cuántos pasos
tomó.
7. Cálculo de Raíz Cuadrada (Método de Newton): Implementa el algoritmo de
Newton-Raphson para hallar la raíz cuadrada de un número con una precisión de 0.0001 sin
usar Math.Sqrt.

8. Dibujo de Patrones Geométricos: Solicita un número N y dibuja un rombo hueco hecho
de asteriscos de ancho 2N-1
Parte 3: Retos de Aplicación Real (Proyectos)
Estos ejercicios integran condicionales anidados, ciclos de control y validación de datos.
14. Sistema de Control de Peaje Inteligente
Problemática: Una autopista necesita automatizar el cobro según el tipo de vehículo, la hora
del día y la carga de pasajeros.
• Reglas:
• Motos: $5.00.
• Autos: $10.00 base.
• Camiones: $15.00 por eje.
• Condicionales de "Hora Pico": Si la hora está entre las 06:00-09:00 o 17:00-20:00, el costo
aumenta un 20%.
• Incentivo Verde: Si es un auto y lleva 3 o más pasajeros, recibe un 50% de descuento en
el total.
• El Reto: El programa debe ejecutarse continuamente procesando vehículos hasta que el
operador ingrese un código de cierre, momento en el cual debe mostrar el total recaudado y
el promedio de cobro por vehículo.
15. Motor de Simulación de Crédito Bancario
Problemática: Un banco desea filtrar solicitudes de crédito antes de que lleguen a un agente
humano.
• Lógica de Entrada: El usuario ingresa edad, ingresos mensuales, puntaje crediticio
(0-1000) y monto solicitado.
• Reglas de Negocio:
• Rechazo automático si la edad es menor a 18 o mayor a 75.
• Si el puntaje es > 800, el interés es del 5% anual. Entre 600 y 800 es del 12%. Menos de
600 requiere un aval (pedir confirmación por consola).
• La cuota mensual (Monto + Interés / Plazo) no puede superar el 30% del ingreso mensual
del cliente.
• El Reto: Usa un ciclo para permitir al cliente ajustar el número de cuotas (plazo) hasta que
la cuota mensual sea "Apt para su sueldo" o decida cancelar la solicitud. Al final, imprime
una tabla de amortización simple (Mes | Pago | Saldo Restante) solo con ciclos.
