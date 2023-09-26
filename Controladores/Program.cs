using CajeroMenu.Servicios;

namespace CajeroMenu.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 250923 - rfg
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 - rfg
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {

            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mostrarMensajeBienvenida();

            //Variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSeleccionada;

            //desde la primera iteracion debe cumplirse la condicion
            while(!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 0");
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna");
                        break;
                }

            }

        }


    }

}

