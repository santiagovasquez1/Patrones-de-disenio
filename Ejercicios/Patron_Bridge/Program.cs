using System;
using System.Collections.Generic;

namespace Patron_Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();

            //Estos son los productos que vamos a usar
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 782.12);
            productos.Add("D549", 432.56);

            ////Creamos el bridge
            //CAbstraccion bridge = new CAbstraccion(new CImplementacion1(), productos);

            //bridge.MostrarTotales();
            //bridge.Listar();

            //Console.WriteLine("=======");

            //bridge = new CAbstraccion(new CImplementacion2(), productos);

            //bridge.MostrarTotales();
            //bridge.Listar();

            //Console.WriteLine("=======");

            //bridge = new CAbstraccion(new CImplementacion3(), productos);

            //bridge.MostrarTotales();
            //bridge.Listar();

            //Uso del segundo constructor

            for (int i = 1; i <= 3; i++)
            {
                CAbstraccion bridge = new CAbstraccion(i, productos);
                bridge.MostrarTotales();
                bridge.Listar();
                Console.WriteLine("=======");
            }
        }
    }
}