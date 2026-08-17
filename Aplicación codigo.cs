namespace TiendaVideojuegos
{


    public struct videojuego //Definimos structs videojuego,que contiene todos los datos de todos los juegos
    {
        public int idVideojuego;
        public string tituloVideojuego;
        public double precioVideojuego;
        public int stockVideojuego;

        
        public videojuego(int id, string titulo, double precio, int stock)
        {
            idVideojuego = id;
            tituloVideojuego = titulo;
            precioVideojuego = precio;
            stockVideojuego = stock;
        }
    }

    public struct cliente //cliente contiene los datos de todos los clientes
    {
        public int idCliente;
        public string nombreCliente;
        public int juegoDeseado;

        public cliente(int id, string nombre, int IDjuegoDeseado)
        {
            idCliente = id;
            nombreCliente = nombre;
            juegoDeseado = IDjuegoDeseado;
        }
    }

 
    public class inventario //La clase inventario trabaja con todos los datos del sistema
    {
        public static int limite = 10; //cantidad máxima de juegos
        public static videojuego[] catalogo = new videojuego[limite];
        public static int cantidadJuegosActual = 0;

        public static int[,] gondolas = new int[3, 3]; //Filas = Pasillos, columnas = Estantes,por eso son solo 3

        public static void mostrarJuegos()
        {

            //Si hay juegos,cicla a traves de todos,imprimiendo ID,titulo
            if(cantidadJuegosActual > 0)
            {
                for (int i = 0; i < cantidadJuegosActual; i++) 
                {
                Console.WriteLine($"ID: {catalogo[i].idVideojuego}  Titulo: {catalogo[i].tituloVideojuego}  Precio: ${catalogo[i].precioVideojuego}  Stock: {catalogo[i].stockVideojuego}");
                }
            }
            else Console.WriteLine("No hay juegos"); //Si no,avisa al usuario

    
        }

        public static void buscarID()
        {
            bool encontrado = false;


            Console.Write("\nIngrese el ID del juego a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int idBuscado)) //Revisa si el usuario puso un numero valido
            {
                for (int i = 0; i < cantidadJuegosActual; i++) //Si es valido,cicla buscando el ID
                {
                    if (catalogo[i].idVideojuego == idBuscado)
                    {
                        encontrado = true;

                        //Si lo encuentra,da toda la informacion de ese juego
                        Console.WriteLine($"ID: {catalogo[i].idVideojuego} Título: {catalogo[i].tituloVideojuego}  Precio: ${catalogo[i].precioVideojuego}  Stock: {catalogo[i].stockVideojuego}");
                    }
                }
            }
            //Si el ciclo termino y no se encontro,se avisa al usuario
          if(encontrado == false)  Console.WriteLine("No se encontró el ID");
        }

        public static void buscarNombre()
        {
            bool encontrado = false;

            Console.Write("\nIngrese el título del juego a buscar: ");
            string nombreBuscado = Console.ReadLine() ?? ""; //Si el usuario deja vacio el titulo,se busca "",que no existe

            for (int i = 0; i < cantidadJuegosActual; i++) //Cicla buscando el titulo
            {
                if (catalogo[i].tituloVideojuego.ToLower() == nombreBuscado.ToLower())
                {
                    encontrado = true;
                    //Si se encuentra,se da toda la informacion del juego
                    Console.WriteLine($"ID: {catalogo[i].idVideojuego}  Título: {catalogo[i].tituloVideojuego}  Precio: ${catalogo[i].precioVideojuego}  Stock: {catalogo[i].stockVideojuego}\n");
                }
            }
            //Si no,se avisa al usuario
           if(encontrado == false) Console.WriteLine("No se encontró el titulo");

        }

        public static void mostrarGondolas() //Usa la matriz para mostrar la ubicacion de los juegos
        {
            Console.Write("       ");
            for (int col = 0; col < gondolas.GetLength(1); col++)
            {
                Console.Write($"Estante {col + 1}  ");
            }
            Console.WriteLine();

            for (int fila = 0; fila < gondolas.GetLength(0); fila++)
            {
                Console.Write($"Pasillo {fila + 1}: ");
                for (int col = 0; col < gondolas.GetLength(1); col++)
                {
                    Console.Write($"  [ID: {gondolas[fila, col]}]   ");
                }
                Console.WriteLine();
            }
        }

        public static void consultarGondola()
        {

            bool encontrado = false;

            Console.Write("\nIngrese número de Pasillo (Fila 0-2): "); //Se pide una ubicacion
            int.TryParse(Console.ReadLine(), out int fila);
            Console.Write("Ingrese número de Estante (Columna 0-2): ");
            int.TryParse(Console.ReadLine(), out int col);

            if (fila >= 0 && fila < gondolas.GetLength(0) && col >= 0 && col < gondolas.GetLength(1)) //Se revisa si es una ubicacion valida
            {
                int idJuego = gondolas[fila, col]; //Se busca la ID del juego con un for
                if (idJuego != 0)
                {
                    for (int i = 0; i < cantidadJuegosActual; i++)
                    {
                        if (catalogo[i].idVideojuego == idJuego)
                        { //Si se encuentra,se avisa al usuario cual juego esta ahi
                            encontrado = true;
                            
                            Console.WriteLine($"En el Pasillo {fila}, Estante {col} esta: {catalogo[i].tituloVideojuego} (ID: {idJuego})");

                        }
                    }
                } //Si esta vacio o es una ubicacion invalida,se avisa al usuario
              if(encontrado == false)  Console.WriteLine($"El estante {col} del pasillo {fila} esta vacio");
           
            }
            Console.WriteLine("Ubicación fuera de rango.");
         
        }

        public static void agregarJuegos()
        {
            if (cantidadJuegosActual >= limite) //Si se llego al limite,se cancela
            {
                Console.WriteLine("\nCantidad máxima de juegos alcanzada");
                return;
            }

            Console.Write("Ingrese ID del juego: "); //Se asigna un nuevo ID unico
            int.TryParse(Console.ReadLine(), out int idNuevo);

            for (int i = 0; i < cantidadJuegosActual; i++)
            {
                if (catalogo[i].idVideojuego == idNuevo)
                {
                    Console.WriteLine("Ya existe un juego con ese ID");
                    return;
                }
            }

            Console.Write("Ingrese Título: ");
            string tituloNuevo = Console.ReadLine() ?? "Juego sin titulo"; // "??" = Si el usuario no pone nada,pone "juego sin titulo"

            Console.Write("Ingrese Precio: ");
            double.TryParse(Console.ReadLine(), out double precioNuevo);

            Console.Write("Ingrese Stock inicial: ");
            int.TryParse(Console.ReadLine(), out int stockNuevo);

            catalogo[cantidadJuegosActual] = new videojuego(idNuevo, tituloNuevo, precioNuevo, stockNuevo);
            cantidadJuegosActual++; //Se agrega al catalogo

            Console.WriteLine($"\n Juego {tituloNuevo} agregado");
        }
    }

//Clientes
    public class clientes //La clase clientes trabaja con todos los datos de clientes
    {
        public static Queue<cliente> filaClientes = new Queue<cliente>(); //Creamos la fila
        private static int posicionCliente = 1;

        public static void nuevoCliente()
        {
            //Si el usuario no pone nada,se pone como nombre Cliente desconocido
            Console.Write("Ingrese nombre del cliente: ");
            string nombreCliente = Console.ReadLine() ?? "Cliente desconocido";

            Console.Write("Ingrese el ID del juego que desea comprar: ");
            int.TryParse(Console.ReadLine(), out int idJuegoDeseado);

            cliente nuevoCliente = new cliente(posicionCliente++, nombreCliente, idJuegoDeseado);
            filaClientes.Enqueue(nuevoCliente); //Se agrega a la cola

            Console.WriteLine($"\n Cliente {nombreCliente} se ingresó a la cola");
        }

        public static void mostrarCola()
        {
            if (filaClientes.Count == 0) //Si no hay clientes,se avisa al cliente
            {
                Console.WriteLine("No hay clientes en la cola");
                return;
            }

            //Si hay clientes,se avisa cuantos,quien es el proximo,y los datos de todos
            Console.WriteLine($"Hay {filaClientes.Count} en la fila");
            Console.WriteLine($"Próximo en ser atendido: {filaClientes.Peek().nombreCliente} (ID Cliente: {filaClientes.Peek().idCliente})");

            int posicion = 1;
            foreach (var cliente in filaClientes)
            {
                Console.WriteLine($"  {posicion} ID: {cliente.idCliente}  Nombre: {cliente.nombreCliente}  ID Juego Deseado: {cliente.juegoDeseado}");
                posicion++;
            }
        }

        public static void atenderCliente()
        {
            if (filaClientes.Count == 0) //Si no hay clientes,se avisa al usuario
            {
                Console.WriteLine("No hay clientes");
                return;
            }

            //Si hay un cliente,se lo quita de la cola
            cliente clienteActual = filaClientes.Dequeue();

            //Se busca el juego deseado con un for
            bool juegoEncontrado = false;
            for (int i = 0; i < inventario.cantidadJuegosActual; i++)
            {
                if (inventario.catalogo[i].idVideojuego == clienteActual.juegoDeseado)
                {
                    juegoEncontrado = true;

                    //Si se encuentra,se revisa si hay stock
                    if (inventario.catalogo[i].stockVideojuego > 0)
                    {
                        //Si hay,se genera un ticket
                        inventario.catalogo[i].stockVideojuego--;
                        Console.WriteLine($"\nVENTA REALIZADA");
                        Console.WriteLine($"Producto: {inventario.catalogo[i].tituloVideojuego}");
                        Console.WriteLine($"Monto a cobrar: ${inventario.catalogo[i].precioVideojuego}");
                        Console.WriteLine($"Stock restante: {inventario.catalogo[i].stockVideojuego}");
                    }
                    else
                    {
                        //Si se encuentra pero no hay stock,se avisa al usuario
                        Console.WriteLine($"\nNo hay stock del juego");
                    }
                    break;
                }
            }

            //Si no se encuentra,se avisa al usuario
            if (juegoEncontrado == false)
            {
                Console.WriteLine($"\nNo se encontró el juego");
            }
        }
    }


    public class Program //La clase program es la que empieza el sistema
    {
        public static void cargarCatalogo()
        {
            //Aca se inicializan todos los datos
            inventario.catalogo[0] = new videojuego(1, "Hollow knight", 21.64, 5);
            inventario.catalogo[1] = new videojuego(2, "REPO", 43.34, 3);
            inventario.catalogo[2] = new videojuego(3, "Peak", 60.21, 2);
            inventario.catalogo[3] = new videojuego(4, "Elden ring", 59.42, 4);
            inventario.cantidadJuegosActual = 4;

            inventario.gondolas[0, 0] = 1;
            inventario.gondolas[0, 1] = 2;
            inventario.gondolas[1, 0] = 3;
            inventario.gondolas[1, 1] = 4;

        }

        public static void menuPrincipal()
        {

            //Mientras que el usuario no elija salir,imprime todas las opciones y lee 
            //la respuesta del usuario

            string input;
            do
            {
                Console.WriteLine("Menú principal");
                Console.WriteLine("1. Ver catálogo e inventario");
                Console.WriteLine("2. Buscar juego por ID");
                Console.WriteLine("3. Buscar juego por nombre");
                Console.WriteLine("4. Ver mapa de gondolas");
                Console.WriteLine("5. Consultar ubicación en gondola");
                Console.WriteLine("6. Agregar nuevo juego");
                Console.WriteLine("7. Registrar nuevo cliente en la cola");
                Console.WriteLine("8. Mostrar cola de clientes");
                Console.WriteLine("9. Atender proximo cliente");
                Console.WriteLine("10. Salir");
                
                input = Console.ReadLine() ?? "";

                switch (input)
                {
                    case "1":
                        inventario.mostrarJuegos();
                        break;
                    case "2":
                        inventario.buscarID();
                        break;
                    case "3":
                        inventario.buscarNombre();
                        break;
                    case "4":
                        inventario.mostrarGondolas();
                        break;
                    case "5":
                        inventario.consultarGondola();
                        break;
                    case "6":
                        inventario.agregarJuegos();
                        break;
                    case "7":
                        clientes.nuevoCliente();
                        break;
                    case "8":
                        clientes.mostrarCola();
                        break;
                    case "9":
                        clientes.atenderCliente();
                        break;
                    case "10":
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                        break;
                }

            } while (input != "10");
        }

        public static void Main() //El programa arranca cargando el catalogo inicial y
                                 // manda al usuario al menu principal
        {
            cargarCatalogo();
            menuPrincipal();
        }
    }
}
