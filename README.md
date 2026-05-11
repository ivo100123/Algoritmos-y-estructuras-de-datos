# Algoritmos-y-estructuras-de-datos
### **1. El Contador de Dígitos (Recursividad Pura)**

En lugar de usar un arreglo, vamos a descomponer un número entero.
• **El Reto:** Crea una función recursiva `ContarDigitos(int n)` que devuelva cuántos dígitos tiene un número.
• **Pista Matemática:** Si divides un entero entre 10 en C# (ej. `125 / 10`), el resultado es `12`. Has "eliminado" un dígito.
• **Caso Base:** Cuando el número es menor a 10, solo tiene 1 dígito.
• **Caso Recursivo:** `1 + ContarDigitos(n / 10)`.

### **2. La Potencia Segura (Recursividad + Excepciones)**

****Vamos a calcular a^b (a elevado a la b) pero protegiendo el programa de entradas inválidas.
• **El Reto:** 1.  Escribe el método recursivo `CalcularPotencia(int base, int exponente)`.
2.  **Caso Base:** Si `exponente == 0`, retorna 1.
3.  **Manejo de Errores:** En el `Main`, usa un bloque `try-catch` para capturar si el usuario ingresa letras en lugar de números (`FormatException`).
4.  **Validación Manual:** Si el usuario ingresa un exponente negativo, lanza una `Exception` con el mensaje: "Esta función no soporta exponentes negativos".

### **3. Inversión de Números (Lógica de Retorno)**

****Este ejercicio ayuda a entender cómo la recursividad "espera" a que las llamadas hijas terminen.
• **El Reto:** Imprimir un número al revés (ej: entras `1234`, sale `4321`) sin usar `string.Reverse()` ni arreglos.
• **Lógica:** 1.  Imprime el último dígito usando el operador residuo: `Console.Write(n % 10)`.
2.  Llama a la función de nuevo con `n / 10`.
3.  **Caso Base:** Cuando `n < 10`, imprimes el número y terminas.
