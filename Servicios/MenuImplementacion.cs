﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menú
    /// 250923 -rfg
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            String mensaje = "Banco de CSI1";
            Console.WriteLine(mensaje);

        }
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("################");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }

            
    }
}
