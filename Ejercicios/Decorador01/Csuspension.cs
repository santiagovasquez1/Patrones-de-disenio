using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador01
{
    class Csuspension:IComponentes
    {
        private IComponentes decoramosA;

        //Pasamos el objeto que va a ser decorado
        public Csuspension(IComponentes pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto rendimiento\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 60;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ",Suspension listo";
        }
    }
}
