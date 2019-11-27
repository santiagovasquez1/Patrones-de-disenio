using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Flyweight
{
    /// <summary>
    /// Interfaz necesaria para la implementacion de objetos compartidos
    /// </summary>

    interface IFlyweight 
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenerNombre();
    }
}
