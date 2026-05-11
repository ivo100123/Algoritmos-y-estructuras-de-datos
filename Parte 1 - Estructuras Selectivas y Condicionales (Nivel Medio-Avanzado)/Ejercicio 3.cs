int coordenadaX;
int coordenadaY;


Console.WriteLine("Ingrese su coordenada X");
coordenadaX = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese su coordenada Y");
coordenadaY = int.Parse(Console.ReadLine());


if (coordenadaX > 0 && coordenadaY > 0) Console.WriteLine("Su punto está en el cuadrante 2,arriba a la derecha");
if (coordenadaX < 0 && coordenadaY > 0) Console.WriteLine("Su punto está en el cuadrante 1,arriba a la izquierda");
if (coordenadaX < 0 && coordenadaY < 0) Console.WriteLine("Su punto está en el cuadrante 3,abajo a la izquierda");
if (coordenadaX > 0 && coordenadaY < 0) Console.WriteLine("Su punto está en el cuadrante 4,abajo a la derecha");
if (coordenadaX == 0 && coordenadaY == 0) Console.WriteLine("Su punto está en la ordenada de origen.");
if (coordenadaX == 0 && coordenadaY > 0) Console.WriteLine("Su punto está en el eje Y,por encima de la ordenada");
if (coordenadaX == 0 && coordenadaY < 0) Console.WriteLine("Su punto está en el eje Y,por debajo de la ordenada");
if (coordenadaX > 0 && coordenadaY == 0) Console.WriteLine("Su punto está en el eje X,a la derecha de la ordenada");
if (coordenadaX < 0 && coordenadaY == 0) Console.WriteLine("Su punto está en el eje X,a la izquierda de la ordenada");
