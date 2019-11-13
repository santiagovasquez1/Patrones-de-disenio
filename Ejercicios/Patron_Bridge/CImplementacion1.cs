using System;
using System.Collections.Generic;

namespace Patron_Bridge
{
    internal class CImplementacion1 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)
                Console.WriteLine(p.Key);
        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double cantidad = 0;

            foreach (KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;
                cantidad++;
            }

            Console.WriteLine("El total de {0} productos es ${1}", cantidad, total);
        }
    }
}