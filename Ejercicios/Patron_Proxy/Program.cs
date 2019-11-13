using System;

namespace Patron_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //CProxy.ISujeto miProxy = new CProxy.ProxiSencillo();
            //miProxy.Peticion(1);
            
            //Console.WriteLine("-----");

            //miProxy.Peticion(2);

            //Console.WriteLine("-----");

            //Uso del proxy seguro

            CProxy.ISujeto miProxyS = new CProxy.ProxiSeguro();
            miProxyS.Peticion(1);

            Console.WriteLine("-----");

            miProxyS.Peticion(2);

            Console.WriteLine("-----");
        }
    }
}
