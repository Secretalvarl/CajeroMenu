using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{
    /// <summary>
    /// Interfaz con la relacion de metodos de la funcionalidad Menú
    /// 250923 - rfg
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestar el mensaje de Bienvenida al cajero.
        /// 250923 - rfg
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// metodo que muestra el menu y reoge la seleccion del usuario
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>returns>
        public int mostrarMenuYSeleccion();
    }
}
