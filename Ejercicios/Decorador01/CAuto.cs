using System;

namespace Decorador01
{
    internal class CAuto : IComponentes
    {
        private string Modelo;
        private string Caracteristicas;
        public double costo;

        public CAuto(string pModelo, string pCaract, double pCosto)
        {
            Modelo = pModelo;
            Caracteristicas = pCaract;
            costo = pCosto;
        }

        public void puertas(bool Estado)
        {
            if (Estado) Console.WriteLine("Puertas cerradas");
            else Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo{0},{1} \r\n", Modelo, Caracteristicas);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}