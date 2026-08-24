# Algoritmos-y-estructuras-de-datos

1. ¿Qué valor devuelve ReadLine() cuando alcanza el final del archivo?
○
Respuesta: Como no hay nada para devolver,da null

3. ¿Qué sucede si instancias new StreamWriter("datos.txt", false)?
○ Respuesta: Se crea un archivo o se sobreescribe con la nueva informacion

5. ¿Cuál es la ventaja de la sentencia using (StreamReader sr = ...) en lugar de abrir y
cerrar manualmente el archivo?
○ Respuesta: Garantiza que se invoque el método Dispose() y se liberen los recursos del
sistema de forma automática al salir del bloque, incluso si ocurre una excepción.

7. ¿Qué diferencia hay entre Read() y Peek() en StreamReader?
○ Respuesta: Read() lee el siguiente carácter y avanza la posición del puntero. Peek() lee el
siguiente carácter sin hacer avanzar la posición.
